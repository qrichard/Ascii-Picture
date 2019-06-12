using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asciify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BitmapAscii load = new BitmapAscii();
        Bitmap tempBitmap;

        int kernalHeightInt = 1;
        int kernalWidthInt = 1;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            load.load_OG_Bitmap(openFileDialog1.FileName );
            ogPicture.Image = load.ogBitmap ;
             tempBitmap = new Bitmap (openFileDialog1.FileName);
        }

        private void greyScaleBtn_Click(object sender, EventArgs e)
        {
        load.load_OG_Grey(openFileDialog1.FileName);
            grayPicture.Image = load.greyBitmap;
        }



        private void kernalWidth_ValueChanged(object sender, EventArgs e)
        {
            kernalWidthInt = int.Parse(kernalWidth.Value.ToString());
        }

        private void kernalHeight_ValueChanged(object sender, EventArgs e)
        {
            kernalHeightInt = int.Parse(kernalHeight.Value.ToString());
                
        }

        private void asciiPic_Click(object sender, EventArgs e)
        {
            asciiPicTextBox.Text = load.Ascitize(tempBitmap, kernalWidthInt, kernalHeightInt);
        }
    }
}
