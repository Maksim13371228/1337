using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicObjectApp
{
    public partial class Form1 : Form
    {
        int v = 1;
        int v1 = 1;
        int v2;
        const int default_a=80;
        int a;
        int dir = 1;
        int dx;    
        double xc, yc;
        double b;
        Point[] p1=new Point[8];
        Point[] p2 = new Point[4];
        Point[] p3 = new Point[4];
        double[] x = new double[12];
        double[] y = new double[12];
        
        double c_fi=0;
        double fi; //угол поворота при вращении фигуры 
        int rotation_rotate = 1;
        const string message = "Введите числовое значение";
        const string caption = "Ошибка";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ris();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   pictureBox1.

            a = default_a; 
          //  this.ris();

          //  textBox1.Text = a.ToString();
          //  a.ToString() = textBox1.Text;
            trackBar3.Value = a;
           // ris();
         //   dx = v * dir;
           // a = 80;
          //  a = v2;
         //   b = ((a * Math.Sqrt(2)) / 2.0);
            xc = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
            yc = pictureBox1.Height / 2 + ((pictureBox1.Height - ((a * Math.Sqrt(2)) / 2.0) * 2) / 2) ;
            fi = 3 * dir * Math.PI / (180);
            ris();
           
            /*  {
                  
                   * 
                   * 
                   *  private int x8()
                          {
                              return Convert.ToInt32(xc - (a / 2.0) * Math.Cos(Math.PI / 4));
                          }
                          private int y8()
                          {
                              return Convert.ToInt32(yc - (a / 2.0) * Math.Sin(Math.PI / 4));
                          }
                          private int x9()
                          {
                              return Convert.ToInt32(xc);
                          }
                          private int y9()
                          {
                              return Convert.ToInt32(yc - b);
                          }
                          private int x10()
                          {
                              return Convert.ToInt32(xc + b);
                          }
                          private int y10()
                          {
                              return Convert.ToInt32(yc);
                          }
                          private int x11()
                          {
                              return Convert.ToInt32(xc);
                          }
                          private int y11()
                          {
                              return Convert.ToInt32(yc + b);
                          }
                          private int x12()
                          {
                              return Convert.ToInt32(xc - b);
                          }
                          private int y12()
                          {
                              return Convert.ToInt32(yc);
                          }
                   * 
                   * 
                   * 
                   * 
                   * 
                   * 
                   * 
                  private int x1()
                          {
                              return Convert.ToInt32(xc);
                          }
                          private int y1()
                          {
                              return Convert.ToInt32(yc - a / 2.0);
                          }
                          private int x2()
                          {
                              return Convert.ToInt32(xc + (a / 2.0) * Math.Cos(Math.PI / 4));
                          }

                          private int y2()
                          {
                              return Convert.ToInt32(yc - (a / 2.0) * Math.Sin(Math.PI / 4));
                          }
                          private int x3()
                          {
                              return Convert.ToInt32(xc + a / 2.0);
                          }
                          private int y3()
                          {
                              return Convert.ToInt32(yc);
                          }
                          private int x4()
                          {
                              return Convert.ToInt32(xc + (a / 2.0) * Math.Cos(Math.PI / 4));
                          }
                          private int y4()
                          {
                              return Convert.ToInt32(yc + (a / 2.0) * Math.Sin(Math.PI / 4));
                          }
                          private int x5()
                          {
                              return Convert.ToInt32(xc);
                          }
                          private int y5()
                          {
                              return Convert.ToInt32(yc + a / 2.0);
                          }
                          private int x6()
                          {
                              return Convert.ToInt32(xc - (a / 2.0) * Math.Cos(Math.PI / 4));
                          }
                          private int y6()
                          {
                              return Convert.ToInt32(yc + (a / 2.0) * Math.Sin(Math.PI / 4));
                          }
                          private int x7()
                          {
                              return Convert.ToInt32(xc - a / 2.0);
                          }
                          private int y7()
                          {
                              return Convert.ToInt32(yc);
                          }
                          private int x8()
                          {
                              return Convert.ToInt32(xc - (a / 2.0) * Math.Cos(Math.PI / 4));
                          }
                          private int y8()
                          {
                              return Convert.ToInt32(yc - (a / 2.0) * Math.Sin(Math.PI / 4));
                          }
                          private int x9()
                          {
                              return Convert.ToInt32(xc);
                          }
                          private int y9()
                          {
                              return Convert.ToInt32(yc - b);
                          }
                          private int x10()
                          {
                              return Convert.ToInt32(xc + b);
                          }
                          private int y10()
                          {
                              return Convert.ToInt32(yc);
                          }
                          private int x11()
                          {
                              return Convert.ToInt32(xc);
                          }
                          private int y11()
                          {
                              return Convert.ToInt32(yc + b);
                          }
                          private int x12()
                          {
                              return Convert.ToInt32(xc - b);
                          }
                          private int y12()
                          {
                              return Convert.ToInt32(yc);
                          }
                
              }*/

        }
        //расчет координат x точек фигуры при вращении         
        private double[] x_rot(double[] x0, double[] y0) 
        {             
            double[] x1 = new double[x.Length];             
            for (int i = 0; i < x.Length; i++) 
            {                 
                x1[i] = (x0[i]) * Math.Cos(c_fi) - (y0[i]) * Math.Sin(c_fi);
            }            
            return x1;
        }        
        //расчет координат y точек фигуры при вращении         
        private double[] y_rot(double[] x0, double[] y0)        
        {             
            double[] y1 = new double[x.Length];             
            for (int i = 0; i < x.Length; i++)             
            {                 
                y1[i] = (y0[i]) * Math.Cos(c_fi) + (x0[i]) * Math.Sin(c_fi);
            }            
            return y1;
        } 
     /*   private int x1()
        {
            return Convert.ToInt32(xc);
        }
        private int y1()
        {
            return Convert.ToInt32(yc - a / 2.0);
        }
        private int x2()
        {
            return Convert.ToInt32(xc + (a / 2.0) * Math.Cos(Math.PI / 4));
        }

        private int y2()
        {
            return Convert.ToInt32(yc - (a / 2.0) * Math.Sin(Math.PI / 4));
        }
        private int x3()
        {
            return Convert.ToInt32(xc + a / 2.0);
        }
        private int y3()
        {
            return Convert.ToInt32(yc);
        }
        private int x4()
        {
            return Convert.ToInt32(xc + (a / 2.0) * Math.Cos(Math.PI / 4));
        }
        private int y4()
        {
            return Convert.ToInt32(yc + (a / 2.0) * Math.Sin(Math.PI / 4));
        }
        private int x5()
        {
            return Convert.ToInt32(xc);
        }
        private int y5()
        {
            return Convert.ToInt32(yc + a / 2.0);
        }
        private int x6()
        {
            return Convert.ToInt32(xc - (a / 2.0) * Math.Cos(Math.PI / 4));
        }
        private int y6()
        {
            return Convert.ToInt32(yc + (a / 2.0) * Math.Sin(Math.PI / 4));
        }
        private int x7()
        {
            return Convert.ToInt32(xc - a / 2.0);
        }
        private int y7()
        {
            return Convert.ToInt32(yc);
        }
        private int x8()
        {
            return Convert.ToInt32(xc - (a / 2.0) * Math.Cos(Math.PI / 4));
        }
        private int y8()
        {
            return Convert.ToInt32(yc - (a / 2.0) * Math.Sin(Math.PI / 4));
        }
        private int x9()
        {
            return Convert.ToInt32(xc);
        }
        private int y9()
        {
            return Convert.ToInt32(yc - b);
        }
        private int x10()
        {
            return Convert.ToInt32(xc + b);
        }
        private int y10()
        {
            return Convert.ToInt32(yc);
        }
        private int x11()
        {
            return Convert.ToInt32(xc);
        }
        private int y11()
        {
            return Convert.ToInt32(yc + b);
        }
        private int x12()
        {
            return Convert.ToInt32(xc - b);
        }
        private int y12()
        {
            return Convert.ToInt32(yc);
        }*/
        private byte colorInc()
        {
            try
            {

                double col =255*(xc - (a / 2) * Math.Cos(Math.PI / 4))
                    / (pictureBox1.Width - a * Math.Cos(Math.PI / 4));
                return Convert.ToByte(col);
            }
            catch { return 0; }
        }
        private byte colorDec()
        {
            try
            {
                double col =-255*  ((xc - (a / 2) *  Math.Cos(Math.PI / 4))
                    / (pictureBox1.Width - a * Math.Cos(Math.PI / 4)))+255;
                return Convert.ToByte(col);
            }
            catch { return 0; }           
        }
        private byte colorInc1()
        {
            try
            {

                double col = 255 * (yc - (a / 2) * Math.Cos(Math.PI / 4))
                    / (pictureBox1.Width - a * Math.Cos(Math.PI / 4));
                return Convert.ToByte(col);
            }
            catch { return 0; }
        }
        private byte colorDec1()
        {
            try
            {
                double col = -255 * ((yc - (a / 2) * Math.Cos(Math.PI / 4))
                    / (pictureBox1.Width - a * Math.Cos(Math.PI / 4))) + 255;
                return Convert.ToByte(col);
            }
            catch { return 0; }
        }
        private void ris()
        {

            /*   pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
               using (Graphics g = Graphics.FromImage(pictureBox1.Image))
               {
                   g.Clear(Color.White);
                   g.DrawLine(new Pen(Color.Black, 4), pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
                   g.DrawLine(new Pen(Color.Black, 4), 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
               }*/



            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                //Graphics g = pictureBox1.CreateGraphics();
                if (radioButton1.Checked)
                {
                    Brush br1 = new SolidBrush(Color.FromArgb(255, colorDec(), 0));
                    Brush br2 = new SolidBrush(Color.FromArgb(0, colorDec(), colorInc()));

                   // Brush br1 = new SolidBrush(Color.FromArgb(255, colorDec(), colorInc()));
                  //  Brush br2 = new SolidBrush(Color.FromArgb(colorInc(), colorDec(), colorInc()));

                    g.Clear(SystemColors.Control);
                    //координаты точек фигуры относительно центра            
                    x[0] = Convert.ToInt32(0);
                    y[0] = Convert.ToInt32(-a / 2.0);
                    x[1] = Convert.ToInt32((a / 2.0) * Math.Cos(Math.PI / 4));
                    y[1] = Convert.ToInt32(-(a / 2.0) * Math.Sin(Math.PI / 4));
                    x[2] = Convert.ToInt32(a / 2.0);
                    y[2] = Convert.ToInt32(0);
                    x[3] = Convert.ToInt32((a / 2.0) * Math.Cos(Math.PI / 4));
                    y[3] = Convert.ToInt32((a / 2.0) * Math.Sin(Math.PI / 4));
                    x[4] = Convert.ToInt32(0);
                    y[4] = Convert.ToInt32(a / 2.0);
                    x[5] = Convert.ToInt32(-(a / 2.0) * Math.Cos(Math.PI / 4));
                    y[5] = Convert.ToInt32((a / 2.0) * Math.Sin(Math.PI / 4));
                    x[6] = Convert.ToInt32(-a / 2.0);//yuy
                    y[6] = Convert.ToInt32(0);
                    x[7] = Convert.ToInt32(-(a / 2.0) * Math.Cos(Math.PI / 4));
                    y[7] = Convert.ToInt32(-(a / 2.0) * Math.Sin(Math.PI / 4));
                    x[8] = Convert.ToInt32(0);
                    y[8] = Convert.ToInt32(-((a * Math.Sqrt(2)) / 2.0));
                    x[9] = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
                    y[9] = Convert.ToInt32(0);
                    x[10] = Convert.ToInt32(0);
                    y[10] = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
                    x[11] = Convert.ToInt32(-((a * Math.Sqrt(2)) / 2.0));
                    y[11] = Convert.ToInt32(0);
                    double[] temp = new double[12];
                    temp = x;//копируем массив x во временную переменную             
                    x = x_rot(temp, y);
                    y = y_rot(temp, y);
                    p3[0] = new Point((int)(x[8] + xc), (int)(y[8] + yc));
                    p3[1] = new Point((int)(x[9] + xc), (int)(y[9] + yc));
                    p3[2] = new Point((int)(x[10] + xc), (int)(y[10] + yc));
                    p3[3] = new Point((int)(x[11] + xc), (int)(y[11] + yc));
                    p1[0] = new Point((int)(x[0] + xc), (int)(y[0] + yc));
                    p1[1] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
                    p1[2] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
                    p1[3] = new Point((int)(x[3] + xc), (int)(y[3] + yc));
                    p1[4] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
                    p1[5] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
                    p1[6] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
                    p1[7] = new Point((int)(x[7] + xc), (int)(y[7] + yc));
                    p2[0] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
                    p2[1] = new Point((int)(x[3] + xc), (int)(y[3] + yc));
                    p2[2] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
                    p2[3] = new Point((int)(x[7] + xc), (int)(y[7] + yc));

                    /*
                     p3[0] = new Point((int)(x[9] + xc), (int)(y[9] + yc));
                    p3[1] = new Point((int)(x[10] + xc), (int)(y[10] + yc));
                    p3[2] = new Point((int)(x[11] + xc), (int)(y[11] + yc));
                    p3[3] = new Point((int)(x[12] + xc), (int)(y[12] + yc));
                    p1[0] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
                    p1[1] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
                    p1[2] = new Point((int)(x[3] + xc), (int)(y[3] + yc));
                    p1[3] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
                    p1[4] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
                    p1[5] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
                    p1[6] = new Point((int)(x[7] + xc), (int)(y[7] + yc));
                    p1[7] = new Point((int)(x[8] + xc), (int)(y[8] + yc));
                    p2[0] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
                    p2[1] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
                    p2[2] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
                    p2[3] = new Point((int)(x[8] + xc), (int)(y[8] + yc));    
                     */

                    g.FillPolygon(br2, p3);
                    g.FillPolygon(br1, p1);
                    g.FillPolygon(br2, p2);
                    label4.Text = String.Format("X: {0:0.00}, Y: {1:0.00}", xc, yc); // вывод координат центра тяжести точки
                }
                // ris();
                if (radioButton2.Checked)
                {
                    Brush br1 = new SolidBrush(Color.FromArgb(255, colorDec1(), 0));
                    Brush br2 = new SolidBrush(Color.FromArgb(0, colorDec1(), colorInc1()));
                    g.Clear(SystemColors.Control);
                    //координаты точек фигуры относительно центра            
                    x[0] = Convert.ToInt32(0);
                    y[0] = Convert.ToInt32(-a / 2.0);
                    x[1] = Convert.ToInt32((a / 2.0) * Math.Cos(Math.PI / 4));
                    y[1] = Convert.ToInt32(-(a / 2.0) * Math.Sin(Math.PI / 4));
                    x[2] = Convert.ToInt32(a / 2.0);
                    y[2] = Convert.ToInt32(0);
                    x[3] = Convert.ToInt32((a / 2.0) * Math.Cos(Math.PI / 4));
                    y[3] = Convert.ToInt32((a / 2.0) * Math.Sin(Math.PI / 4));
                    x[4] = Convert.ToInt32(0);
                    y[4] = Convert.ToInt32(a / 2.0);
                    x[5] = Convert.ToInt32(-(a / 2.0) * Math.Cos(Math.PI / 4));
                    y[5] = Convert.ToInt32((a / 2.0) * Math.Sin(Math.PI / 4));
                    x[6] = Convert.ToInt32(-a / 2.0);//yuy
                    y[6] = Convert.ToInt32(0);
                    x[7] = Convert.ToInt32(-(a / 2.0) * Math.Cos(Math.PI / 4));
                    y[7] = Convert.ToInt32(-(a / 2.0) * Math.Sin(Math.PI / 4));
                    x[8] = Convert.ToInt32(0);
                    y[8] = Convert.ToInt32(-((a * Math.Sqrt(2)) / 2.0));
                    x[9] = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
                    y[9] = Convert.ToInt32(0);
                    x[10] = Convert.ToInt32(0);
                    y[10] = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
                    x[11] = Convert.ToInt32(-((a * Math.Sqrt(2)) / 2.0));
                    y[11] = Convert.ToInt32(0);
                    double[] temp = new double[12];
                    temp = x;//копируем массив x во временную переменную             
                    x = x_rot(temp, y);
                    y = y_rot(temp, y);
                    p3[0] = new Point((int)(x[8] + xc), (int)(y[8] + yc));
                    p3[1] = new Point((int)(x[9] + xc), (int)(y[9] + yc));
                    p3[2] = new Point((int)(x[10] + xc), (int)(y[10] + yc));
                    p3[3] = new Point((int)(x[11] + xc), (int)(y[11] + yc));
                    p1[0] = new Point((int)(x[0] + xc), (int)(y[0] + yc));
                    p1[1] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
                    p1[2] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
                    p1[3] = new Point((int)(x[3] + xc), (int)(y[3] + yc));
                    p1[4] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
                    p1[5] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
                    p1[6] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
                    p1[7] = new Point((int)(x[7] + xc), (int)(y[7] + yc));
                    p2[0] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
                    p2[1] = new Point((int)(x[3] + xc), (int)(y[3] + yc));
                    p2[2] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
                    p2[3] = new Point((int)(x[7] + xc), (int)(y[7] + yc));

                    /*
                     p3[0] = new Point((int)(x[9] + xc), (int)(y[9] + yc));
                    p3[1] = new Point((int)(x[10] + xc), (int)(y[10] + yc));
                    p3[2] = new Point((int)(x[11] + xc), (int)(y[11] + yc));
                    p3[3] = new Point((int)(x[12] + xc), (int)(y[12] + yc));
                    p1[0] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
                    p1[1] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
                    p1[2] = new Point((int)(x[3] + xc), (int)(y[3] + yc));
                    p1[3] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
                    p1[4] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
                    p1[5] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
                    p1[6] = new Point((int)(x[7] + xc), (int)(y[7] + yc));
                    p1[7] = new Point((int)(x[8] + xc), (int)(y[8] + yc));
                    p2[0] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
                    p2[1] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
                    p2[2] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
                    p2[3] = new Point((int)(x[8] + xc), (int)(y[8] + yc));    
                     */

                    g.FillPolygon(br2, p3);
                    g.FillPolygon(br1, p1);
                    g.FillPolygon(br2, p2);
                    label4.Text = String.Format("X: {0:0.00}, Y: {1:0.00}", xc, yc); // вывод координат центра тяжести точки
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //проверяем касание фигурой правой границы            
            if (x.Max() + xc > pictureBox1.Width)
            {                
                xc = pictureBox1.Width - x.Max();//если фигура заходит за границу, 
                //уменьшаем координату центра                
                dir = -1;//меняем направление движения             
            }

            //проверяем касание левой границы             
            if ((x.Min() + xc) < 0)            
            {                
                xc = -x.Min();                
                dir = 1;             
            }

            //проверяем касание фигурой нижней границы            
            if (y.Max() + yc > pictureBox1.Height)
            {
                yc = pictureBox1.Height - y.Max();//если фигура заходит за границу, 
                //уменьшаем координату центра                
                dir = -1;//меняем направление движения             
            }

            //проверяем касание верхней границы             
            if ((y.Min() + yc) < 0)
            {
                yc = -y.Min();
                dir = 1;
            } 
          //  label3.Text = xc.ToString();
          //  double[] temp = new double[12];
         //   temp = x;//копируем массив x во временную переменную             
         //   x = x_rot(temp, y);
         //   y = y_rot(temp, y); 
            c_fi += fi * rotation_rotate;
            ris(); //перерисовываем фигуру            
            dx = v*dir; //приращение координаты зависит от направления и скорости            
            fi =1 * dir * Math.PI / (180); //угол меняет направление  
            if (radioButton1.Checked)
            {
                xc = xc + dx;
                yc = yc;               
            }
            if (radioButton2.Checked)
            {
                xc = xc;
                yc = yc + dx;
            }
          //  xc = xc;
          //  yc = yc+dx;
          //  yc = pictureBox1.Height / 2 +((pictureBox1.Height-a)/2 ) * Math.Sin(0.03 * (xc - a / 2));//движение по синусоиде                         
           

/*
            if ((x1() > pictureBox1.Width) || (x2() > pictureBox1.Width) || (x3() > pictureBox1.Width) ||
                (x4() > pictureBox1.Width) || (x5() > pictureBox1.Width) || (x6() > pictureBox1.Width) ||
                (x7() > pictureBox1.Width) || (x8() > pictureBox1.Width) || (x9() > pictureBox1.Width) ||
                (x10() > pictureBox1.Width) || (x11() > pictureBox1.Width) || (x12() > pictureBox1.Width))
            {
                xc = xc - dx;
                dir = -dir;
            }
            if ((x1()<0)||(x2()<0)||(x3()<0)||(x4()<0)||(x5()<0)||(x6()<0)||
                (x7()<0)||(x8()<0)||(x9()<0)||(x10()<0)||(x11()<0)||(x12()<0))
            {
                xc = xc - dx;
                dir = -dir;
            }
            ris();
            dx = v * dir;
            xc = xc + dx;
            yc = pictureBox1.Height / 2 + ((pictureBox1.Height - b * 2) / 2) * Math.Sin(0.03 * (xc - a / 2));
  */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            v = trackBar1.Value; 
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            rotation_rotate = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            // Функция для изменения размера фигуры
            a = trackBar3.Value;
         //   if (!timer1.Enabled) //проверка включенности таймера(true-таймер выключен)
          //  {
            xc = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
            yc = Convert.ToInt32(pictureBox1.Height / 2 + ((pictureBox1.Height - ((a * Math.Sqrt(2)) / 2.0) * 2) / 2));
             //   b = (a * Math.Sqrt(2)) / 2.0;
            //    xc = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
           //     yc = pictureBox1.Height / 2 + ((pictureBox1.Height - ((a * Math.Sqrt(2)) / 2.0) * 2) / 2) * Math.Sin(0.03 * (xc - a / 2));
         //   }
            ris();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a = default_a;
           // if (!timer1.Enabled) //проверка включенности таймера(true-таймер выключен)
          //  {
              //  b = (a * Math.Sqrt(2)) / 2.0;
            xc = Convert.ToInt32((a * Math.Sqrt(2)) / 2.0);
            yc = pictureBox1.Height / 2 + ((pictureBox1.Height - ((a * Math.Sqrt(2)) / 2.0) * 2) / 2);
            trackBar3.Value = a;
                ris();
         //   }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox1.Text == ""))
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                //  int w;
                // textBox2.Text = yc.ToString();
                //  textBox2.Text = w.ToString();
                yc = Convert.ToInt32(textBox2.Text);
                xc = Convert.ToInt32(textBox1.Text);
                ris();
            }
          //  int a=Convert.ToInt32(textBox1.Text)

         //   yc = Convert.ToString();
           // yc = textBox2.Text;
           // yc = textBox2.Text(ToString);

            /*
   r2 = Math.Round(d / 2, round);
                          textBox2.Text = Convert.ToDouble(textBox1.Text).ToString();
                          textBox3.Text = d.ToString();

  */

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if ((i < '0' || i > '9') && i != '\b')
                e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if ((i < '0' || i > '9') && i != '\b')
                e.Handled = true;
        }

    }
}
