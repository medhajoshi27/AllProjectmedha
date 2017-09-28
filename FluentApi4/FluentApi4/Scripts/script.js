

$(function () {
    $("#jqGrid").jqGrid({
        url: "/Home/GetCustomers",
        datatype: 'json',
        mtype: 'Get',
        colNames: ['ID', 'Order Id' ,'Customer Name'],
        colModel: [
            { key: true, name: 'CustomerId', index: 'CustomerId', editable: true },
            { key: false, name: 'OrderId', index: 'OrderId', editable: true },
            { key: false, name: 'CustomerName', index: 'CustomerName', editable: true }],
        pager: jQuery('#jqControls'),
        rowNum: 10,
        rowList: [10, 20, 30, 40, 50],
        height: '100%',
        viewrecords: true,
        caption: 'Customers Records',
        emptyrecords: 'No Students Records are Available to Display',
        jsonReader: {
            root: "rows",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            Id: "0"
        },
        autowidth: true,
        multiselect: false
    });
}).navGrid('#jqControls', { edit: true, add: true, del: true, search: false, refresh: true },  
        {  
            zIndex: 100,  
            url: '/Home/Edit',  
            closeOnEscape: true,  
            closeAfterEdit: true,  
            recreateForm: true,  
            afterComplete: function (response) {  
                if (response.responseText) {  
                    alert(response.responseText);  
                }  
            }  
        },  
        {  
            zIndex: 100,  
            url: "/Home/Create",  
            closeOnEscape: true,  
            closeAfterAdd: true,  
            afterComplete: function (response) {  
                if (response.responseText) {  
                    alert(response.responseText);  
                }  
            }  
        },  
        {  
            zIndex: 100,  
            url: "/Home/Delete",  
            closeOnEscape: true,  
            closeAfterDelete: true,  
            recreateForm: true,  
            msg: "Are you sure you want to delete Student... ? ",  
            afterComplete: function (response) {  
                if (response.responseText) {  
                    alert(response.responseText);  
                }  
            }  
        });  
});  











//Working code for two table ---->

//$(function () {
//    $("#jqGrid").jqGrid({
//        url: "/Home/GetCustomers",
//        datatype: 'json',
//        mtype: 'Get',
//        colNames: ['ID', 'Order Id' ,'Customer Name'],
//        colModel: [
//            { key: true, name: 'CustomerId', index: 'CustomerId', editable: true },
//            { key: false, name: 'OrderId', index: 'OrderId', editable: true },
//            { key: false, name: 'CustomerName', index: 'CustomerName', editable: true }],
//        pager: jQuery('#jqControls'),
//        rowNum: 10,
//        rowList: [10, 20, 30, 40, 50],
//        height: '100%',
//        viewrecords: true,
//        caption: 'Students Records',
//        emptyrecords: 'No Students Records are Available to Display',
//        jsonReader: {
//            root: "rows",
//            page: "page",
//            total: "total",
//            records: "records",
//            repeatitems: false,
//            Id: "0"
//        },
//        autowidth: true,
//        multiselect: false
//    });
//});
















//// True Code
//$(function () {
//    $("#jqGrid").jqGrid({
//        url: "/HomeController/GetStudents",
//        datatype: 'json',
//        mtype: 'Get',
//        colNames: ['ID', 'Customer Name', 'Order Id', 'Product Name'],
//        colModel: [
//            { key: true, hidden: true, name: 'ID', index: 'ID', editable: true },
//            { key: false, name: 'Name', index: 'Name', editable: true },
//            { key: false, name: 'FatherName', index: 'FatherName', editable: true },
//            { key: false, name: 'Gender', index: 'Gender', editable: true, edittype: 'select', editoptions: { value: { 'M': 'Male', 'F': 'Female', 'N': 'None' } } },
//            { key: false, name: 'ClassName', index: 'ClassName', editable: true, edittype: 'select', editoptions: { value: { '1': '1st Class', '2': '2nd Class', '3': '3rd Class', '4': '4th Class', '5': '5th Class' } } },
//            { key: false, name: 'DateOfAdmission', index: 'DateOfAdmission', editable: true, formatter: 'date', formatoptions: { newformat: 'd/m/Y' } }],
//        pager: jQuery('#jqControls'),
//        rowNum: 10,
//        rowList: [10, 20, 30, 40, 50],
//        height: '100%',
//        viewrecords: true,
//        caption: 'Students Records',
//        emptyrecords: 'No Customer Records are Available to Display',
//        jsonReader: {
//            root: "rows",
//            page: "page",
//            total: "total",
//            records: "records",
//            repeatitems: false,
//            Id: "0"
//        },
//        autowidth: true,
//        multiselect: false
//    });
//});