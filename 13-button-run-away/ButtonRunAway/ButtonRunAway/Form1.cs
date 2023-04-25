using System.Diagnostics;
using System.Drawing;
using System.Numerics;

namespace ButtonRunAway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += MouseMoveEvent;
        }
        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            Point closestPoint = FindClosestPointOnButton(myButton.Bounds, e.Location);

            double distance = GetDistance(e.Location, closestPoint);
            if (distance < minimumDistance)
            {
                // ����� ����� ��`����
                Vector2 center = new(myButton.Location.X + myButton.Width / 2, myButton.Location.Y + myButton.Height / 2);
                // ��������� ����� � ��� ������� ��������
                Vector2 direction = center - new Vector2(closestPoint.X, closestPoint.Y);
                // ���������� �����
                direction /= direction.Length();
                // ��������� ����� �� �������� ��������
                direction *= speedModifier;

                //  ��`��� �� ���� �������� ���� ���
                if (myButton.Location.X + direction.X < 0) direction.X = -myButton.Location.X;
                if (myButton.Location.X + myButton.Width + direction.X > ClientSize.Width) direction.X = ClientSize.Width - myButton.Location.X - myButton.Width;
                if (myButton.Location.Y + direction.Y < 0) direction.Y = -myButton.Location.Y;
                if (myButton.Location.Y + myButton.Height + direction.Y > ClientSize.Height) direction.Y = ClientSize.Height - myButton.Location.Y - myButton.Height;

                myButton.Location = new Point(myButton.Location.X + (int)direction.X, myButton.Location.Y + (int)direction.Y);
            }
        }

        private static Point FindClosestPointOnButton(Rectangle rect, Point p)
        {
            int closestX, closestY;

            if (p.X < rect.Left)
                // ������ ���� ������� ����� ��`���� �� �� X 
                // ��������� ���������� X - ������ ��� ����� ��`���� �� �� X
                closestX = rect.Left;
            else if (p.X > rect.Right)
                // ������ ������ ������� ����� ��`���� �� �� X 
                // ��������� ���������� X - ������ ����� ����� ��`���� �� �� X
                closestX = rect.Right;
            else
                // ������ � ����� ������ ����� ��`���� �� �� �
                // ��������� ���������� X �������� � ���������� �������
                closestX = p.X;

            if (p.Y < rect.Top)
                // ������ ���� ������� ����� ��`���� �� �� Y 
                // ��������� ���������� Y - ������ ���� ����� ��`���� �� �� Y
                closestY = rect.Top;
            else if (p.Y > rect.Bottom)
                // ������ ����� ������� ����� ��`���� �� �� Y
                // ��������� ���������� Y - ������ ����� ����� ��`���� �� �� Y
                closestY = rect.Bottom;
            else
                // ������ � ����� ������ ����� ��`���� �� �� Y
                // ��������� ���������� Y �������� � ���������� �������
                closestY = p.Y;
            return new Point(closestX, closestY);
        }

        private static double GetDistance(Point p1, Point p2)
        {
            return new Vector2(p1.X - p2.X, p1.Y - p2.Y).Length();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new UnreachableException("IMPOSSIBLE");
        }

        private const int minimumDistance = 25;
        private const int speedModifier = 5;
    }
}