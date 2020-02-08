using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.Models.Values;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MasterApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IConfiguration _configuration { get; set; }
        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("listaProduto")]
        public ActionResult<ProdutoModel> ListaProduto()
        {
            ProdutoModel produto = new ProdutoModel();
            produto.Id = 6;
            produto.Nome = "Teste";
            produto.Sobrenome = "Seila";
            produto.Environment = _configuration["Teste"];
            return produto;
        }
    }
}
