using System;

namespace Dynamic_Gridline_Chart_Scaling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DrawChart drawChart = new DrawChart();
            DynamicSizing dynamicSizing = new DynamicSizing();

            double chartWidth = 100;
            double chartHeight = 100;
            int numOfGridPoints = 10;
            int minNeighborDistance = 25;

            List<GridPoint> gridLinePositions = drawChart.Draw(chartWidth, chartHeight, numOfGridPoints);

            Console.WriteLine($"\nNumber of GridPoints: {numOfGridPoints}");
            Console.WriteLine($"Minimum allowed distance between GridPoints: {minNeighborDistance}\n");

            foreach (GridPoint gridPoint in gridLinePositions)
            {
                dynamicSizing.GetNeighborsWithinMaxDistance(gridLinePositions, gridPoint, minNeighborDistance);
                Console.WriteLine($"GridPoint: {gridPoint.xAxis}/{gridPoint.yAxis} LabelShown: {gridPoint.ShowLabel}");
            }
        }
    }
}