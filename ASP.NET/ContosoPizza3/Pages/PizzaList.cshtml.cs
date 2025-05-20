using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Pages;

public class PizzaListModel(PizzaService service) : PageModel
{
    // "default!" is a special value that indicates that the property will be set later.
    public IList<Pizza> PizzaList { get; set; } = default!;

    [BindProperty]
    public Pizza NewPizza { get; set; } = default!;

    /* ////////////////////////////////////////////////////////////////////// */

    public void OnGet()
    {
        PizzaList = service.GetPizzas();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid || NewPizza == null) return Page();
        service.AddPizza(NewPizza);
        return RedirectToAction("Get");
    }

    public IActionResult OnPostDelete(int id)
    {
        service.DeletePizza(id);
        return RedirectToAction("Get");
    }
}
