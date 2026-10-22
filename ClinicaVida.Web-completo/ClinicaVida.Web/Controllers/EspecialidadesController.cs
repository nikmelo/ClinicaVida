using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

// ATENÇÃO: se o seu EspecialidadesController da Aula 08 já tem a action Details
// (ou outras), mantenha-as e troque apenas o conteúdo da action Index.
public class EspecialidadesController : Controller
{
    public IActionResult Index()
    {
        var contagem = new Dictionary<int, int>();

        foreach (var e in ClinicaEmMemoria.Especialidades)
        {
            contagem[e.Id] = ClinicaEmMemoria.Medicos.Count(m => m.EspecialidadeId == e.Id);
        }

        ViewBag.MedicosPorEspecialidade = contagem;
        return View(ClinicaEmMemoria.Especialidades);
    }
}
