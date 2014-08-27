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
            this._bitmapImage = new Bitmap(imagePath);
           this._imageMatrix =  GetImageMatrix(this._bitmapImage);/////////////////Construct The Image Matrix

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
        public void compose(List<Bitmap> _images)
        {
            foreach(Bitmap bit in _images)
            {
                Color[,] imagematrixtemp = GetImageMatrix(bit);
                for (int i = 0; i < imagematrixtemp.GetLength(0); i++)
                {
                    for (int j = 0; j < imagematrixtemp.GetLength(1); j++)
                    {
                        this._bitmapImage.SetPixel(this._bitmapImage.Width+i, this._bitmapImage.Height + j, imagematrixtemp[imagematrixtemp.GetLength(0) - i - 1, imagematrixtemp.GetLength(1) - j - 1]);
                    }
                }
            }
        }
        private Color[,] GetImageMatrix(Bitmap bitmap)
        {

            Color[,] imagematrix = new Color[bitmap.Width, bitmap.Height];

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    imagematrix[x, y] = bitmap.GetPixel(x, y);
                }
            }

            return imagematrix;
        }
    }
}
