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
    public class UsuarioController : Controller
    {
         public string uriBase = "http://guiwell.somee.com/PontoApi/Usuarios/";

      [HttpGet]
    public ActionResult Index()
    {
        return View("CadastrarFuncionario");
    }
    [HttpPost]
    public async Task<ActionResult> RegistrarAsync(UsuarioViewModel f)
    {
        try
        {

            HttpClient httpClient = new HttpClient();
            string uriComplementar = "Registrar";

            var content = new StringContent(JsonConvert.SerializeObject(f));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

            string serialized = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                TempData["Mensagem"] = 
                 string.Format("Funcionário {0} Cadastrado!!", f.Username);
                 return View("AutenticarUsuario");
            }
            else
            {
                throw new  System.Exception(serialized);
            }
        }
        catch (System.Exception ex)
        {
            TempData["MensagemErro"] = ex.Message;
            return RedirectToAction("Index");
        }
    }
    }
}