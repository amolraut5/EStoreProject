using EstoreModel.Models.BrandModels;

namespace EstoreModel.ServiceContracts
{
    public interface IBrandService
    {
        List<BrandModel> ListBrands();

        void DeleteBrand(Guid Id);

        void CreateBrand(CreateBrandModel createBrandModel);

        UpdateBrandModel GetBrandById(Guid Id);
       
    }
    
}
