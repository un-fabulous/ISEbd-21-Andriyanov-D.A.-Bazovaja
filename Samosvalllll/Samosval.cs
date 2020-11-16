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


    /*
        public Samosval(int maxSpeed, float weight, Color mainColor, Color dopColor, bool support, bool carcass)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Support = support;
            Carcass = carcass;
        }


        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }


        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {

                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - samosvalWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY + step > samosvalHeight / 2)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - samosvalHeight +40)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }


        public void DrawTransport(Graphics g)
        {

            Brush samos = new SolidBrush(MainColor);

            PointF p1 = new PointF(_startPosX, _startPosY);
            PointF p2 = new PointF(_startPosX, _startPosY + 20);
            PointF p3 = new PointF(_startPosX + 85, _startPosY + 20);
            PointF p4 = new PointF(_startPosX +85 , _startPosY);


            PointF[] samosP = { p1, p2, p3, p4 };
            g.FillPolygon(samos, samosP);

            Brush head = new SolidBrush(MainColor);

            PointF s1 = new PointF(_startPosX + 95, _startPosY -20);
            PointF s2 = new PointF(_startPosX + 130, _startPosY -20);
            PointF s3 = new PointF(_startPosX + 130, _startPosY + 20);
            PointF s4 = new PointF(_startPosX + 95, _startPosY + 20);
    


            PointF[] headP = { s1, s2, s3, s4 };
            g.FillPolygon(head, headP);

            Brush circ = new SolidBrush(MainColor);
            g.FillEllipse(circ, _startPosX+2, _startPosY+15, 25,25);
            g.FillEllipse(circ, _startPosX + 30, _startPosY + 15, 25, 25);
            g.FillEllipse(circ, _startPosX + 100, _startPosY + 15, 25, 25);

          
            if (Support)
            {
                Brush support = new SolidBrush(DopColor);

                PointF w1 = new PointF(_startPosX + 65, _startPosY - 30 );
                PointF w2 = new PointF(_startPosX + 70, _startPosY + 20);
                PointF w3 = new PointF(_startPosX + 103, _startPosY + 20);
        

                PointF[] supportP = { w1, w2, w3};
                g.FillPolygon(support, supportP);
            }

            if (Carcass)
            {
                Brush carcass = new SolidBrush(DopColor);

                PointF f1 = new PointF(_startPosX+70, _startPosY);
                PointF f2 = new PointF(_startPosX, _startPosY + 20);
                PointF f3 = new PointF(_startPosX-10, _startPosY - 10);
                PointF f4 = new PointF(_startPosX + 65, _startPosY -30);


                PointF[] carcassP = { f1, f2, f3, f4};
                g.FillPolygon(carcass, carcassP);
            }
        }
    }
}
*/


 