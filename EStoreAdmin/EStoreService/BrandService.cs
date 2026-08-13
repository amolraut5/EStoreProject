using EstoreModel.Models.BrandModels;
using EstoreModel.ServiceContracts;
using EStoreRepository;

namespace EStoreService
{
    public class BrandService:IBrandService
    {
        private readonly BrandRepository _brandRepository;

        public BrandService(BrandRepository brandRepository) 
        {
            _brandRepository = brandRepository;
        }
        public List<BrandModel> ListBrands()
        {
            List <BrandModel> brandModels = 
                this._brandRepository.Brands.ToList();
            
            return brandModels;
        }

    }
}
