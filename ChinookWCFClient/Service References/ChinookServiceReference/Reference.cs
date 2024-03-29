//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 20/02/2013 14:02:03
namespace ChinookWCFClient.ChinookServiceReference
{
    
    /// <summary>
    /// There are no comments for ChinookEntities in the schema.
    /// </summary>
    public partial class ChinookEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ChinookEntities object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ChinookEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("ChinookModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("ChinookWCFClient.ChinookServiceReference", typeName.Substring(12)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("ChinookWCFClient.ChinookServiceReference", global::System.StringComparison.Ordinal))
            {
                return string.Concat("ChinookModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Albums in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Album> Albums
        {
            get
            {
                if ((this._Albums == null))
                {
                    this._Albums = base.CreateQuery<Album>("Albums");
                }
                return this._Albums;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Album> _Albums;
        /// <summary>
        /// There are no comments for Artists in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Artist> Artists
        {
            get
            {
                if ((this._Artists == null))
                {
                    this._Artists = base.CreateQuery<Artist>("Artists");
                }
                return this._Artists;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Artist> _Artists;
        /// <summary>
        /// There are no comments for Genres in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Genre> Genres
        {
            get
            {
                if ((this._Genres == null))
                {
                    this._Genres = base.CreateQuery<Genre>("Genres");
                }
                return this._Genres;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Genre> _Genres;
        /// <summary>
        /// There are no comments for MediaTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<MediaType> MediaTypes
        {
            get
            {
                if ((this._MediaTypes == null))
                {
                    this._MediaTypes = base.CreateQuery<MediaType>("MediaTypes");
                }
                return this._MediaTypes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<MediaType> _MediaTypes;
        /// <summary>
        /// There are no comments for Tracks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Track> Tracks
        {
            get
            {
                if ((this._Tracks == null))
                {
                    this._Tracks = base.CreateQuery<Track>("Tracks");
                }
                return this._Tracks;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Track> _Tracks;
        /// <summary>
        /// There are no comments for Albums in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToAlbums(Album album)
        {
            base.AddObject("Albums", album);
        }
        /// <summary>
        /// There are no comments for Artists in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToArtists(Artist artist)
        {
            base.AddObject("Artists", artist);
        }
        /// <summary>
        /// There are no comments for Genres in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToGenres(Genre genre)
        {
            base.AddObject("Genres", genre);
        }
        /// <summary>
        /// There are no comments for MediaTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToMediaTypes(MediaType mediaType)
        {
            base.AddObject("MediaTypes", mediaType);
        }
        /// <summary>
        /// There are no comments for Tracks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTracks(Track track)
        {
            base.AddObject("Tracks", track);
        }
    }
    /// <summary>
    /// There are no comments for ChinookModel.Album in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AlbumId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Albums")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("AlbumId")]
    public partial class Album : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Album object.
        /// </summary>
        /// <param name="albumId">Initial value of AlbumId.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="artistId">Initial value of ArtistId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Album CreateAlbum(int albumId, string title, int artistId)
        {
            Album album = new Album();
            album.AlbumId = albumId;
            album.Title = title;
            album.ArtistId = artistId;
            return album;
        }
        /// <summary>
        /// There are no comments for Property AlbumId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int AlbumId
        {
            get
            {
                return this._AlbumId;
            }
            set
            {
                this.OnAlbumIdChanging(value);
                this._AlbumId = value;
                this.OnAlbumIdChanged();
                this.OnPropertyChanged("AlbumId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _AlbumId;
        partial void OnAlbumIdChanging(int value);
        partial void OnAlbumIdChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property ArtistId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ArtistId
        {
            get
            {
                return this._ArtistId;
            }
            set
            {
                this.OnArtistIdChanging(value);
                this._ArtistId = value;
                this.OnArtistIdChanged();
                this.OnPropertyChanged("ArtistId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ArtistId;
        partial void OnArtistIdChanging(int value);
        partial void OnArtistIdChanged();
        /// <summary>
        /// There are no comments for Artist in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Artist Artist
        {
            get
            {
                return this._Artist;
            }
            set
            {
                this._Artist = value;
                this.OnPropertyChanged("Artist");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Artist _Artist;
        /// <summary>
        /// There are no comments for Tracks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Track> Tracks
        {
            get
            {
                return this._Tracks;
            }
            set
            {
                this._Tracks = value;
                this.OnPropertyChanged("Tracks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Track> _Tracks = new global::System.Data.Services.Client.DataServiceCollection<Track>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ChinookModel.Artist in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ArtistId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Artists")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ArtistId")]
    public partial class Artist : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Artist object.
        /// </summary>
        /// <param name="artistId">Initial value of ArtistId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Artist CreateArtist(int artistId)
        {
            Artist artist = new Artist();
            artist.ArtistId = artistId;
            return artist;
        }
        /// <summary>
        /// There are no comments for Property ArtistId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ArtistId
        {
            get
            {
                return this._ArtistId;
            }
            set
            {
                this.OnArtistIdChanging(value);
                this._ArtistId = value;
                this.OnArtistIdChanged();
                this.OnPropertyChanged("ArtistId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ArtistId;
        partial void OnArtistIdChanging(int value);
        partial void OnArtistIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Albums in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Album> Albums
        {
            get
            {
                return this._Albums;
            }
            set
            {
                this._Albums = value;
                this.OnPropertyChanged("Albums");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Album> _Albums = new global::System.Data.Services.Client.DataServiceCollection<Album>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ChinookModel.Genre in the schema.
    /// </summary>
    /// <KeyProperties>
    /// GenreId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Genres")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("GenreId")]
    public partial class Genre : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Genre object.
        /// </summary>
        /// <param name="genreId">Initial value of GenreId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Genre CreateGenre(int genreId)
        {
            Genre genre = new Genre();
            genre.GenreId = genreId;
            return genre;
        }
        /// <summary>
        /// There are no comments for Property GenreId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int GenreId
        {
            get
            {
                return this._GenreId;
            }
            set
            {
                this.OnGenreIdChanging(value);
                this._GenreId = value;
                this.OnGenreIdChanged();
                this.OnPropertyChanged("GenreId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _GenreId;
        partial void OnGenreIdChanging(int value);
        partial void OnGenreIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Tracks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Track> Tracks
        {
            get
            {
                return this._Tracks;
            }
            set
            {
                this._Tracks = value;
                this.OnPropertyChanged("Tracks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Track> _Tracks = new global::System.Data.Services.Client.DataServiceCollection<Track>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ChinookModel.MediaType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MediaTypeId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("MediaTypes")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("MediaTypeId")]
    public partial class MediaType : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MediaType object.
        /// </summary>
        /// <param name="mediaTypeId">Initial value of MediaTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static MediaType CreateMediaType(int mediaTypeId)
        {
            MediaType mediaType = new MediaType();
            mediaType.MediaTypeId = mediaTypeId;
            return mediaType;
        }
        /// <summary>
        /// There are no comments for Property MediaTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int MediaTypeId
        {
            get
            {
                return this._MediaTypeId;
            }
            set
            {
                this.OnMediaTypeIdChanging(value);
                this._MediaTypeId = value;
                this.OnMediaTypeIdChanged();
                this.OnPropertyChanged("MediaTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _MediaTypeId;
        partial void OnMediaTypeIdChanging(int value);
        partial void OnMediaTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Tracks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Track> Tracks
        {
            get
            {
                return this._Tracks;
            }
            set
            {
                this._Tracks = value;
                this.OnPropertyChanged("Tracks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Track> _Tracks = new global::System.Data.Services.Client.DataServiceCollection<Track>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ChinookModel.Track in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TrackId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Tracks")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("TrackId")]
    public partial class Track : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Track object.
        /// </summary>
        /// <param name="trackId">Initial value of TrackId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="mediaTypeId">Initial value of MediaTypeId.</param>
        /// <param name="milliseconds">Initial value of Milliseconds.</param>
        /// <param name="unitPrice">Initial value of UnitPrice.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Track CreateTrack(int trackId, string name, int mediaTypeId, int milliseconds, decimal unitPrice)
        {
            Track track = new Track();
            track.TrackId = trackId;
            track.Name = name;
            track.MediaTypeId = mediaTypeId;
            track.Milliseconds = milliseconds;
            track.UnitPrice = unitPrice;
            return track;
        }
        /// <summary>
        /// There are no comments for Property TrackId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int TrackId
        {
            get
            {
                return this._TrackId;
            }
            set
            {
                this.OnTrackIdChanging(value);
                this._TrackId = value;
                this.OnTrackIdChanged();
                this.OnPropertyChanged("TrackId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _TrackId;
        partial void OnTrackIdChanging(int value);
        partial void OnTrackIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property AlbumId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> AlbumId
        {
            get
            {
                return this._AlbumId;
            }
            set
            {
                this.OnAlbumIdChanging(value);
                this._AlbumId = value;
                this.OnAlbumIdChanged();
                this.OnPropertyChanged("AlbumId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _AlbumId;
        partial void OnAlbumIdChanging(global::System.Nullable<int> value);
        partial void OnAlbumIdChanged();
        /// <summary>
        /// There are no comments for Property MediaTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int MediaTypeId
        {
            get
            {
                return this._MediaTypeId;
            }
            set
            {
                this.OnMediaTypeIdChanging(value);
                this._MediaTypeId = value;
                this.OnMediaTypeIdChanged();
                this.OnPropertyChanged("MediaTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _MediaTypeId;
        partial void OnMediaTypeIdChanging(int value);
        partial void OnMediaTypeIdChanged();
        /// <summary>
        /// There are no comments for Property GenreId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> GenreId
        {
            get
            {
                return this._GenreId;
            }
            set
            {
                this.OnGenreIdChanging(value);
                this._GenreId = value;
                this.OnGenreIdChanged();
                this.OnPropertyChanged("GenreId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _GenreId;
        partial void OnGenreIdChanging(global::System.Nullable<int> value);
        partial void OnGenreIdChanged();
        /// <summary>
        /// There are no comments for Property Composer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Composer
        {
            get
            {
                return this._Composer;
            }
            set
            {
                this.OnComposerChanging(value);
                this._Composer = value;
                this.OnComposerChanged();
                this.OnPropertyChanged("Composer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Composer;
        partial void OnComposerChanging(string value);
        partial void OnComposerChanged();
        /// <summary>
        /// There are no comments for Property Milliseconds in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Milliseconds
        {
            get
            {
                return this._Milliseconds;
            }
            set
            {
                this.OnMillisecondsChanging(value);
                this._Milliseconds = value;
                this.OnMillisecondsChanged();
                this.OnPropertyChanged("Milliseconds");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Milliseconds;
        partial void OnMillisecondsChanging(int value);
        partial void OnMillisecondsChanged();
        /// <summary>
        /// There are no comments for Property Bytes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Bytes
        {
            get
            {
                return this._Bytes;
            }
            set
            {
                this.OnBytesChanging(value);
                this._Bytes = value;
                this.OnBytesChanged();
                this.OnPropertyChanged("Bytes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Bytes;
        partial void OnBytesChanging(global::System.Nullable<int> value);
        partial void OnBytesChanged();
        /// <summary>
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this._UnitPrice = value;
                this.OnUnitPriceChanged();
                this.OnPropertyChanged("UnitPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _UnitPrice;
        partial void OnUnitPriceChanging(decimal value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Album in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Album Album
        {
            get
            {
                return this._Album;
            }
            set
            {
                this._Album = value;
                this.OnPropertyChanged("Album");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Album _Album;
        /// <summary>
        /// There are no comments for Genre in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Genre Genre
        {
            get
            {
                return this._Genre;
            }
            set
            {
                this._Genre = value;
                this.OnPropertyChanged("Genre");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Genre _Genre;
        /// <summary>
        /// There are no comments for MediaType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public MediaType MediaType
        {
            get
            {
                return this._MediaType;
            }
            set
            {
                this._MediaType = value;
                this.OnPropertyChanged("MediaType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private MediaType _MediaType;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
