using EstoreModel.Models.BrandModels;
using EStoreService;
using Microsoft.AspNetCore.Mvc;

namespace EstoreAdminModule.Contollers
{
    public class BrandController : Controller
    {
        [HttpGet] // Method type
        [Route("/")] //After local host we will get "/"

        //Below code for the single object return in JSON format
        /*
        public ActionResult Index()
        {
            BrandModel brandModel = new BrandModel();   //Here we have create an object of BrandModel class
            brandModel.Id=Guid.NewGuid();
            brandModel.Name = "Brand Name";
            return Ok(brandModel);
        }
        */


        //Here we have creating the List and return
        public ActionResult Index()
        {
            BrandService brandService = new BrandService();
            
            List<BrandModel> brandModels = brandService.ListBrands();


            //return Ok(brandModels); // if you don't have to show in view the used "Ok(brandModel)"
           return View(brandModels);  //Here we have return in view
        }
    }
}
