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
            // TODO: Complete member initialization and constructs the bitmap image as well as the image matrix
            this._imagePath = imagePath;
            
            
        }

        public Image()
        {
            // TODO: Complete member initialization
        }
    
        /// <summary>
        /// Zooms in the current image
        /// </summary>
        /// <param name="percent"></param>
        public void zoom(double percent)
        {

        }

        /// <summary>
        /// Compose the current image from the list of images given
        /// </summary>
        /// <param name="_images"></param>
        public void compose(List<Image> _images)
        {
            throw new NotImplementedException();
        }
    }
}
