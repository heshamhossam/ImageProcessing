namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxImageOperations = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.buttonFlipLeft = new System.Windows.Forms.Button();
            this.buttonFlipRight = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLayerOpertations = new System.Windows.Forms.GroupBox();
            this.buttonLayerDelete = new System.Windows.Forms.Button();
            this.buttonLayerDown = new System.Windows.Forms.Button();
            this.listBoxLayers = new System.Windows.Forms.ListBox();
            this.buttonLayerUp = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.openFileDialogLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFirstCorner = new System.Windows.Forms.Label();
            this.labelSecondCorner = new System.Windows.Forms.Label();
            this.groupBoxImageOperations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxLayerOpertations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxImageOperations
            // 
            this.groupBoxImageOperations.Controls.Add(this.groupBox2);
            this.groupBoxImageOperations.Controls.Add(this.groupBox1);
            this.groupBoxImageOperations.Controls.Add(this.buttonFlipLeft);
            this.groupBoxImageOperations.Controls.Add(this.buttonFlipRight);
            this.groupBoxImageOperations.Controls.Add(this.buttonSave);
            this.groupBoxImageOperations.Controls.Add(this.buttonZoomOut);
            this.groupBoxImageOperations.Controls.Add(this.buttonZoomIn);
            this.groupBoxImageOperations.Controls.Add(this.buttonLoad);
            this.groupBoxImageOperations.Controls.Add(this.buttonCrop);
            this.groupBoxImageOperations.Location = new System.Drawing.Point(664, 3);
            this.groupBoxImageOperations.Name = "groupBoxImageOperations";
            this.groupBoxImageOperations.Size = new System.Drawing.Size(144, 413);
            this.groupBoxImageOperations.TabIndex = 0;
            this.groupBoxImageOperations.TabStop = false;
            this.groupBoxImageOperations.Text = "Operations";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRotate);
            this.groupBox1.Controls.Add(this.numericUpDownAngle);
            this.groupBox1.Location = new System.Drawing.Point(6, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotate";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(6, 45);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(120, 23);
            this.buttonRotate.TabIndex = 2;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAngle.TabIndex = 1;
            // 
            // buttonFlipLeft
            // 
            this.buttonFlipLeft.Location = new System.Drawing.Point(15, 161);
            this.buttonFlipLeft.Name = "buttonFlipLeft";
            this.buttonFlipLeft.Size = new System.Drawing.Size(119, 23);
            this.buttonFlipLeft.TabIndex = 0;
            this.buttonFlipLeft.Text = "Flip Left";
            this.buttonFlipLeft.UseVisualStyleBackColor = true;
            this.buttonFlipLeft.Click += new System.EventHandler(this.buttonFlipLeft_Click);
            // 
            // buttonFlipRight
            // 
            this.buttonFlipRight.Location = new System.Drawing.Point(15, 132);
            this.buttonFlipRight.Name = "buttonFlipRight";
            this.buttonFlipRight.Size = new System.Drawing.Size(119, 23);
            this.buttonFlipRight.TabIndex = 0;
            this.buttonFlipRight.Text = "Flip Right";
            this.buttonFlipRight.UseVisualStyleBackColor = true;
            this.buttonFlipRight.Click += new System.EventHandler(this.buttonFlipRight_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Location = new System.Drawing.Point(15, 103);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(119, 23);
            this.buttonZoomOut.TabIndex = 0;
            this.buttonZoomOut.Text = "-";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Location = new System.Drawing.Point(15, 74);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(119, 23);
            this.buttonZoomIn.TabIndex = 0;
            this.buttonZoomIn.Text = "+";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(15, 16);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(119, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCrop
            // 
            this.buttonCrop.Location = new System.Drawing.Point(15, 45);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(119, 23);
            this.buttonCrop.TabIndex = 0;
            this.buttonCrop.Text = "Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.69027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.30974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxLayerOpertations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxImageOperations, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxImage, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 424);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxLayerOpertations
            // 
            this.groupBoxLayerOpertations.Controls.Add(this.buttonLayerDelete);
            this.groupBoxLayerOpertations.Controls.Add(this.buttonLayerDown);
            this.groupBoxLayerOpertations.Controls.Add(this.listBoxLayers);
            this.groupBoxLayerOpertations.Controls.Add(this.buttonLayerUp);
            this.groupBoxLayerOpertations.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLayerOpertations.Name = "groupBoxLayerOpertations";
            this.groupBoxLayerOpertations.Size = new System.Drawing.Size(190, 411);
            this.groupBoxLayerOpertations.TabIndex = 2;
            this.groupBoxLayerOpertations.TabStop = false;
            this.groupBoxLayerOpertations.Text = "Layers";
            // 
            // buttonLayerDelete
            // 
            this.buttonLayerDelete.Location = new System.Drawing.Point(125, 12);
            this.buttonLayerDelete.Name = "buttonLayerDelete";
            this.buttonLayerDelete.Size = new System.Drawing.Size(53, 23);
            this.buttonLayerDelete.TabIndex = 0;
            this.buttonLayerDelete.Text = "Delete";
            this.buttonLayerDelete.UseVisualStyleBackColor = true;
            this.buttonLayerDelete.Click += new System.EventHandler(this.buttonLayerDelete_Click);
            // 
            // buttonLayerDown
            // 
            this.buttonLayerDown.Location = new System.Drawing.Point(66, 12);
            this.buttonLayerDown.Name = "buttonLayerDown";
            this.buttonLayerDown.Size = new System.Drawing.Size(53, 23);
            this.buttonLayerDown.TabIndex = 0;
            this.buttonLayerDown.Text = "Down";
            this.buttonLayerDown.UseVisualStyleBackColor = true;
            this.buttonLayerDown.Click += new System.EventHandler(this.buttonLayerDown_Click);
            // 
            // listBoxLayers
            // 
            this.listBoxLayers.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBoxLayers.FormattingEnabled = true;
            this.listBoxLayers.Location = new System.Drawing.Point(7, 41);
            this.listBoxLayers.Name = "listBoxLayers";
            this.listBoxLayers.Size = new System.Drawing.Size(171, 368);
            this.listBoxLayers.TabIndex = 2;
            // 
            // buttonLayerUp
            // 
            this.buttonLayerUp.Location = new System.Drawing.Point(7, 12);
            this.buttonLayerUp.Name = "buttonLayerUp";
            this.buttonLayerUp.Size = new System.Drawing.Size(53, 23);
            this.buttonLayerUp.TabIndex = 0;
            this.buttonLayerUp.Text = "Up";
            this.buttonLayerUp.UseVisualStyleBackColor = true;
            this.buttonLayerUp.Click += new System.EventHandler(this.buttonLayerUp_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Location = new System.Drawing.Point(232, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(426, 418);
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseDown);
            this.pictureBoxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseUp);
            // 
            // openFileDialogLoadImage
            // 
            this.openFileDialogLoadImage.FileName = "openFileDialog";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelSecondCorner);
            this.groupBox2.Controls.Add(this.labelFirstCorner);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 94);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corner :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Corner :";
            // 
            // labelFirstCorner
            // 
            this.labelFirstCorner.AutoSize = true;
            this.labelFirstCorner.Location = new System.Drawing.Point(7, 33);
            this.labelFirstCorner.Name = "labelFirstCorner";
            this.labelFirstCorner.Size = new System.Drawing.Size(13, 13);
            this.labelFirstCorner.TabIndex = 0;
            this.labelFirstCorner.Text = "0";
            // 
            // labelSecondCorner
            // 
            this.labelSecondCorner.AutoSize = true;
            this.labelSecondCorner.Location = new System.Drawing.Point(7, 71);
            this.labelSecondCorner.Name = "labelSecondCorner";
            this.labelSecondCorner.Size = new System.Drawing.Size(13, 13);
            this.labelSecondCorner.TabIndex = 0;
            this.labelSecondCorner.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "MultiMedia";
            this.groupBoxImageOperations.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxLayerOpertations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImageOperations;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.GroupBox groupBoxLayerOpertations;
        private System.Windows.Forms.Button buttonLayerDelete;
        private System.Windows.Forms.Button buttonLayerDown;
        private System.Windows.Forms.Button buttonLayerUp;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadImage;
        private System.Windows.Forms.ListBox listBoxLayers;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveImage;
        private System.Windows.Forms.Button buttonFlipLeft;
        private System.Windows.Forms.Button buttonFlipRight;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSecondCorner;
        private System.Windows.Forms.Label labelFirstCorner;
        private System.Windows.Forms.Label label1;
    }
}

