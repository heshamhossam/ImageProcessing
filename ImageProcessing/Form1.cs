using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        //list of images in this application
        private List<Image> _images = new List<Image>();
        private Image _compositeImage = new Image();
        private event EventHandler ImagesChanged;


        public Form1()
        {
            InitializeComponent();

            //set the open file dialog tittle
            openFileDialogLoadImage.Title = "Load Image";
            //set the on images change handler
            ImagesChanged += ImagesChangedHandler;
        }

        /// <summary>
        /// Handles the change in list of images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImagesChangedHandler(object sender, EventArgs e)
        {
            _compositeImage.compose(_images);
            viewImage(_compositeImage);
        }

        /// <summary>
        /// on images list change
        /// </summary>
        /// <param name="e">arguments sent to the delegate</param>
        private void OnImagesChange(EventArgs e)
        {
            if (ImagesChanged != null)
            {
                ImagesChanged(this, e);
            }
        }

        /// <summary>
        /// On Load Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogLoadImage.ShowDialog() == DialogResult.OK)
            {
                _images.Add(new Image(openFileDialogLoadImage.FileName));
                OnImagesChange(EventArgs.Empty);
            }
        }

        /// <summary>
        /// View Image in picture box
        /// </summary>
        /// <param name="_compositeImage">image to view in the picture box</param>
        private void viewImage(Image _compositeImage)
        {
            throw new NotImplementedException();
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            foreach (var image in _images)
            {
                image.zoom(1.1);
            }

            OnImagesChange(EventArgs.Empty);
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            foreach (var image in _images)
            {
                image.zoom(0.9);
            }

            OnImagesChange(EventArgs.Empty);
        }
    }
}
