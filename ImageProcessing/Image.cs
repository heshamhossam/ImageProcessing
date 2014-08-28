using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public enum Interpolation
    {
        NEAREST_NEIGHBOR,
        BILINEAR
    };

    public class Image
    {
        private string _imagePath;
        public string Path
        {
            get { return _imagePath; }
        }
        public Bitmap Bitmap 
        {
            get 
            {
                Bitmap bitmap = new Bitmap(_matrix.GetLength(0), _matrix.GetLength(1));

                for (int i = 0; i < _matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _matrix.GetLength(1); j++)
                    {
                        bitmap.SetPixel(i, j, _matrix[i, j]);
                    }
                }

                return bitmap;
            }
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
            Bitmap bitmapImage = new Bitmap(imagePath);
            this._matrix = getImageMatrix(bitmapImage);

        }

        public Image()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// Zooms in the current image
        /// </summary>
        /// <param name="scalingFactor"></param>
        public void zoom(double scalingFactor, Interpolation interpolationTechnique)
        {
            int scaledWidth = (int)Math.Floor(_matrix.GetLength(0) * scalingFactor);
            int scaledHeight = (int)Math.Floor(_matrix.GetLength(1) * scalingFactor);

            Color[,] scaledImageMatrix = new Color[scaledWidth, scaledHeight];

            double sourceCoordX, sourceCoordY, adjustedCoordX, adjustedCoordY, distanceX, distanceY, prevPixelRatioX, nextPixelRatioX, prevPixelRatioY, nextPixelRatioY;
            int sourceCoordXFloored, sourceCoordYFloored, red, green, blue;
            Color topMergedColor, bottomMergedColor, mergedColor, prevColor, nextColor;
            for (int x = 0; x < scaledWidth; x++)
            {
                for (int y = 0; y < scaledHeight; y++)
                {
                    sourceCoordX = ((double)x / scaledWidth) * _matrix.GetLength(0);
                    sourceCoordY = ((double)y / scaledHeight) * _matrix.GetLength(1);
                    sourceCoordXFloored = (int)Math.Floor(sourceCoordX);
                    sourceCoordYFloored = (int)Math.Floor(sourceCoordY);

                    switch (interpolationTechnique)
                    {
                        case Interpolation.NEAREST_NEIGHBOR:
                            scaledImageMatrix[x, y] = _matrix[sourceCoordXFloored, sourceCoordYFloored];
                            if (sourceCoordXFloored < _matrix.GetLength(0) - 1 && sourceCoordYFloored < _matrix.GetLength(1) - 1)
                                scaledImageMatrix[x, y] = _matrix[sourceCoordXFloored + 1, sourceCoordYFloored + 1];
                            break;

                        case Interpolation.BILINEAR:
                            #region Bilinear interpolation 
                            adjustedCoordX = sourceCoordX - 0.5;
                            distanceX = adjustedCoordX - Math.Floor(adjustedCoordX);
                            prevPixelRatioX = 1 - distanceX;
                            nextPixelRatioX = distanceX;

                            prevColor = _matrix[sourceCoordXFloored, sourceCoordYFloored];

                            try
                            {
                                nextColor = _matrix[sourceCoordXFloored, sourceCoordYFloored + 1];
                            }
                            catch (Exception)
                            {
                                nextColor = _matrix[sourceCoordXFloored, sourceCoordYFloored];
                            }
                                

                            red = (int)Math.Floor(prevColor.R * prevPixelRatioX + nextColor.R * nextPixelRatioX);
                            green = (int)Math.Floor(prevColor.G * prevPixelRatioX + nextColor.G * nextPixelRatioX);
                            blue = (int)Math.Floor(prevColor.B * prevPixelRatioX + nextColor.B * nextPixelRatioX);
                            topMergedColor = Color.FromArgb(red, green, blue);


                            try
                            {
                                prevColor = _matrix[sourceCoordXFloored + 1, sourceCoordYFloored];
                            }
                            catch (Exception)
                            {
                                prevColor = _matrix[sourceCoordXFloored, sourceCoordYFloored];
                            }
                            

                            try
                            {
                                nextColor = _matrix[sourceCoordXFloored + 1, sourceCoordYFloored + 1];
                            }
                            catch (Exception)
                            {
                                nextColor = _matrix[sourceCoordXFloored, sourceCoordYFloored];
                            }

                            red = (int)Math.Floor(prevColor.R * prevPixelRatioX + nextColor.R * nextPixelRatioX);
                            green = (int)Math.Floor(prevColor.G * prevPixelRatioX + nextColor.G * nextPixelRatioX);
                            blue = (int)Math.Floor(prevColor.B * prevPixelRatioX + nextColor.B * nextPixelRatioX);
                            bottomMergedColor = Color.FromArgb(red, green, blue);

                            
                            

                            adjustedCoordY = sourceCoordY - 0.5;
                            distanceY = adjustedCoordY - Math.Floor(adjustedCoordY);
                            prevPixelRatioY = 1 - distanceY;
                            nextPixelRatioY = distanceY;

                            red = (int)Math.Floor(topMergedColor.R * prevPixelRatioY + bottomMergedColor.R * nextPixelRatioY);
                            green = (int)Math.Floor(topMergedColor.G * prevPixelRatioY + bottomMergedColor.G * nextPixelRatioY);
                            blue = (int)Math.Floor(topMergedColor.B * prevPixelRatioY + bottomMergedColor.B * nextPixelRatioY);
                            mergedColor = Color.FromArgb(red, green, blue);


                            scaledImageMatrix[x, y] = mergedColor;

                            #endregion
                            break;

                            
                    }
                    

                    

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

            _matrix = new Color[width, height];

            foreach (Image image in images)
            {
                for (int i = 0; i < image.Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < image.Matrix.GetLength(1); j++)
                    {
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

        internal void crop(Point _firstCorner, Point _secondCorner)
        {
            throw new NotImplementedException();
        }

        internal void save(string p)
        {
            throw new NotImplementedException();
        }

        public void rotate(double angle)
        {
            angle = Math.PI * angle / 180.0;
            double cosAngle = Math.Cos(-angle);
            double sinAngle = Math.Sin(-angle);
            double rotatedSourceX, rotatedSourceY;
            int translatedX, translatedY;
           

            Color[,] rotatedMatrix = new Color[_matrix.GetLength(0), _matrix.GetLength(1)];

            

            for (int x = 0; x < rotatedMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < rotatedMatrix.GetLength(1); y++)
                {

                    translatedX = x - rotatedMatrix.GetLength(0) / 2;
                    translatedY = y - rotatedMatrix.GetLength(1) / 2;

                    rotatedSourceX = translatedX * cosAngle - translatedY * sinAngle;


                    rotatedSourceY = translatedX * sinAngle + translatedY * cosAngle;


                    rotatedSourceX += rotatedMatrix.GetLength(0) / 2;
                    rotatedSourceY += rotatedMatrix.GetLength(1) / 2;

                    if (rotatedSourceX > 0 && rotatedSourceX < _matrix.GetLength(0))
                    {
                        if (rotatedSourceY > 0 && rotatedSourceY < _matrix.GetLength(1))
                        {
                            rotatedMatrix[x, y] = _matrix[(int)Math.Floor(rotatedSourceX), (int)Math.Floor(rotatedSourceY)];
                            if (rotatedSourceX < _matrix.GetLength(0) - 1 && rotatedSourceY < _matrix.GetLength(1) - 1)
                                rotatedMatrix[x, y] = _matrix[(int)Math.Ceiling(rotatedSourceX), (int)Math.Ceiling(rotatedSourceY)];
                        }
                    }


                }
            }

            _matrix = rotatedMatrix;

        }
    }
}
