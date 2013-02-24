using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using WebAPIODataDemo.Models;

namespace WebAPIODataDemo.Controllers
{
    public class ArtistsController : EntitySetController<Artist, int>
    {
        ChinookEntities db = new ChinookEntities();

        [Queryable(AllowedQueryOptions=AllowedQueryOptions.Filter)]
        public override IQueryable<Artist> Get()
        {
            return db.Artists.AsQueryable();
        }

        protected override Artist GetEntityByKey(int key)
        {
            return db.Artists.FirstOrDefault(a => a.ArtistId == key);
        }

        [Queryable]
        public IQueryable<Album> GetAlbums([FromODataUri] int key) 
        {
            return db.Artists.Find(key).Albums.AsQueryable();
        }
    }
}