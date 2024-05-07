using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Gridline_Chart_Scaling
{
    public class DynamicSizing
    {
        public double CalculateNeighborDistance(double point1_x, double point1_y, double point2_x, double point2_y)
        {
            // Use Trigonometry Distance Formula
            double distance = Math.Sqrt(Math.Pow(point1_x - point2_x, 2) + Math.Pow(point1_y - point2_y, 2));
            return distance;
        }

        public void GetNeighborsWithinMaxDistance(List<GridPoint> gridLinePositions, GridPoint currentGridPoint, double minNeighborDistance)
        {
            foreach (GridPoint gridPoint in gridLinePositions) 
            {
                // Check only if gridPoint label is shown and it is not the current gridPoint
                if (currentGridPoint.ShowLabel && gridPoint != currentGridPoint)
                {
                    double distance = CalculateNeighborDistance(gridPoint.xAxis, gridPoint.yAxis, currentGridPoint.xAxis, currentGridPoint.yAxis);
                    
                    // If distance between neighbors is within minimum then remove label
                    if (distance < minNeighborDistance)
                    {
                        gridPoint.ShowLabel = false;
                    }
                }
            }
        }
    }
}
