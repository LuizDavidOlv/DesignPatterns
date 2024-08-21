namespace src.SOLID._2_OpenClosed.GeometryExample.OcpCompliant
{
    // Class complies with SRP and OCP. Whenever a new shape is added, the class does not need to be modified.
    public class AreaCalculator
    {
        public double TotalAreaOCP(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
