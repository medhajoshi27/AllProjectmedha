﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PerformanceLinqSearch()
        {
            // Get the model (setup) of the grid defined in the /Models folder.
            var gridModel = new OrdersJqGridModel();
            var ordersGrid = gridModel.OrdersGrid;

            // Setting the DataUrl to an action (method) in the controller is required.
            // This action will return the data needed by the grid
            ordersGrid.DataUrl = Url.Action("SearchGridDataRequested");

            // customize the default Orders grid model with custom settings
            // NOTE: you need to call this method in the action that fetches the data as well,
            // so that the models match
            SetUpGrid(ordersGrid);

            // Pass the custmomized grid model to the View
            return View(gridModel);
        }

        // This method is called when the grid requests data        
        public JsonResult SearchGridDataRequested()
        {
            // Get both the grid Model and the data Model
            // The data model in our case is an autogenerated linq2sql database based on Northwind.
            var gridModel = new OrdersJqGridModel();
            var northWindModel = new NorthwindDataContext();

            // customize the default Orders grid model with our custom settings
            SetUpGrid(gridModel.OrdersGrid);

            JQGridState gridState = gridModel.OrdersGrid.GetState();
            Session["gridState"] = gridState;
            // return the result of the DataBind method, passing the datasource as a parameter
            // jqGrid for ASP.NET MVC automatically takes care of paging, sorting, filtering/searching, etc

            return gridModel.OrdersGrid.DataBind(northWindModel.OrdersLarges);
        }

        public JsonResult AutoCompleteShipName(string term)
        {
            var northWindModel = new NorthwindDataContext();
            JQAutoComplete autoComplete = new JQAutoComplete();

            autoComplete.DataField = "ShipName";
            autoComplete.AutoCompleteMode = AutoCompleteMode.BeginsWith;
            autoComplete.DataSource = from o in northWindModel.Orders
                                      select o;
            return autoComplete.DataBind();
        }

        private void SetUpGrid(JQGrid ordersGrid)
        {
            // show the search toolbar
            ordersGrid.ToolBarSettings.ShowSearchToolBar = true;
            ordersGrid.ToolBarSettings.ShowSearchButton = true;

            var orderDateColumn = ordersGrid.Columns.Find(c => c.DataField == "OrderDate");
            orderDateColumn.DataFormatString = "{0:yyyy/MM/dd}";
            orderDateColumn.SearchType = SearchType.DatePicker;
            orderDateColumn.DataType = typeof(DateTime);
            orderDateColumn.SearchControlID = "DatePicker";
            orderDateColumn.SearchToolBarOperation = SearchOperation.IsEqualTo;

            var shipNameColumn = ordersGrid.Columns.Find(c => c.DataField == "ShipName");
            shipNameColumn.SearchType = SearchType.AutoComplete;
            shipNameColumn.DataType = typeof(string);
            shipNameColumn.SearchControlID = "AutoComplete";
            shipNameColumn.SearchToolBarOperation = SearchOperation.Contains;

            var orderIDColumns = ordersGrid.Columns.Find(c => c.DataField == "OrderID");
            orderIDColumns.Searchable = true;
            orderIDColumns.DataType = typeof(int);
            orderIDColumns.SearchToolBarOperation = SearchOperation.IsEqualTo;

            SetUpCustomerIDSearchDropDown(ordersGrid);
            SetUpFreightSearchDropDown(ordersGrid);
        }

        private void SetUpCustomerIDSearchDropDown(JQGrid ordersGrid)
        {
            // setup the grid search criteria for the columns
            JQGridColumn customersColumn = ordersGrid.Columns.Find(c => c.DataField == "CustomerID");
            customersColumn.Searchable = true;

            // DataType must be set in order to use searching
            customersColumn.DataType = typeof(string);
            customersColumn.SearchToolBarOperation = SearchOperation.IsEqualTo;
            customersColumn.SearchType = SearchType.DropDown;

            // Populate the search dropdown only on initial request, in order to optimize performance
            if (ordersGrid.AjaxCallBackMode == AjaxCallBackMode.RequestData)
            {
                var northWindModel = new NorthwindDataContext();
                var searchList = from customers in northWindModel.Customers
                                 select new SelectListItem
                                 {
                                     Text = customers.CustomerID,
                                     Value = customers.CustomerID
                                 };

                customersColumn.SearchList = searchList.ToList();
                customersColumn.SearchList.Insert(0, new SelectListItem { Text = "All", Value = "" });
            }
        }

        private void SetUpFreightSearchDropDown(JQGrid ordersGrid)
        {
            // setup the grid search criteria for the columns
            JQGridColumn freightColumn = ordersGrid.Columns.Find(c => c.DataField == "Freight");
            freightColumn.Searchable = true;

            // DataType must be set in order to use searching
            freightColumn.DataType = typeof(decimal);
            freightColumn.SearchToolBarOperation = SearchOperation.IsGreaterOrEqualTo;
            freightColumn.SearchType = SearchType.DropDown;

            // Populate the search dropdown only on initial request, in order to optimize performance
            if (ordersGrid.AjaxCallBackMode == AjaxCallBackMode.RequestData)
            {
                List searchList = new List();
                searchList.Add(new SelectListItem { Text = "> 10", Value = "10" });
                searchList.Add(new SelectListItem { Text = "> 30", Value = "30" });
                searchList.Add(new SelectListItem { Text = "> 50", Value = "50" });
                searchList.Add(new SelectListItem { Text = "> 100", Value = "100" });

                freightColumn.SearchList = searchList.ToList();
                freightColumn.SearchList.Insert(0, new SelectListItem { Text = "All", Value = "" });
            }
        }
    }
}