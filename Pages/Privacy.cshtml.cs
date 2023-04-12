using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nuevapracticaclase2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    
    [BindProperty]
    public Form Data {get;set;}

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["parametrox"];
        var parametro2 = Request.Query["parametroy"];
        Data=new Form();
        Data.Mail=parametro;
        Data.Password=parametro2;

    }

    public IActionResult OnPost ()
    {
        Console.WriteLine("entré a la función");
        if (!ModelState.IsValid){
            return Page();
        }
        //guardar en la base de datos, procesar información
        var formValues=Data;
        
        return RedirectToPage("Index");
    }
}

