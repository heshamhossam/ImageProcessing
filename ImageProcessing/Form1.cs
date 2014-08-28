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
        //list of images(layers) in this application
        private BindingList<Image> _images = new BindingList<Image>();
        //the composite image made of all layers
        private Image _compositeImage = new Image();
        //handler called whenever the image layers are changed
        private event EventHandler ImagesChanged;
        //corner points of cropping
        private Point _firstCorner, _secondCorner;   
        
        


        public Form1()
        {
            InitializeComponent();

            //set the open file dialog tittle
            openFileDialogLoadImage.Title = "Load Image";
            //set the on images change handler
            ImagesChanged += ImagesChangedHandler;
            //set the selection mode of listbox layers to multiple
            listBoxLayers.SelectionMode = SelectionMode.MultiExtended;
            //bind the images to the list box
            listBoxLayers.DataSource = _images;
            //save file dialog default extensions
            saveFileDialogSaveImage.Title = "Save Image";
            saveFileDialogSaveImage.DefaultExt = "jpeg";
            saveFileDialogSaveImage.Filter = "Image files (*.jpeg)|*.jpeg";
                
        }

        /// <summary>
        /// Handles the change in list of images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImagesChangedHandler(object sender, EventArgs e)
        {
            //compose a new image
            _compositeImage.compose(_images.ToList());
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
            
            //loop on each selected layer
            foreach (Image layer in listBoxLayers.SelectedItems)
            {
                //zoom with 110%
                layer.zoom(1.1, Interpolation.NEAREST_NEIGHBOR);
            }
            //call the on image layers change event handler
            OnImagesChange(EventArgs.Empty);
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            //loop on each selected layer
            foreach (Image layer in listBoxLayers.SelectedItems)
            {
                //zoom with 90%
                layer.zoom(0.9, Interpolation.NEAREST_NEIGHBOR);
            }
            //call the on image layers change event handler
            OnImagesChange(EventArgs.Empty);
        }

        private void buttonLayerUp_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedLayerIndex = listBoxLayers.SelectedIndex;
                if (selectedLayerIndex > 0)
                {
                    Image tmp = (Image)listBoxLayers.SelectedItem;
                    _images[selectedLayerIndex] = _images[selectedLayerIndex - 1];
                    _images[selectedLayerIndex - 1] = tmp;
                    listBoxLayers.ClearSelected();
                    listBoxLayers.SelectedIndex = selectedLayerIndex - 1;
                    OnImagesChange(EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void buttonLayerDown_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedLayerIndex = listBoxLayers.SelectedIndex;
                if (selectedLayerIndex < listBoxLayers.Items.Count - 1)
                {
                    Image tmp = (Image)listBoxLayers.SelectedItem;
                    _images[selectedLayerIndex] = _images[selectedLayerIndex + 1];
                    _images[selectedLayerIndex + 1] = tmp;
                    listBoxLayers.ClearSelected();
                    listBoxLayers.SelectedIndex = selectedLayerIndex + 1;
                    OnImagesChange(EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonLayerDelete_Click(object sender, EventArgs e)
        {
            try 
	        {
                _images.RemoveAt(listBoxLayers.SelectedIndex);
                OnImagesChange(EventArgs.Empty);
	        }
	        catch (Exception)
	        {
		
		        
	        }
            
        }

        private void pictureBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            _firstCorner = new Point(e.X, e.Y);
        }

        private void pictureBoxImage_MouseUp(object sender, MouseEventArgs e)
        {
            _secondCorner = new Point(e.X, e.Y);
        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            _compositeImage.crop(_firstCorner, _secondCorner);
            viewImage(_compositeImage);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogSaveImage.ShowDialog() == DialogResult.OK)
            {
                _compositeImage.save(saveFileDialogSaveImage.FileName);
            }
            
        }

        private void buttonFlipRight_Click(object sender, EventArgs e)
        {
            //loop on each selected layer
            foreach (Image layer in listBoxLayers.SelectedItems)
            {
                layer.rotate(90.0);
            }
            //call the on image layers change event handler
            OnImagesChange(EventArgs.Empty);
        }

        private void buttonFlipLeft_Click(object sender, EventArgs e)
        {
            //loop on each selected layer
            foreach (Image layer in listBoxLayers.SelectedItems)
            {
                layer.rotate(-90.0);
            }
            //call the on image layers change event handler
            OnImagesChange(EventArgs.Empty);
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            //loop on each selected layer
            foreach (Image layer in listBoxLayers.SelectedItems)
            {
                layer.rotate((double)numericUpDownAngle.Value);
            }
            //call the on image layers change event handler
            OnImagesChange(EventArgs.Empty);
        }
    }
}
