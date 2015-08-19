using ForbiddenIslandMVCTwo.Models;
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
        public ICollection<Player> PlayersOnTiles { get; set; }

        //This is only used for debug
        public int PlayersOnTilesCountDisplay
        {
            get
            {
                if (PlayersOnTiles.Any())
                {
                    return PlayersOnTiles.Count();
                }
                return 0;
            }
        }

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

                    int playerTokenWidth = 50;
                    int playerCircleOfset = 5;
                    int playerCircleWidth = playerTokenWidth - playerCircleOfset;

                    int tileWidth = 120;
                    int halfTileWidth = tileWidth / 2;
                    int deadSpace = playerTokenWidth - 1;

                    int availableSpace = halfTileWidth - deadSpace; 
                    Graphics newGraphics = Graphics.FromImage(image);
                    var topColour = Color.FromArgb(255, 0, 0);
                    var bottomColour = Color.FromArgb(127, 0, 0);

                    //Tempory dispay for colours this will need to get sorted
                    if (PlayersOnTiles.Count() >= 1)
                    {
                        topColour = Color.Black;
                        bottomColour = Color.FromName(PlayersOnTiles.First().Colour);
                        DrawPlayerToken(playerCircleOfset, playerCircleWidth, availableSpace, newGraphics, topColour, bottomColour, 0, 0);
                    }
                    if (PlayersOnTiles.Count() >= 2)
                    {
                        DrawPlayerToken(playerCircleOfset, playerCircleWidth, availableSpace, newGraphics, topColour, bottomColour, halfTileWidth, 0);
                    }
                    if (PlayersOnTiles.Count() >= 3)
                    {
                        DrawPlayerToken(playerCircleOfset, playerCircleWidth, availableSpace, newGraphics, topColour, bottomColour, 0, halfTileWidth);
                    }
                    if (PlayersOnTiles.Count() >= 4)
                    {
                        DrawPlayerToken(playerCircleOfset, playerCircleWidth, availableSpace, newGraphics, topColour, bottomColour, halfTileWidth, halfTileWidth);
                    }
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
                    return memoryStream.ToArray();
                }
            }
        }

        private static void DrawPlayerToken(int playerCircleOfset, int playerCircleWidth, int availableSpace, Graphics newGraphics, Color topColour,  Color bottomColour, int startX, int startY)
        {
            int pointX = new Random().Next(startX, startX + availableSpace);
            int pointY = new Random().Next(startY, startY + availableSpace);

            // Alter image.
            newGraphics.FillEllipse(new SolidBrush(topColour), pointX + playerCircleOfset, pointY + playerCircleOfset, playerCircleWidth, playerCircleWidth);
            newGraphics.FillEllipse(new SolidBrush(bottomColour), pointX, pointY, playerCircleWidth, playerCircleWidth);
        }

    }
}