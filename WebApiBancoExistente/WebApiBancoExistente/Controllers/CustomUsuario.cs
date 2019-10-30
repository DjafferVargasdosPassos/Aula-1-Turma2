using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class UsuariosController
    {
        [HttpGet]
        [Route("Api/Usuarios/CustomUsuariosQuery")]
        public object CustomUsuariosQuery()
        {
            var listaDeUsuarios = db.Usuarios.ToList();

            var retornoUsuarios = from usu in listaDeUsuarios
                                  select new
                                  {
                                      NomeUsuario = usu.Usuario1,
                                      UsuarioId = usu.Id
                                  };

            return retornoUsuarios;
        }

        //[HttpGet]
        //[Route("Api/Carroes/CarrosComUsuariosOrderUsu")]
        //public object CustomcarrosOrderUsuarios()
        //{
        //    var listCarros = db.Carros.ToList();
        //    var listUsuarios = db.Usuarios.ToList();

        //    var conteudoRetorno = from usu in listUsuarios
        //                          join car in listCarros
        //                          on usu.Id equals car.UsuInc
        //                          select new
        //                          {                                    
        //                              UsuarioId = usu.Id,
        //                              Usuario = usu.Usuario1,
        //                              CarroId = car.Id

        //                          };
        //    return conteudoRetorno;

        //}


    }
}