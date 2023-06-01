using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public class PageInInfoForm
    {
        public Label labelH1;
        public Label labelP;
        //public PictureBox pictureBox;

        public PageInInfoForm()
        {

            this.labelH1 = null;
            this.labelP = null;
            //pictureBox = null;


        }
        public PageInInfoForm(string labelH1str, string labelPstr)//, PictureBox pictureBoxLite)
        {
            this.labelH1 = new Label();
            this.labelP = new Label();

            this.labelH1.Text = labelH1str;
            this.labelP.Text = labelPstr;

            //pictureBox = new PictureBox();
            //pictureBox.Image = pictureBoxLite.Image;

        }
        public PageInInfoForm(string labelPstr)//, PictureBox pictureBoxLite)
        {

            this.labelP = new Label();

            this.labelH1.Text = null;
            this.labelP.Text = labelPstr;
            //pictureBox = new PictureBox();
            //pictureBox.Image = pictureBoxLite.Image;
            

        }
        //public PageInInfoForm(string labelH1str, string labelPstr)
        //{

        //    labelH1.Text = labelH1str;
        //    labelP.Text = labelPstr;
        //    //pictureBox = null;



        //}
        //public PageInInfoForm(string labelPstr)
        //{

        //    labelH1.Text = null;
        //    labelP.Text = labelPstr;
        //    //pictureBox = null;

        //}
        
        
    }
}
