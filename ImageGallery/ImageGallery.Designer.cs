namespace ImageGallery
{
    partial class ImageGallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGallery));
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this.icon_lbl = new System.Windows.Forms.Label();
            this.save_lbl = new System.Windows.Forms.Label();
            this._saveimage = new System.Windows.Forms.PictureBox();
            this.pdf_lbl = new System.Windows.Forms.Label();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this._exportimage = new System.Windows.Forms.PictureBox();
            this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._saveimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._exportimage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.icon_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.save_lbl);
            this.splitContainer1.Panel2.Controls.Add(this._saveimage);
            this.splitContainer1.Panel2.Controls.Add(this.pdf_lbl);
            this.splitContainer1.Panel2.Controls.Add(this._imageTileControl);
            this.splitContainer1.Panel2.Controls.Add(this._exportimage);
            this.splitContainer1.Size = new System.Drawing.Size(762, 753);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(193, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // _searchBox
            // 
            this._searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._searchBox.Location = new System.Drawing.Point(15, 9);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(244, 15);
            this._searchBox.TabIndex = 0;
            this._searchBox.TextChanged += new System.EventHandler(this._searchBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._search);
            this.panel2.Location = new System.Drawing.Point(477, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 12, 45, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 16);
            this.panel2.TabIndex = 1;
            // 
            // _search
            // 
            this._search.Dock = System.Windows.Forms.DockStyle.Left;
            this._search.Image = ((System.Drawing.Image)(resources.GetObject("_search.Image")));
            this._search.Location = new System.Drawing.Point(0, 0);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(40, 16);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 0;
            this._search.TabStop = false;
            this._search.Click += new System.EventHandler(this._search_Click);
            // 
            // icon_lbl
            // 
            this.icon_lbl.AutoSize = true;
            this.icon_lbl.Location = new System.Drawing.Point(570, 13);
            this.icon_lbl.Name = "icon_lbl";
            this.icon_lbl.Size = new System.Drawing.Size(193, 17);
            this.icon_lbl.TabIndex = 6;
            this.icon_lbl.Text = "Please click on icon to select.";
            this.icon_lbl.Visible = false;
            // 
            // save_lbl
            // 
            this.save_lbl.AutoSize = true;
            this.save_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_lbl.Location = new System.Drawing.Point(213, 13);
            this.save_lbl.Name = "save_lbl";
            this.save_lbl.Size = new System.Drawing.Size(275, 17);
            this.save_lbl.TabIndex = 5;
            this.save_lbl.Text = "SAVE AS IMAGE TO LOCAL SYSTEM";
            this.save_lbl.Visible = false;
            // 
            // _saveimage
            // 
            this._saveimage.Image = ((System.Drawing.Image)(resources.GetObject("_saveimage.Image")));
            this._saveimage.Location = new System.Drawing.Point(506, 2);
            this._saveimage.Name = "_saveimage";
            this._saveimage.Size = new System.Drawing.Size(46, 43);
            this._saveimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._saveimage.TabIndex = 3;
            this._saveimage.TabStop = false;
            this._saveimage.Visible = false;
            this._saveimage.Click += new System.EventHandler(this._saveimage_Click);
            // 
            // pdf_lbl
            // 
            this.pdf_lbl.AutoSize = true;
            this.pdf_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf_lbl.Location = new System.Drawing.Point(4, 13);
            this.pdf_lbl.Name = "pdf_lbl";
            this.pdf_lbl.Size = new System.Drawing.Size(133, 17);
            this.pdf_lbl.TabIndex = 2;
            this.pdf_lbl.Text = "EXPORT TO PDF";
            this.pdf_lbl.Visible = false;
            // 
            // _imageTileControl
            // 
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            this._imageTileControl.CellWidth = 78;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.Location = new System.Drawing.Point(3, 52);
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Size = new System.Drawing.Size(759, 657);
            this._imageTileControl.SurfacePadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 20;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TabIndex = 1;
            this._imageTileControl.Visible = false;
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileUnchecked);
            this._imageTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this._imageTileControl_Paint);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
            // 
            // _exportimage
            // 
            this._exportimage.Image = ((System.Drawing.Image)(resources.GetObject("_exportimage.Image")));
            this._exportimage.Location = new System.Drawing.Point(133, 3);
            this._exportimage.Name = "_exportimage";
            this._exportimage.Size = new System.Drawing.Size(64, 43);
            this._exportimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._exportimage.TabIndex = 0;
            this._exportimage.TabStop = false;
            this._exportimage.Visible = false;
            this._exportimage.Click += new System.EventHandler(this._exportimage_Click);
            this._exportimage.Paint += new System.Windows.Forms.PaintEventHandler(this._exportimage_Paint);
            // 
            // c1PdfDocument1
            // 
            this.c1PdfDocument1.DocumentInfo.Author = "";
            this.c1PdfDocument1.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.c1PdfDocument1.DocumentInfo.Creator = "";
            this.c1PdfDocument1.DocumentInfo.Keywords = "";
            this.c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.c1PdfDocument1.DocumentInfo.Subject = "";
            this.c1PdfDocument1.DocumentInfo.Title = "";
            this.c1PdfDocument1.MaxHeaderBookmarkLevel = 0;
            this.c1PdfDocument1.PdfVersion = "1.3";
            this.c1PdfDocument1.RefDC = null;
            this.c1PdfDocument1.RotateAngle = 0F;
            this.c1PdfDocument1.UseFastTextOut = true;
            this.c1PdfDocument1.UseFontShaping = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 729);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(762, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // ImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(762, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.Name = "ImageGallery";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._saveimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._exportimage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _searchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox _search;
        private System.Windows.Forms.PictureBox _exportimage;
        private C1.Win.C1Tile.C1TileControl _imageTileControl;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private C1.Win.C1Tile.Tile tile2;
        private C1.Win.C1Tile.Tile tile3;
        private C1.C1Pdf.C1PdfDocument c1PdfDocument1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label pdf_lbl;
        private System.Windows.Forms.Label save_lbl;
        private System.Windows.Forms.PictureBox _saveimage;
        private System.Windows.Forms.Label icon_lbl;
    }
}

