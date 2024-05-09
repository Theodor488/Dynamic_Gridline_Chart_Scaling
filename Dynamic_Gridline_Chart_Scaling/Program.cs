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

            Console.WriteLine();

            foreach (GridPoint gridPoint in gridLinePositions)
            {
                dynamicSizing.GetNeighborsWithinMaxDistance(gridLinePositions, gridPoint, 25);
                Console.WriteLine($"GridPoint: {gridPoint.xAxis}/{gridPoint.yAxis} LabelShown: {gridPoint.ShowLabel}");
            }
        }
    }
}