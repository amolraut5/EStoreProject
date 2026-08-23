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

        public void CreateBrand(CreateBrandModel createBrandModel)
        {
            if (createBrandModel == null)
                throw new Exception("Brand Name is not null or Empty");
            BrandModel brandModel = new BrandModel()
            {
                Id=Guid.NewGuid(),
                Name=createBrandModel.Name,
            };
            this._brandRepository.Brands.Add(brandModel);
            this._brandRepository.SaveChanges();
        }

        public void DeleteBrand(Guid Id)
        {
            if (Id == Guid.Empty)
                throw new Exception("Brand Id is not null or empty");
            BrandModel?brandModel = 
                this._brandRepository.Brands.Where(e => e.Id == Id).FirstOrDefault();
            if (brandModel == null)
                throw new Exception("Brand Model Is not null or empty");
            this._brandRepository.Remove(brandModel);
            this._brandRepository.SaveChanges();
        }

        public UpdateBrandModel GetBrandById(Guid Id)
        {
            if (Id == Guid.Empty)
                throw new Exception("Brand Id is not null or empty");
            BrandModel?brandmodel
                = this._brandRepository.Brands.Where(e => e.Id == Id).FirstOrDefault();
            if (brandmodel == null)
                throw new Exception("Brand Model is Null");

            UpdateBrandModel updateBrandModel = new UpdateBrandModel()
            {
                Id = brandmodel.Id,
                Name = brandmodel.Name
            };
            return updateBrandModel;
        }

        public List<BrandModel> ListBrands()
        {
            List <BrandModel> brandModels = 
                this._brandRepository.Brands.ToList();
            
            return brandModels;
        }

    }
}
