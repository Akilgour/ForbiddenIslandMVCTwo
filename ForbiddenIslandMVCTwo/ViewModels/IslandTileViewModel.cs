using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.ViewModels
{
    public class IslandTileViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        public string FilePath
        {
            get
            {
                return @"~/Images/120x120/Phantom_Rock.jpg";
            }
        }

        public byte[] ImageArray
        {
            get
            {
                //edit img https://msdn.microsoft.com/en-us/library/4sahykhd%28v=vs.110%29.aspx
                using (var memoryStream = new MemoryStream())
                {
                    var imagePath = FilePath;
                    String path = HttpContext.Current.Server.MapPath(imagePath);
                    var image = Image.FromFile(path);
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
                    return memoryStream.ToArray();
                }
            }
        }

    }
}