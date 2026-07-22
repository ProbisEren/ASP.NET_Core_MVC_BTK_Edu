using BtkAkademiProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiProje.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply() // get için çalışan metot
        {
            return View();
        }



        [HttpPost] // bu yoksa direkt get olarak anlar ama bu varsa posttur. üsttekinde yok mesela o get,
        // alttaki için bu satırdakini koyduk dolayısıyla alttaki de post

        [ValidateAntiForgeryToken] // Kötü niyetli başka bir sitenin, kullanıcı adına senin uygulamana form isteği göndermesini 
        // engellemek için kullanırız. Yani CSRF saldırılarına karşı koruma sağlar. Genelde POST, PUT, DELETE gibi veri değiştiren 
        // işlemlerde kullanılır.

        // post  için çalışan metot
        public IActionResult Apply([FromForm]Candidate model) // Buradan gelen verinin nereden geleceğini ifade ediyor [] içerisi
        {
            Repository.Add(model);

            return Redirect("/"); 
        }
           
    }
}