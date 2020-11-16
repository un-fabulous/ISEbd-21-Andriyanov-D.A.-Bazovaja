using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samosvalllll
{
    public partial class FormCarConfig : Form
    {
        Gruzovik car = null;

        public event Action<Gruzovik> addCar;
        public FormCarConfig()
        {
            InitializeComponent();
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawTransport()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(5,40, pictureBoxCar.Width, pictureBoxCar.Height);
                car.DrawTransport(gr);
                pictureBoxCar.Image = bmp;
            }
        }
   
    

      

        private void labelGruzovik_MouseDown(object sender, MouseEventArgs e)
        {
            labelGruzovik.DoDragDrop(labelGruzovik.Text, DragDropEffects.Move |
         DragDropEffects.Copy);
        }
        private void labelSamosval_MouseDown(object sender, MouseEventArgs e)
        {
            labelSamosval.DoDragDrop(labelSamosval.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Грузовик":
                    car = new Car((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Самосвал":
                    car = new Samosval((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxSupport.Checked, checkBoxCarcass.Checked);
                    break;
            }
            DrawTransport();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text.ToString()))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.SetMainColor(Color.FromName(e.Data.GetData(DataFormats.Text).ToString()));
                DrawTransport();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car is Samosval && car != null)
            {
                (car as Samosval).SetDopColor(Color.FromName(e.Data.GetData(DataFormats.Text).ToString()));
                DrawTransport();
            }
        }
        private void buttonCr_Click(object sender, EventArgs e)
        {
            addCar?.Invoke(car);
            Close();
        }
    }
}
