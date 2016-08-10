function configurarControles() {

    $.ajaxSetup({ cache: false });

    var traducao = {
        infos: "Exibindo {{ctx.start}} até {{ctx.end}} de {{ctx.total}} registros",
        loading: "Carregando, isso pode levar alguns segundos...",
        noResults: "Não há dados para exibir",
        refresh: "Atualizar",
        search : "Pesquisar"
    };

    var configuracoesGrid = {
        ajax: true,
        columnSelection: false,
        searchSettings: {
            delay: 50,
            characters: 3
        },
        labels : traducao,
        url: urlListar,
        formatters: {
            "Acoes": function (column, row) {
                return '<a class="btn btn-success" data-toggle="tooltip" data-placement="left" ' +
                       'title="Ver detalhes" href="javascript:void(0)" data-acao="Details" data-row-id="' + row.Id + '">' +
                            '<span class="glyphicon glyphicon-list" aria-hidden="true"></span>' +
                        '</a> ' +
                        '<a class="btn btn-warning" data-toggle="tooltip" data-placement="top" ' +
                        'title="Editar" href="javascript:void(0)" data-acao="Edit" data-row-id="' + row.Id + '">' +
                            '<span class="glyphicon glyphicon-edit" aria-hidden="true"></span>' +
                        '</a> ' +
                        '<a class="btn btn-danger" data-toggle="tooltip" data-placement="right" ' +
                        'title="Excluir" href="javascript:void(0)" data-acao="Delete" data-row-id="' + row.Id + '">' +
                            '<span class="glyphicon glyphicon-remove" aria-hidden="true"></span>' +
                        '</a>';
            },
            "Dinheiro": function (column, row) {

                var numero = numeral(row.Valor);

                return numero.format('$0,0.00');
            }
        }
    }

    var grid = $("#gridDados").bootgrid(configuracoesGrid);

    grid.on("loaded.rs.jquery.bootgrid", function () {

        grid.find("a.btn").each(function (index, elemento) {

            var botaoDeAcao = $(this);

            var acao = botaoDeAcao.data("acao");
            var idEntidade = botaoDeAcao.data("row-id");

            botaoDeAcao.on("click", function () {

                abrirModal(acao, idEntidade);

            });

        });

        $('[data-toggle="tooltip"]').tooltip();

    });

    $("a[data-action='Create']").on("click", function () {

        abrirModal($(this).data("action"));
    });
}

function abrirModal(acao, parametro) {

    var url = "/{ctrl}/{acao}/{parametro}";

    url = url.replace("{ctrl}", controller);

    url = url.replace("{acao}", acao);

    if (parametro != null)
        url = url.replace("{parametro}", parametro);
    else
        url = url.replace("{parametro}", "");


    $("#conteudoModal").load(url, function () {

        $('#minhaModal').modal('show');
    });

}