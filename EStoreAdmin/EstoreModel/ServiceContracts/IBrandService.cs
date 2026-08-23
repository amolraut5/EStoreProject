using EstoreModel.Models.BrandModels;

namespace EstoreModel.ServiceContracts
{
    public interface IBrandService
    {
        List<BrandModel> ListBrands();

        void DeleteBrand(Guid Id);
       
    }
    
}
