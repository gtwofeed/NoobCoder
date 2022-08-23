namespace NoobCoder
{
    internal class CoorPoint
    {
        double x;
        internal double X
        {
            get { return x; }
            set { x = value; }
        }
        double y;
        internal double Y
        {
            get { return y; }
            set { y = value; }
        }
        double z;
        internal double Z
        {
            get { return z; }
            set { z = value; }
        }
        internal CoorPoint(double X = 0, double Y = 0, double Z = 0)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        internal static double GetLine(CoorPoint a1, CoorPoint a2)
        {
            double x = a1.X - a2.X;
            double y = a1.Y - a2.Y;
            double z = a1.Z - a2.Z;
            double xy = Math.Sqrt(x * x + y * y);
            double xyz = Math.Sqrt(xy * xy + z * z);
            return xyz;
        }
    }
}
