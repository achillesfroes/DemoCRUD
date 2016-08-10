using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCRUD.Infra
{
    public class ParametrosPaginacaoModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;

            ParametrosPaginacao paramPaginacao = new ParametrosPaginacao(request.Form);

            paramPaginacao.Current = int.Parse(request.Form["current"]);
            paramPaginacao.RowCount = int.Parse(request.Form["rowcount"]);
            paramPaginacao.SearchPhrase = request.Form["searchPhrase"];

            return paramPaginacao;
        }
    }
}