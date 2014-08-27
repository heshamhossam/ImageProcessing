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
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLayerOpertations = new System.Windows.Forms.GroupBox();
            this.buttonLayerDelete = new System.Windows.Forms.Button();
            this.buttonLayerDown = new System.Windows.Forms.Button();
            this.buttonLayerUp = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.openFileDialogLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.listBoxLayers = new System.Windows.Forms.ListBox();
            this.groupBoxImageOperations.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxLayerOpertations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxImageOperations
            // 
            this.groupBoxImageOperations.Controls.Add(this.buttonUndo);
            this.groupBoxImageOperations.Controls.Add(this.buttonZoomOut);
            this.groupBoxImageOperations.Controls.Add(this.buttonZoomIn);
            this.groupBoxImageOperations.Controls.Add(this.buttonLoad);
            this.groupBoxImageOperations.Controls.Add(this.buttonCrop);
            this.groupBoxImageOperations.Location = new System.Drawing.Point(567, 3);
            this.groupBoxImageOperations.Name = "groupBoxImageOperations";
            this.groupBoxImageOperations.Size = new System.Drawing.Size(79, 411);
            this.groupBoxImageOperations.TabIndex = 0;
            this.groupBoxImageOperations.TabStop = false;
            this.groupBoxImageOperations.Text = "Operations";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(6, 135);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(62, 23);
            this.buttonUndo.TabIndex = 0;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Location = new System.Drawing.Point(6, 106);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(62, 23);
            this.buttonZoomOut.TabIndex = 0;
            this.buttonZoomOut.Text = "-";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Location = new System.Drawing.Point(6, 77);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(62, 23);
            this.buttonZoomIn.TabIndex = 0;
            this.buttonZoomIn.Text = "+";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(6, 19);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(62, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCrop
            // 
            this.buttonCrop.Location = new System.Drawing.Point(6, 48);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(62, 23);
            this.buttonCrop.TabIndex = 0;
            this.buttonCrop.Text = "Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.69027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.30974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxLayerOpertations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxImageOperations, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxImage, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 417);
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
            // 
            // buttonLayerDown
            // 
            this.buttonLayerDown.Location = new System.Drawing.Point(66, 12);
            this.buttonLayerDown.Name = "buttonLayerDown";
            this.buttonLayerDown.Size = new System.Drawing.Size(53, 23);
            this.buttonLayerDown.TabIndex = 0;
            this.buttonLayerDown.Text = "Down";
            this.buttonLayerDown.UseVisualStyleBackColor = true;
            // 
            // buttonLayerUp
            // 
            this.buttonLayerUp.Location = new System.Drawing.Point(7, 12);
            this.buttonLayerUp.Name = "buttonLayerUp";
            this.buttonLayerUp.Size = new System.Drawing.Size(53, 23);
            this.buttonLayerUp.TabIndex = 0;
            this.buttonLayerUp.Text = "Up";
            this.buttonLayerUp.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Location = new System.Drawing.Point(199, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(362, 411);
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            // 
            // openFileDialogLoadImage
            // 
            this.openFileDialogLoadImage.FileName = "openFileDialog";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "MultiMedia";
            this.groupBoxImageOperations.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxLayerOpertations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImageOperations;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.GroupBox groupBoxLayerOpertations;
        private System.Windows.Forms.Button buttonLayerDelete;
        private System.Windows.Forms.Button buttonLayerDown;
        private System.Windows.Forms.Button buttonLayerUp;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadImage;
        private System.Windows.Forms.ListBox listBoxLayers;
    }
}

