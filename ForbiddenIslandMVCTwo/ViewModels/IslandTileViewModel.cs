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

        /// <summary>
        /// Will get the filePath of the of image based on its name
        /// It will replace all spaces in the name with underscores
        /// If there is no file of that name it will return the ugly no tile image
        /// </summary>
        public string FilePath
        {
            get
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    string fileWithFullPath = String.Format(@"~/Images/120x120/{0}.{1}", Name.Replace(" ", "_"), "jpg");
                    if (File.Exists(HttpContext.Current.Server.MapPath(fileWithFullPath)))
                    {
                        return fileWithFullPath;
                    }
                }
                return @"~/Images/120x120/No_Tile.jpg";
            }
        }

        /// <summary>
        /// This will display a image
        /// Can be used with : 
        /// <img src="data:image;base64,@System.Convert.ToBase64String(Model.ImageArray)" />
        /// </summary>
        public byte[] ImageArray
        {
            get
            {
                //edit img https://msdn.microsoft.com/en-us/library/4sahykhd%28v=vs.110%29.aspx
                using (var memoryStream = new MemoryStream())
                {
                    String path = HttpContext.Current.Server.MapPath(FilePath);
                    var image = Image.FromFile(path);
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
                    return memoryStream.ToArray();
                }
            }
        }

    }
}