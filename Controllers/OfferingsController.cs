
using Microsoft.AspNetCore.Mvc;

public class OfferingsController : Controller{
    [Route("Products")]
    [Route("Products/Index")]

    public IActionResult Products(){
        return Content ("This is the products page.");
    }

    [Route("Services")]
    [Route("Services/Index")]

    public IActionResult Services(){
        return Content("This is the products page.");
    }
}