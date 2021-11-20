using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whereiscat
{
    public partial class GameUI : UserControl
    {
        public GameUI()
        {
            InitializeComponent();
            RandomImage();
        }

        private List<PictureBox> pcb = new List<PictureBox>();
        private void RandomImage()
        {
            var rdm = new Random();
            var ranValue = rdm.Next(0, 2);


            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox npb = (PictureBox)item;
                    npb.MouseHover += Npb_MouseHover;
                    npb.Click += Npb_Click;
                    pcb.Add(npb);

                    void Npb_MouseHover(object sender, EventArgs e)
                    {
                        npb.Cursor = Cursors.Hand;
                    }


                    void Npb_Click(object sender, EventArgs e)
                    {

                       

                        if(npb.Image == null)
                        {
                            MessageBox.Show("You failed");
                        }

                       
                    }
                }
            }
            //put random image;
            pcb[ranValue].Image = Image.FromFile(AppContext.BaseDirectory + "Images/download.jfif");

            //clear out all items
            pcb.Clear();



        }

    }
}
