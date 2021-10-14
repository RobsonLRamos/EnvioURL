using APITeste.Enum;
using APITeste.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITeste
{
    public static class MetodosDeExtensao
    {
         public static string RetornaURL(this IOptions<EndPointConecao> options, int venda)
        {
            switch (venda)
            {
                case (int)EnumEndPointConecao.Loja:
                    return options.Value.Loja;
                case (int)EnumEndPointConecao.APP:
                    return options.Value.APP;
                case (int)EnumEndPointConecao.Site:
                    return options.Value.Site;
                default:
                    return "";
            }

        }


    }
}
