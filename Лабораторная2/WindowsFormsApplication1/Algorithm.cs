using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Point
    {
        public decimal x;
        public decimal y;
        public Point(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + "; " + y + ")";
        }
    }


    public abstract class Trajectory
    {
        public bool ParabolaOrStraight;
        bool CheckCollision = false;
        public decimal[] coefficients;
        public decimal SinusoidFreeTerm;
        public Point[] Points = { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) };
        public Point[] PointsCollision = { new Point(-1, 2) };

        public abstract Point[] BuiltPoints(decimal[] x);
        public void CreatePoints(decimal[] x)
        {
            if (ParabolaOrStraight == true)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = 0; j < coefficients.Length; j++)
                    {
                        Points[i].x = x[i];
                        Points[i].y = Points[i].y + coefficients[j] * (decimal)Math.Pow((double)Points[i].x, j);
                    }
                }
            }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Points[i].x = x[i];
                    Points[i].y = (decimal)Math.Sin((double)Points[i].x) + SinusoidFreeTerm;
                }
            }
        }

        public decimal[] GetPoints(decimal[] x)
        {
            return x;
        }

        public void Collision(Point[] Points)
        {
            for (int i = 0; i < Points.GetLength(0); i++)
            {
                for (int j = 0; j < PointsCollision.GetLength(0); j++)
                {
                    if (Points[i].x == PointsCollision[j].x && Points[i].y == PointsCollision[j].y)
                    {
                        CheckCollision = true;
                    }
                }
            }
        }
    }


    public class Polynomial : Trajectory
    {
        public override Point[] BuiltPoints(decimal[] x)
        {
            return Points;
        }
    }


    public class Parabola : Polynomial
    {
        public Parabola(decimal[] coefficients, bool ParabolaOrStraight)
        {
            if (coefficients.Length == 3)
            {
                this.coefficients = coefficients;
                this.ParabolaOrStraight = ParabolaOrStraight;
            }
        }
    }

    public class Straight : Polynomial
    {
        public Straight(decimal[] coefficients, bool ParabolaOrStraight)
        {
            if (coefficients.Length == 2)
            {
                this.coefficients = coefficients;
                this.ParabolaOrStraight = ParabolaOrStraight;
            }
        }
    }

    public class TranscendentalCurves : Trajectory
    {
        public override Point[] BuiltPoints(decimal[] x)
        {
            return Points;
        }
    }

    public class Sinusoid
        : TranscendentalCurves
    {
        public Sinusoid(decimal SinusoidFreeTerm, bool ParabolaOrStraight)
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
            this.ParabolaOrStraight = ParabolaOrStraight;
        }
    }
}