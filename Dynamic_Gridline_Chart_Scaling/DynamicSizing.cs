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
            double distance = Math.Pow(point1_x - point2_x, 2) + Math.Pow(point1_y - point2_y, 2);
            return distance;
        }

        public List<GridPoint> GetNeighborsWithinMaxDistance(List<GridPoint> gridLinePositions, GridPoint currentGridPoint, double minNeighborDistance)
        {
            List<GridPoint> neighborsWithinMinDistanceAllowed = new List<GridPoint> ();

            foreach (GridPoint gridPoint in gridLinePositions) 
            {
                // Check only if gridPoint label is shown and it is not the current gridPoint
                if (gridPoint != currentGridPoint && gridPoint.ShowLabel)
                {
                    double distance = CalculateNeighborDistance(gridPoint.xAxis, currentGridPoint.xAxis, gridPoint.yAxis, currentGridPoint.yAxis);
                    
                    // if distance between neighbors is within minimum neighbor distance then add to list 
                    if (distance < minNeighborDistance)
                    {
                        gridPoint.ShowLabel = false;
                    }
                }
            }

            return gridLinePositions;
        }
    }
}
