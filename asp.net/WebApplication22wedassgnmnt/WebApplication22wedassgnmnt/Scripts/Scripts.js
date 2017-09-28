$(document).ready(function () {
    $('#TableId').DataTable
    ({
        "columnDefs": [
          {
              "width": "5%",
              "targets": [0]
          },
          {
              "className": "text-center custom-middle-align",
              "targets": [0, 1, 2, 3, 4, 5, 6]
          }, ],
        "language":
        {
            "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
        },
        "processing": true,
        "serverSide": true,
        "ajax":
      {
          "url": "/Plugin/GetData",
          "type": "POST",
          "dataType": "JSON"
      },
        "columns": [
          {
              "data": "StudId"
          },
          {
              "data": "Name"
          },
          {
              "data": "RollNo"
          },
          {
              "data": "Course"
          },
          {
              "data": "Branch"
          },
          {
              "data": "Email"
          },
          {
              "data": "State"
          },
          {
              "data": "FatherName"
          },
        {
            "data": "Gender"
        }]

    });
})





$('#exampleModal').on('show.bs.modal', function (event) {
    var button = $(event.relatedTarget) // Button that triggered the modal
    var recipient = button.data('whatever') // Extract info from data-* attributes
    // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $(this)
    modal.find('.modal-title').text("Enter Your Details")
    modal.find('.modal-body input').val(recipient)
})








