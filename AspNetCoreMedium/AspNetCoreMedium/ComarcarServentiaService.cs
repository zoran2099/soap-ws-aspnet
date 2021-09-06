using ComarcarServentiaServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMedium
{
    public class ComarcarServentiaService : ComarcasServentias
    {
        public Task<retornarServentiasPorComarcaResponse> retornarServentiasPorComarcaAsync(retornarServentiasPorComarca request)
        {
            
            throw new NotImplementedException();
        }

        public Task<retornarTodasComarcasResponse> retornarTodasComarcasAsync(retornarTodasComarcas request)
        {
            var returno = Task<retornarTodasComarcasResponse>.Run( () => {
                var retornoComarcaWS = new retornoComarcaWS();
                retornoComarcaWS.codigoRetorno = 1;
                retornoComarcaWS.mensagemTecnica = "tetr";
                retornoComarcaWS.mensagemUsuario = "terasas";

                retornoComarcaWS.codigoRetornoSpecified = true;

                var comarca = new comarcaWS();
                comarca.codigo = 111;
                comarca.codigoSpecified = true;
                comarca.instancia = 32132;
                comarca.instanciaSpecified = true;

                comarca.nome = "capeta";


                var comarca2 = new comarcaWS();
                comarca2.codigo = 111;
                comarca2.codigoSpecified = true;
                comarca2.instancia = 32132;
                comarca2.instanciaSpecified = true;

                comarca2.nome = "capeta";

                retornoComarcaWS.listaComarcas = new comarcaWS[4] { comarca , comarca2, comarca, comarca2 };

                var tmp = new retornarTodasComarcasResponse(retornoComarcaWS);
                return tmp;
            });

            return (Task<retornarTodasComarcasResponse>)returno;

            
            //throw new NotImplementedException();
        }
    }
}
