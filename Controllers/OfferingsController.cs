
using Microsoft.AspNetCore.Mvc;

public class OfferingsController : Controller{
    [Route("Products")]
    [Route("Products/Index")]

    public IActionResult Products(){
        return View();
    }

    [Route("Services")]
    [Route("Services/Index")]

    public IActionResult Services(){
        return View();
    }
}