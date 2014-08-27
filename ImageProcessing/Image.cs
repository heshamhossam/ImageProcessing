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
        public string Path
        {
            get { return _imagePath; }
        }
        private Bitmap _bitmapImage;
        public Bitmap Bitmap 
        {
            get { return _bitmapImage; }
        }

        protected Color[,] _matrix;
        public Color[,] Matrix
        {
            get { return _matrix; }
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
            this._matrix = getImageMatrix(this._bitmapImage);

        }

        public Image()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// Zooms in the current image
        /// </summary>
        /// <param name="scalingFactor"></param>
        public void zoom(double scalingFactor)
        {
            int scaledWidth = (int)Math.Floor(_matrix.GetLength(0) * scalingFactor);
            int scaledHeight = (int)Math.Floor(_matrix.GetLength(1) * scalingFactor);

            Color[,] scaledImageMatrix = new Color[scaledWidth, scaledHeight];

            double sourceCoordX, sourceCoordY;
            int sourceCoordXFloored, sourceCoordYFloored;

            for (int x = 0; x < scaledWidth; x++)
            {
                for (int y = 0; y < scaledHeight; y++)
                {
                    sourceCoordX = ((double)x / scaledWidth) * _matrix.GetLength(0);
                    sourceCoordXFloored = (int)Math.Floor(sourceCoordX);

                    sourceCoordY = ((double)y / scaledHeight) * _matrix.GetLength(1);
                    sourceCoordYFloored = (int)Math.Floor(sourceCoordY);

                    scaledImageMatrix[x, y] = _matrix[sourceCoordXFloored, sourceCoordYFloored];

                }
            }


            _matrix = scaledImageMatrix;
        }

        /// <summary>
        /// Compose the current image from the list of images given
        /// </summary>
        /// <param name="images"></param>
        public void compose(List<Image> images)
        {
            
            //find biggest image with height
            int width = images[0].Matrix.GetLength(0);
            int height = images[0].Matrix.GetLength(1);

            foreach (var image in images)
	        {
		        if (image.Matrix.GetLength(0) > width)
                    width = image.Matrix.GetLength(0);

                if (image.Matrix.GetLength(1) > height)
                    height = image.Matrix.GetLength(1);
	        }

            //build the new image composed of the given images
            _bitmapImage = new Bitmap(width, height);
            _matrix = new Color[width, height];

            foreach (Image image in images)
            {
                for (int i = 0; i < image.Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < image.Matrix.GetLength(1); j++)
                    {
                        _bitmapImage.SetPixel(i, j, image.Matrix[i, j]);
                        _matrix[i, j] = image.Matrix[i, j];
                    }
                }
            }


        }

        private Color[,] getImageMatrix(Bitmap bitmap)
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


        public override string ToString()
        {
            return Path;
        } 
    }
}
