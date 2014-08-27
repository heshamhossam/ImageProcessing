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
        //list item image dictionary
        private Dictionary<String, Image> _listBoxItemImageDictionary = new Dictionary<String, Image>();
        


        public Form1()
        {
            InitializeComponent();

            //set the open file dialog tittle
            openFileDialogLoadImage.Title = "Load Image";
            //set the on images change handler
            ImagesChanged += ImagesChangedHandler;
            //set the selection mode of listbox layers to multiple
            listBoxLayers.SelectionMode = SelectionMode.MultiExtended;
                
        }

        /// <summary>
        /// Handles the change in list of images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImagesChangedHandler(object sender, EventArgs e)
        {
            //compose a new image
            _compositeImage.compose(_images);
            //view the composed image
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
                //connect the list item with the image
                _listBoxItemImageDictionary.Add(_images[_images.Count - 1].ToString(), _images[_images.Count - 1]);
                //add the new image to the layers
                listBoxLayers.Items.Add(_images[_images.Count - 1].ToString());

                OnImagesChange(EventArgs.Empty);
            }
        }

        /// <summary>
        /// View Image in picture box
        /// </summary>
        /// <param name="_compositeImage">image to view in the picture box</param>
        private void viewImage(Image _compositeImage)
        {
            pictureBoxImage.Image = _compositeImage.Bitmap;
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            foreach (var layer in listBoxLayers.SelectedItems)
            {
                _listBoxItemImageDictionary[layer.ToString()].zoom(1.1);
            }

            OnImagesChange(EventArgs.Empty);
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            foreach (var layer in listBoxLayers.SelectedItems)
            {
                _listBoxItemImageDictionary[layer.ToString()].zoom(0.9);
            }

            OnImagesChange(EventArgs.Empty);
        }
    }
}
