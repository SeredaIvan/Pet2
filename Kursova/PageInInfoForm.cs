using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class PageInInfoForm
    {
        Label labelH1;
        Label labelP;
        PictureBox pictureBox;
        public PageInInfoForm()
        {
            labelH1 = null;
            labelP = null;
            pictureBox = null;
        }
        public PageInInfoForm(string labelH1str,string labelstr, byte[]img)
        {
            Label labelH1 = new Label();
            Label labelP = new Label();
            PictureBox pictureBox = new PictureBox();

            labelH1.Text = labelH1str;
            labelP.Text = labelstr;
            using (var stream = new System.IO.MemoryStream(img))
            {
                pictureBox.Image = System.Drawing.Image.FromStream(stream);
            }

            labelH1.Font = new Font(labelH1.Font.FontFamily, 30, FontStyle.Bold);
            labelP.Font = new Font(labelP.Font.FontFamily, 14);

        }

    }
}
