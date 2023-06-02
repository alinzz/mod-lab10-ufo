﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 namespace mod_lab10
 {
     public partial class Form1 : Form
     {
         public Form1()
         {
             InitializeComponent();
             Value.Enabled = false;
             ColSteps.Enabled = false;
         }

         public void WithAngle(Point startPoint, Point endPoint, float accuracy, int numberOfMembers)
         {
             double x = startPoint.X, y = startPoint.Y;
             int step = 1;
             Pen pen = new Pen(Color.Black, 2);
             Pen pen2 = new Pen(Color.Green, 5);
             Pen pen3 = new Pen(Color.Red, 5);
             double angle = Atan(Math.Abs(endPoint.Y - startPoint.Y) /
                                 (double)Math.Abs(endPoint.X - startPoint.X), numberOfMembers) * 180 / Math.PI;
             double length = Math.Sqrt(Math.Pow(endPoint.Y - startPoint.Y, 2) + Math.Pow(endPoint.X - startPoint.X, 2));
             double sin = Sin(angle, numberOfMembers);
             double cos = Cos(angle, numberOfMembers);
             Graphics graphics = changeGraphics();
             graphics.DrawEllipse(new Pen(Color.Blue, 5), endPoint.X - accuracy, endPoint.Y - accuracy, accuracy * 2,
                 accuracy * 2);
             graphics.DrawEllipse(new Pen(Color.Green, 5), startPoint.X - 5, startPoint.Y - 5, 10, 10);
             int stepForX = (endPoint.X > startPoint.X) ? 1 : -1;
             int stepForY = (endPoint.Y > startPoint.Y) ? 1 : -1;
             while (length > accuracy)
             {
                 x += stepForX * (step * cos);
                 y += stepForY * (step * sin);
                 graphics.DrawEllipse(new Pen(Color.Red, 5), (int)x, (int)y, 1, 1);
                 double previousLength = length;
                 length = Math.Sqrt(Math.Pow(endPoint.Y - y, 2) + Math.Pow(endPoint.X - x, 2));
                 if (previousLength < length)
                 {
                     MessageBox.Show("Промах не в норме");
                     return;
                 }
             }

             MessageBox.Show("Промах в норме");
         }

         private void LineEquation(Point startPoint, Point endPoint)
         {
             if (endPoint.X - startPoint.X == 0)
             {
                 MessageBox.Show("k = бесконечности");
                 return;
             }

             double k = ((double)(endPoint.Y - startPoint.Y)) / (endPoint.X - startPoint.X);
             double b = startPoint.Y - k * startPoint.X;
             Graphics graphics = changeGraphics();
             graphics.DrawEllipse(new Pen(Color.Blue, 5), endPoint.X - 5, endPoint.Y - 5, 10, 10);
             graphics.DrawEllipse(new Pen(Color.Green, 5), startPoint.X - 5, startPoint.Y - 5, 10, 10);
             int step = (endPoint.X > startPoint.X) ? 1 : -1;
             int currentX = startPoint.X;
             while (currentX != endPoint.X)
             {
                 Thread.Sleep(20);
                 graphics.DrawEllipse(new Pen(Color.Red, 5), new RectangleF(currentX, (float)(k * currentX + b), 1, 1));
                 currentX += step;
             }
         }

         double Atan(double tangent, int numberOfMembers)
         {
             double atan = 0;
             if (-1 <= tangent && tangent <= 1)
             {
                 for (int i = 0; i < numberOfMembers; i++)
                     atan += Math.Pow(-1, i) * Math.Pow(tangent, 2 * i + 1) / (2 * i + 1);
             }
             else
             {
                 int coef = (tangent >= 1) ? 1 : -1;
                 atan = coef * Math.PI / 2;
                 for (int i = 0; i < numberOfMembers; i++)
                 {
                     atan -= Math.Pow(-1, i) / ((2 * i + 1) * Math.Pow(tangent, 2 * i + 1));
                 }
             }

             return atan;
         }

         int Fact(int n)
         {
             if (n == 0) return 1;
             return n * Fact(n - 1);
         }

         private double Sin(double angle, int numberOfMembers)
         {
             double sin = 0;
             for (int i = 0; i < numberOfMembers; i++)
             {
                 int factorial = Fact(2 * i + 1);
                 sin += Math.Pow(-1, i) * (Math.Pow(angle * Math.PI / 180, 2 * i + 1) / factorial);
             }

             return sin;
         }

         private double Cos(double angle, int colsteps)
         {
             double cos = 0;
             for (int i = 0; i < colsteps; i++)
             {
                 int factorial = Fact(2 * i);
                 cos += Math.Pow(-1, i) * Math.Pow(angle * Math.PI / 180, 2 * i) / factorial;
             }

             return cos;
         }
         

         private Graphics changeGraphics()
         {
             Graphics graphics = CreateGraphics();
             graphics.TranslateTransform(Width / 2, Height / 2);
             graphics.ScaleTransform(0.5f, 0.5f);
             return graphics;
         }

         private void Form1_Paint(object sender, PaintEventArgs e)
         {
             Pen blackPen = new Pen(Color.Black, 1);
             Graphics graphics = changeGraphics();
             graphics.DrawLine(blackPen, new Point(-1000, 0), new Point(1000, 0));
             graphics.DrawLine(blackPen, new Point(0, 1000), new Point(0, -1000));
         }


         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (comboBox1.SelectedIndex == 0)
             {
                 Value.Enabled = true;
                 ColSteps.Enabled = true;
             } else {
                 Value.Enabled = false;
                 ColSteps.Enabled = false;
             }
         }

         private void x1_KeyPress(object sender, KeyPressEventArgs e)
         {
             char number = e.KeyChar;
             if (!Char.IsDigit(number) && number != 8 && number != '-')
                 e.Handled = true;
         }

         private void Value_KeyPress(object sender, KeyPressEventArgs e)
         {
             char number = e.KeyChar;
             if (!Char.IsDigit(number) && number != 8 && number != ',')
                 e.Handled = true;
         }

         private void button1_Click(object sender, EventArgs e)
         {
             if (x1.Text == "" || y1.Text == "" || x2.Text == "" || y2.Text == ""
                 || (comboBox1.SelectedIndex == 0 && (Value.Text == "" || ColSteps.Text == "")))
             {
                 MessageBox.Show("Неправильно введены данные");
                 return;
             }
             Point startingPoint = new Point(int.Parse(x1.Text), int.Parse(y1.Text));
             Point endPoint = new Point(int.Parse(x2.Text), int.Parse(y2.Text));
             switch (comboBox1.SelectedIndex)
             {
                 case 0:
                 {
                     float accuracy = float.Parse(Value.Text);
                     int numberOfMembers = int.Parse(ColSteps.Text);
                     WithAngle(startingPoint, endPoint, accuracy, numberOfMembers);
                     break;
                 }
                 case 1:
                 {
                     LineEquation(startingPoint, endPoint);
                     break;
                 }
             }
         }
         
     }
 }