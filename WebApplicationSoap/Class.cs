using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;

namespace WebApplicationSoap
{
    public class Class : ComarcasServentias
    {
        Task<retornarServentiasPorComarcaResponse> ComarcasServentias.retornarServentiasPorComarcaAsync(retornarServentiasPorComarca request)
        {
            throw new NotImplementedException();
        }

        Task<retornarTodasComarcasResponse> ComarcasServentias.retornarTodasComarcasAsync(retornarTodasComarcas request)
        {
            throw new NotImplementedException();
        }
    }
}
