using MediPlus.BL.Services.Abstractions;
using MediPlusApp.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediPlusApp.MVC.Controllers;

public class HomeController : Controller
{
    private readonly IGenericCRUDService _service;
    
    public HomeController(IGenericCRUDService service)
    {
        _service = service;
    }
    
    public async Task<IActionResult> Index()
    {
        IEnumerable<SliderItem> sliderItems = await _service.GetAllAsync<SliderItem>();
        List<SliderItem> threeSliderItems = sliderItems.OrderByDescending(x => x.Id).Take(3).ToList();
        return View(threeSliderItems);
    }
}