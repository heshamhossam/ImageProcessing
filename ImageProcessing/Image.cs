using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class Image
    {
        private string _imagePath;
        private Bitmap _bitmapImage;


        protected Color[,] _imageMatrix;
        public Color[,] ImageMatrix
        {
            get { return _imageMatrix; }
        }

        /// <summary>
        /// Construct the image object from image path
        /// </summary>
        /// <param name="imagePath"></param>
        public Image(string imagePath)
        {
            // TODO: Complete member initialization
            this._imagePath = imagePath;
            
            
        }

        public Image()
        {
            // TODO: Complete member initialization
        }

        public void zoomIn(double percent)
        {

        }
        
    }
}
