//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIODataDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public Nullable<int> AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public Nullable<int> GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public Nullable<int> Bytes { get; set; }
        public decimal UnitPrice { get; set; }
    
        public virtual Album Album { get; set; }
    }
}
