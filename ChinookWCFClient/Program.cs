using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Services.Client;
using ChinookWCFClient.ChinookServiceReference;

namespace ChinookWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ChinookServiceReference.ChinookEntities(
                new Uri("http://localhost:2299/ChinookDataService.svc/"));

            //var proxy = new ChinookServiceReference.ChinookEntities(
            //    new Uri("http://localhost:8888/ChinookDataService.svc/"));

            // NOTE: capturing traffic in Fiddler
            // need to configure Reverse Proxy in Fiddler
            // if service post is 2299 then want to send request from client to localhost:8888 and have Fiddler
            // forward to localhost:2299 (note hostname for IIS Express launched from VS is localhost, not 127.0.0.1)
            //
            // In Fiddler:
            // Tools > Fiddler Options, make sure listening on 8888, tick Allow remote computers (may not be needed)
            // Rules > Customize rules, opens CustomRules.js, add the following rule in function OnBeforeRequest (use Find to locate this)
            // if (oSession.host.toLowerCase() == "localhost:8888") oSession.host = "localhost:2299";
            //
            // in new ChinookServiceReference.ChinookEntities constructor call above use localhost:8888 instead of localhost:2299
            // Start Fiddler before running app or will not be able to connect
            //
            // see also http://www.fiddler2.com/Fiddler/help/reverseproxy.asp
            // also can use Charles http://www.charlesproxy.com/ where it is simpler to set up the reverse proxy


            // NOTE: can send HTTP requests directly in Postman using URLs above each call, should set header to:
            // Accept:application/json;odata=verbose OR
            // Accept:application/json;odata=light;q=1,application/json;odata=verbose;q=0.5

            // QUERYING
            //var artists = proxy.Artists.ToList();   // leave this commented out, affects loading for other artist query

            // http://localhost:2299/ChinookDataService.svc/Albums()?$filter=Title%20eq%20'Dark%20Side%20of%20the%20Moon'&$top=1&$expand=Artist,Tracks/Genre 
            var album = proxy.Albums
                .Expand("Artist,Tracks/Genre")
                .Where(a => a.Title == "Dark Side of the Moon")
                .FirstOrDefault();

            // http://localhost:2299/ChinookDataService.svc/Tracks(129)?$expand=Genre,MediaType
            var track = proxy.Tracks
                .Expand("Genre,MediaType")
                .Where(t => t.TrackId == 129)
                .FirstOrDefault();

            // CREATING

            proxy.AddToArtists(new Artist { Name = "Steely Dan" });

            // UPDATING

            // get an object to update
            var artistToUpdate = proxy.Artists.Expand("Albums")
                .Where(a => a.ArtistId == 1)
                .FirstOrDefault();

            // update a property
            artistToUpdate.Name = "DC/AC";

            // add a new album to the artist
            Album newAlbum = Album.CreateAlbum(0, "Dirty Deeds Done Dirt Cheap", 
                artistToUpdate.ArtistId);
            proxy.AddRelatedObject(artistToUpdate, "Albums", newAlbum);
            artistToUpdate.Albums.Add(newAlbum);
            newAlbum.Artist = artistToUpdate;

            // update object
            proxy.UpdateObject(artistToUpdate);

            // save changes
            var response = proxy.SaveChanges(SaveChangesOptions.Batch);



            Console.ReadLine();
        }
    }
}
