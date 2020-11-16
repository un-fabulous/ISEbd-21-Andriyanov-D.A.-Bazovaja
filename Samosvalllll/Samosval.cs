using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
    public class Samosval : Car
    {
        public Color DopColor { private set; get; }
        public bool Support { private set; get; }
        public bool Carcass { private set; get; }

        public Samosval(int maxSpeed, float weight, Color mainColor, Color dopColor, bool support, bool carcass) :
        base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Support = support;
            Carcass = carcass;
        }
        public override void DrawTransport(Graphics g)
        {
           
            if (Support)
            {
                Brush support = new SolidBrush(DopColor);

                PointF w1 = new PointF(_startPosX + 65, _startPosY - 30);
                PointF w2 = new PointF(_startPosX + 70, _startPosY + 20);
                PointF w3 = new PointF(_startPosX + 103, _startPosY + 20);


                PointF[] supportP = { w1, w2, w3 };
                g.FillPolygon(support, supportP);
            }

            if (Carcass)
            {
                Brush carcass = new SolidBrush(DopColor);

                PointF f1 = new PointF(_startPosX + 70, _startPosY);
                PointF f2 = new PointF(_startPosX, _startPosY + 20);
                PointF f3 = new PointF(_startPosX - 10, _startPosY - 10);
                PointF f4 = new PointF(_startPosX + 65, _startPosY - 30);


                PointF[] carcassP = { f1, f2, f3, f4 };
                g.FillPolygon(carcass, carcassP);
            }
            base.DrawTransport(g);
            Pen line = new Pen(MainColor, 45);
            g.DrawLine(Pens.Black, _startPosX, _startPosY + 20, _startPosX + 128, _startPosY + 20);
        }
    }




}





 