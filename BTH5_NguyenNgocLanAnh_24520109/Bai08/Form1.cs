using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        // Các hằng số được sử dụng để xác định kích thước và chiều dài kim
        private const int _size = 400; // Đường kính đồng hồ
        private const int _centerX = _size / 2; // Tâm X
        private const int _centerY = _size / 2; // Tâm Y
        private const int _hourLength = 120; // Chiều dài kim giờ (tổng)
        private const int _minuteLength = 160; // Chiều dài kim phút (tổng)
        private const int _secondLength = 160; // Chiều dài kim giây
        private const int _markerLength = 180; // Vị trí đánh dấu (chấm)

        // Độ rộng kim riêng biệt
        private const int _hourWidth = 16;
        private const int _minuteWidth = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            DateTime now = DateTime.Now;
            int hour = now.Hour % 12;
            int minute = now.Minute;
            int second = now.Second;

            g.TranslateTransform(_centerX, _centerY);

            // vẽ mặt đồng hồ 
            for (int i = 0; i < 60; i++)
            {
                float angle = i * 6;
                double radian = (angle * Math.PI) / 180;

                int x = (int)(_markerLength * Math.Sin(radian));
                int y = (int)(-_markerLength * Math.Cos(radian));

                int dotsize = (i % 5 == 0) ? 15 : 5;
                g.FillEllipse(Brushes.White, x - dotsize / 2, y - dotsize / 2, dotsize, dotsize);
            }

            Pen handOutlinePen = new Pen(Color.White, 2);

            // Vẽ kim giờ
            float hourAngle = hour * 30 + minute * 0.5f;
            double hourRad = (hourAngle * Math.PI) / 180;
            PointF[] hourPoints = CalculateComplexHandPoints(hourRad, _hourLength, _hourWidth);
            g.DrawPolygon(handOutlinePen, hourPoints);

            //Vẽ kim phút
            float minuteAngle = minute * 6 + second * 0.1f;
            double minuteRad = (minuteAngle * Math.PI) / 180;
            PointF[] minutePoints = CalculateComplexHandPoints(minuteRad, _minuteLength, _minuteWidth);
            g.DrawPolygon(handOutlinePen, minutePoints);

            //Vẽ kim giây
            float secondAngle = second * 6;
            double secondeRad = (secondAngle * Math.PI) / 180;
            int sX = (int)(_secondLength * Math.Sin(secondeRad));
            int sY = (int)(-_secondLength * Math.Cos(secondeRad));
            g.DrawLine(new Pen(Color.White, 4), 0, 0, sX, sY);
        }

        private PointF[] CalculateComplexHandPoints(double radians, int Length, int width)
        {
            float headLength = (float)Length * 4 / 5;
            float tailLength = (float)Length / 5;

            float shoulderRatio = 0.35f;
            float waistRatio = 0.1f;

            float shoulderWidth = width;
            float waistWidth = width * 0.5f;

            // Góc vuông hai bên
            double sideRadiansPlus = radians + (Math.PI / 2);
            double sideRadiansMinus = radians - (Math.PI / 2);

            // Đầu nhọn (xa nhất)
            float tipX = (float)(headLength * Math.Sin(radians));
            float tipY = (float)(-headLength * Math.Cos(radians));

            // Vai (đầu rộng)
            float shoulderPos = headLength * shoulderRatio;
            float shoulderLineX = (float)(shoulderPos * Math.Sin(radians));
            float shoulderLineY = (float)(-shoulderPos * Math.Cos(radians));

            float shoulderRightX = shoulderLineX + (float)(shoulderWidth * Math.Sin(sideRadiansPlus));
            float shoulderRightY = shoulderLineY + (float)(-shoulderWidth * Math.Cos(sideRadiansPlus));

            float shoulderLeftX = shoulderLineX + (float)(shoulderWidth * Math.Sin(sideRadiansMinus));
            float shoulderLeftY = shoulderLineY + (float)(-shoulderWidth * Math.Cos(sideRadiansMinus));

            // Eo (đuôi hẹp)
            float waistPos = tailLength * waistRatio;
            double tailRadians = radians + Math.PI;
            float waistLineX = (float)(waistPos * Math.Sin(tailRadians));
            float waistLineY = (float)(-waistPos * Math.Cos(tailRadians));

            float waistRightX = waistLineX + (float)(waistWidth * Math.Sin(sideRadiansPlus));
            float waistRightY = waistLineY + (float)(-waistWidth * Math.Cos(sideRadiansPlus));

            float waistLeftX = waistLineX + (float)(waistWidth * Math.Sin(sideRadiansMinus));
            float waistLeftY = waistLineY + (float)(-waistWidth * Math.Cos(sideRadiansMinus));

            // Đuôi ngắn
            float tailX = (float)(tailLength * Math.Sin(tailRadians));
            float tailY = (float)(-tailLength * Math.Cos(tailRadians));

            return new PointF[]
            {
                new PointF(tipX, tipY),
                new PointF(shoulderRightX, shoulderRightY),
                new PointF(waistRightX, waistRightY),
                new PointF(tailX, tailY),
                new PointF(waistLeftX, waistLeftY),
                new PointF(shoulderLeftX, shoulderLeftY)
            };
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}