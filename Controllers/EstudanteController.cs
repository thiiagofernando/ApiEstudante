using System.Collections.Generic;
using System.Linq;
using ApiEstudantes.models;
using Microsoft.AspNetCore.Mvc;


namespace ApiEstudantes.Controllers
{
    [ApiController]
    [Route("api/Estudante")]
    public class EstudanteController : ControllerBase
    {
        private ConexaoContext _context;
        public EstudanteController(ConexaoContext conexao)
        {
            _context = conexao;
        }

        [HttpGet]
        [Route("ListaDeEstudantes")]
        public List<Estudante> ListaAlunos(){

            return _context.Estudante.ToList();
        }

        [HttpPost]
        [Route("NovoEstudante")]
        public string Novo(Estudante model){
            
            if(model == null)
                return "Model Null";
            
            try
            {
                _context.Estudante.Add(model);
                _context.SaveChanges();
                return "Salvou";
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }
    }
}