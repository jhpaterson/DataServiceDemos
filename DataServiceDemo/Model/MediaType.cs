//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataServiceDemo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MediaType
    {
        public MediaType()
        {
            this.Tracks = new HashSet<Track>();
        }
    
        public int MediaTypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
