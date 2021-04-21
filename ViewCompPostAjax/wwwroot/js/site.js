$(document).ready(function () {
    var table = $('#gridMenu').DataTable({
        language: {
            url: "//cdn.datatables.net/plug-ins/1.10.21/i18n/Russian.json"
        },
        "columnDefs": [{
            "searchable": false,
            "orderable": false,
            "targets": [0, 1, 9]
        }],
        "order": [[2, 'asc']]
    });

    table.on('order.dt search.dt', function () {
        table.column(0, { search: 'applied', order: 'applied' }).nodes().each(function (cell, i) {
            cell.innerHTML = i + 1;
        });
    }).draw();
});