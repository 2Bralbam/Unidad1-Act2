using Microsoft.AspNetCore.Mvc;
using Unidad2_Act2.Models.ViewModel;

namespace Unidad2_Act2.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index(string unidad, decimal cantidad)
		{
			IndexViewModel vm = new() 
			{
				Resultado=0
			};
			if (unidad!=null && cantidad!=0) 
			{
				decimal MonedaValor = (decimal)((unidad == "mxn" || unidad == "usd") ? 17.81 : 0.057);
			
				if (unidad == "mxn"){
					vm.Resultado = Math.Round((cantidad * MonedaValor),2);
				}
				else{
					vm.Resultado = Math.Round((cantidad / MonedaValor),2);
				}
			}
			return View(vm);
		}
	}
}
