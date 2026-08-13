using EstoreModel.Models.BrandModels;
using EstoreModel.ServiceContracts;
using EStoreService;
using Microsoft.AspNetCore.Mvc;

namespace EstoreAdminModule.Contollers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandservice;

        //Dependency Injection the IBrandService Object
        public BrandController(IBrandService brandservice) 
        {
            _brandservice = brandservice;
        }



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
            //here we have created the object of Brand service class
            /*
            BrandService brandService = new BrandService();
            List<BrandModel> brandModels = brandService.ListBrands();
            */
            //we have already create an object of "IBrandService" service so 
            // above class lavel object is not needed

            List<BrandModel> DIbrandModels = this._brandservice.ListBrands();


            //return Ok(brandModels); // if you don't have to show in view the used "Ok(brandModel)"
            // return View(brandModels);  //Here we have return in view
             return View(DIbrandModels);  //here we have DI objceted value return in view
        }
    }
}
