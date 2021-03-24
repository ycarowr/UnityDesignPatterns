using System;

namespace Bridge
{

    public class ResourceAlbum : IResource
    {
        public string Title => "TITLE from Album Resource";
        public string Snippet => "SNIPPET from Album Resource";
        public string Image => "IMAGE from Album Resource";
        public string Url => "URL from Album Resource";
    }
}