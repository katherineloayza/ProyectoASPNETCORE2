using Microsoft.AspNetCore.Mvc;
using ProyectoTransitoCoreMVC.Models;
using System.Linq;

namespace ProyectoTransitoCoreMVC.Controllers
{
    public class PapeletasController : Controller
    {
        //definir la variable del contexto del Entity Framework Core
        BDTRANSITO22Context bd = new BDTRANSITO22Context();

        //Listado de Papeletas
        public IActionResult ListarPapeletas()
        {
            //Obtener los datos del modelo

            //enviar los datos del modelo a la vista
            var listado = bd.Papeletas.ToList();
            return View(listado);
        }

        //Listado por Policia
        public IActionResult PapeletasPolicia(string codpol="P0002")
        {
            //LINQ - expresión de consulta
            var listado1 = (from p in bd.Papeletas
                           where p.Codpol.Equals(codpol)
                           select p).ToList();
            //LINQ - expresión Lambda
            var listado2 = bd.Papeletas
                           .Where(p => p.Codpol
                           .Equals(codpol)).ToList();
            //var listado2 = bd.Papeletas.Where
            return View(listado1);
        }
    }
}
