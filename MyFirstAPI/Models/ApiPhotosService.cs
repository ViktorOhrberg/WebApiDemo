using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Models
{
    public class ApiPhotosService
    {
        public Photo[] Photos =        
        {   
            new Photo { albumId = 1, id  = 1, thumbnailUrl="", title = "pic1", url ="https://i.picsum.photos/id/1/200/300.jpg?hmac=jH5bDkLr6Tgy3oAg5khKCHeunZMHq0ehBZr6vGifPLY" },
            new Photo { albumId = 1, id  = 2, thumbnailUrl="", title = "pic2", url ="https://i.picsum.photos/id/0/5616/3744.jpg?hmac=3GAAioiQziMGEtLbfrdbcoenXoWAW-zlyEAMkfEdBzQ" },
            new Photo { albumId = 1, id = 3, thumbnailUrl = "", title = "pic3", url = "https://i.picsum.photos/id/100/2500/1656.jpg?hmac=gWyN-7ZB32rkAjMhKXQgdHOIBRHyTSgzuOK6U0vXb1w" }
        };

        internal Photo[] GetPhotos()
        {
            return Photos;
        }
    }
}
