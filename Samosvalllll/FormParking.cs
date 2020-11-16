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
    public partial class FormParking : Form
    {
        private readonly Parking<Car> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Car>(pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Car(100, 1000, dialog.Color);

                if (parking + car)
                {

                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        private void buttonSetSamosval_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Samosval(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + car)
                    {
                        Draw();
                        
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    FormCar form = new FormCar();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }


    }
}
