using System;

namespace src.SOLID._2_OpenClosed.GeometryExample.OcpViolation
{
    public class AreaCalculator
    {
        // This method violates the Open-Closed Principle because every time a new shape is added, the method must be modified.
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }
}
