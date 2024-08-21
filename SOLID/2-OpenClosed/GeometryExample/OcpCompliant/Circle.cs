namespace src.SOLID._2_OpenClosed.GeometryExample.OcpCompliant
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * System.Math.PI;
        }
    }
}
