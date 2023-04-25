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
                // точка центр об`єкта
                Vector2 center = new(myButton.Location.X + myButton.Width / 2, myButton.Location.Y + myButton.Height / 2);
                // знаходимо точку в яку потрібно рухатися
                Vector2 direction = center - new Vector2(closestPoint.X, closestPoint.Y);
                // нормалізуємо точку
                direction /= direction.Length();
                // віддаляємо точку на показник швидкості
                direction *= speedModifier;

                //  об`єкт не може рухатися поза межі
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
                // курсор лівіше крайньої точки об`єкта на вісі X 
                // найближча координата X - крайня ліва точка об`єкта на вісі X
                closestX = rect.Left;
            else if (p.X > rect.Right)
                // курсор правіше крайньої точки об`єкта на вісі X 
                // найближча координата X - крайня права точка об`єкта на вісі X
                closestX = rect.Right;
            else
                // курсор в межах крайніх точок об`єкта на вісі Х
                // найближча координата X збігається з положенням курсору
                closestX = p.X;

            if (p.Y < rect.Top)
                // курсор вище крайньої точки об`єкта на вісі Y 
                // найближча координата Y - крайня вища точка об`єкта на вісі Y
                closestY = rect.Top;
            else if (p.Y > rect.Bottom)
                // курсор нижче крайньої точки об`єкта на вісі Y
                // найближча координата Y - крайня нижча точка об`єкта на вісі Y
                closestY = rect.Bottom;
            else
                // курсор в межах крайніх точок об`єкта на вісі Y
                // найближча координата Y збігається з положенням курсору
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