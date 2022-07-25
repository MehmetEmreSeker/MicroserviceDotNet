using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        //basicly stores the products collection of the mongodb
        IMongoCollection<Product> Products { get; }
    }
}
