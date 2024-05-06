using System;

namespace Dynamic_Gridline_Chart_Scaling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DrawChart drawChart = new DrawChart();
            DynamicSizing dynamicSizing = new DynamicSizing();

            List<GridPoint> gridLinePositions = drawChart.Draw(100, 100);

            foreach (GridPoint gridPoint in gridLinePositions)
            {
                // TODO figure out how to update gridPointsWithinMinDistance instead of just recreating it
                List<GridPoint> gridPointsWithinMinDistance = dynamicSizing.GetNeighborsWithinMaxDistance(gridLinePositions, gridPoint, 5);
            }

            
        }
    }
}