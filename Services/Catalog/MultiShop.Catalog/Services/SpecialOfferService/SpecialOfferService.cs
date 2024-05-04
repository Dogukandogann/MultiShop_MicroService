using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Services.SpecialOfferService;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.CategoryService
{
    public class SpecialOfferService : ISpecialOfferService
    {
        private readonly IMongoCollection<SpecialOffer> _specialOfferCollection;
        private readonly IMapper _mapper;
        public SpecialOfferService(IDatabaseSettings _databaseSettings,IMapper mapper)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _specialOfferCollection = database.GetCollection<SpecialOffer>(_databaseSettings.SpecialOfferCollectionName);
            _mapper = mapper;
        }
        public async Task CreateSpecialOfferAsync(CreateSpecialOfferDto createSpecialOfferDto)
        {
            var value = _mapper.Map<SpecialOffer>(createSpecialOfferDto);
            await _specialOfferCollection.InsertOneAsync(value);
        }

        public async Task DeleteSpecialOfferAsync(string id)
        {
            await _specialOfferCollection.DeleteOneAsync(x=>x.SpecialOfferId.Equals(id));
        }

        public async Task<List<ResultSpecialOfferDto>> GetAllSpecialOfferAsync()
        {
            var values = await _specialOfferCollection.Find(x=>true).ToListAsync();
            return _mapper.Map<List<ResultSpecialOfferDto>>(values);
        }

        public async Task<GetByIdSpecialOfferDto> GetByIdSpecialOfferAsync(string id)
        {
            var value = await _specialOfferCollection.Find(x=>x.SpecialOfferId.Equals(id)).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdSpecialOfferDto>(value);
        }

        public async Task UpdateSpecialOfferAsync(UpdateSpecialOfferDto updateSpecialOfferDto)
        {
            var value = _mapper.Map<SpecialOffer>(updateSpecialOfferDto);
            await _specialOfferCollection.FindOneAndReplaceAsync(x=>x.SpecialOfferId.Equals(updateSpecialOfferDto.SpecialOfferId),value);
        }
    }
}
