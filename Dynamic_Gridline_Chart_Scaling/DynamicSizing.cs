using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Gridline_Chart_Scaling
{
    public class DynamicSizing
    {
        public double CalculateNearestNeighborDistance(double point1_x, double point1_y, double point2_x, double point2_y)
        {
            // Use Trigonometry Distance Formula
            double distance = Math.Pow(point1_x - point2_x, 2) + Math.Pow(point1_y - point2_y, 2);
            return distance;
        }

        public List<GridPoint> GetNeighborsWithinMinDistance(List<GridPoint> gridLinePositions, GridPoint currentGridPoint, double minNeighborDistance)
        {
            List<GridPoint> NeighborsWithinMinDistanceAllowed = new List<GridPoint> ();

            foreach (GridPoint gridPoint in gridLinePositions) 
            {
                if (gridPoint != currentGridPoint)
                {
                    double distance = CalculateNearestNeighborDistance(gridPoint.xAxis, currentGridPoint.xAxis, gridPoint.yAxis, currentGridPoint.yAxis);
                    
                    // if distance between neighbors is within minimum neighbor distance then add to list 
                    if (distance < minNeighborDistance)
                    {
                        
                    }
                }
            }

            return gridLinePositions;
        }
    }
}
