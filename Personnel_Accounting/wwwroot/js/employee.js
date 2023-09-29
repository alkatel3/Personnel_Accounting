var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: 'home/index' },
        "columns": [
            { data: 'Last Name', "width": "15%" },
            { data: 'First Name', "width": "15%" },
            { data: 'Middle Name', "width": "15%" },
            { data: 'Birth Year', "width": "15%" },
            { data: 'Education', "width": "15%" },
            { data: 'Position', "width": "15%" },
            { data: 'Salaty', "width": "10%" },
            {}
        ]
    });
}