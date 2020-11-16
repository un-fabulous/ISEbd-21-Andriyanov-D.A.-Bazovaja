﻿using System;
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
    public partial class FormCar : Form
    {
        private ITransport car;
        public FormCar()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawTransport(gr);
            pictureBoxSamosval.Image = bmp;

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Samosval(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true, true);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                   car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                   car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Samosval(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true, true);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Draw();
        }

        private void buttonCreate2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Car(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Draw();
        }
    }
}
