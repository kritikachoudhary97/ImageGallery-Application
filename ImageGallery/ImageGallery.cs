using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using C1.Win.C1Tile;
using C1.C1Pdf;

namespace ImageGallery
{
    public partial class ImageGallery : Form
    {
        DataFetcher datafetch = new DataFetcher();
        List<ImageItem> imagesList;
        int checkedItems = 0;
        C1PdfDocument imagePdfDocument = new C1PdfDocument();

        public ImageGallery()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Rectangle r = _searchBox.Bounds;
                r.Inflate(3, 3);
                Pen p = new Pen(Color.LightGray);
                e.Graphics.DrawRectangle(p, r);
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);

            }
        }

        private async void _search_Click(object sender, EventArgs e)
        {
            //This fetch the images.
            try
            {
                if (_searchBox.Text == "")
                {
                    MessageBox.Show("Please enter the string.");
                    statusStrip1.Visible = false;
                }

                else
                {
                    statusStrip1.Visible = true;
                    imagesList = await datafetch.GetImageData(_searchBox.Text);
                    AddTiles(imagesList);
                    statusStrip1.Visible = false;
                    _imageTileControl.Visible = true;
                }
            }
            catch(Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);

            }

        }

        private void AddTiles(List<ImageItem> imageList)
        {
            //This adds the images to the tile control.
            try
            {
                _imageTileControl.Groups[0].Tiles.Clear();
                foreach (var imageitem in imageList)
                {
                    Tile tile = new Tile();
                    tile.HorizontalSize = 2;
                    tile.VerticalSize = 2;
                    _imageTileControl.Groups[0].Tiles.Add(tile);
                    Image img = Image.FromStream(new MemoryStream(imageitem.Base64));
                    Template tl = new Template();
                    ImageElement ie = new ImageElement();
                    ie.ImageLayout = ForeImageLayout.Stretch;
                    tl.Elements.Add(ie);
                    tile.Template = tl;
                    tile.Image = img;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);

            }
        }

        private void _exportimage_Click(object sender, EventArgs e)
        {   //This executes when user clicks on export pdf icon(picture box).
            try
            {
                List<Image> images = new List<Image>();
                foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
                {
                    if (tile.Checked)
                    {
                        images.Add(tile.Image);
                    }
                }
                ConvertToPdf(images);
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "pdf";
                saveFile.Filter = "PDF files (*.pdf)|*.pdf*";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    imagePdfDocument.Save(saveFile.FileName);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);

            }

        }
        private void ConvertToPdf(List<Image> images)
        {
            //Coversion to pdf.
            try
            {
                RectangleF rect = imagePdfDocument.PageRectangle;
                bool firstPage = true;
                foreach (var selectedimg in images)
                {
                    if (!firstPage)
                    {
                        imagePdfDocument.NewPage();
                    }
                    firstPage = false;
                    rect.Inflate(-72, -72);
                    imagePdfDocument.DrawImage(selectedimg, rect);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);

            }
        }

        private void _exportimage_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Rectangle r = new Rectangle(_exportimage.Location.X, _exportimage.Location.Y, _exportimage.Width, _exportimage.Height);
                r.X -= 29;
                r.Y -= 3;
                r.Width--;
                r.Height--;
                Pen p = new Pen(Color.LightGray);
                e.Graphics.DrawRectangle(p, r);
                e.Graphics.DrawLine(p, new Point(0, 43), new Point(this.Width, 43));
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);

            }

        }

        private void _imageTileControl_TileChecked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            //This occurs whenever image/images are checked by the user.
            checkedItems++;
            _exportimage.Visible = true;
            pdf_lbl.Visible = true;
            save_lbl.Visible = true;
            _saveimage.Visible = true;
            icon_lbl.Visible = true;
        }

        private void _imageTileControl_TileUnchecked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            //This occurs whenever image/images are unchecked by the user.
            checkedItems--;
            _exportimage.Visible = checkedItems > 0;
            pdf_lbl.Visible = checkedItems > 0;
            save_lbl.Visible = checkedItems > 0;
            _saveimage.Visible = checkedItems > 0;
            icon_lbl.Visible = checkedItems > 0;
        }

        private void _imageTileControl_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);

        }

        private void _saveimage_Click(object sender, EventArgs e)
        {
            //This saves the selected image/images into the Local File System.
            try { 
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "jpg";
            saveFile.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            List<Image> images = new List<Image>();
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if (tile.Checked)
                {
                    images.Add(tile.Image);
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        tile.Image.Save(saveFile.FileName);

                    }
                }
            }
            }

            catch (Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);
            }
        }

        private void _searchBox_TextChanged(object sender, EventArgs e)
        {
            //Checks search textbox is empty,it gives a message box to enter a string.
            if (_searchBox.Text=="")
            {
                MessageBox.Show("Please enter the string.");
            }
        }

    }
}
