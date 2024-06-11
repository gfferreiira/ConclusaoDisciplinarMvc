using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Conclusao_DisciplinarMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Conclusao_DisciplinarMvc.Controllers
{
    public class FuncionarioController : Controller
    {
      public string uriBase = "sommexyz/Funcionario/";

      [HttpGet]
    public ActionResult Index()
    {
        return View("CadastrarFuncionario");
    }
    }
}