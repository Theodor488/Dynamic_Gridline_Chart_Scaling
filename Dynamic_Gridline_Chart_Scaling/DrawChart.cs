using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Gridline_Chart_Scaling
{
    public class DrawChart
    {
        public void Draw(double width, double height, double xMin=0, double xMax = 100, double yMin = 0, double yMax = 100) 
        {
            Console.WriteLine($"Chart Initialized: \nWidth: {width}, Height: {height}. \nMin x: {xMin}, Max x: {xMax} \nMin y: {yMin}, Max y: {yMax}");

            double total_xRange = xMax - xMin;
            double total_yRange = yMax - yMin;

            // total_xRange / number of gridPoints
            double xIntervalBetweenGridLines = total_xRange / 10; 
            double yIntervalBetweenGridLines = total_yRange / 10;

            List<GridPoint> gridLinePositions = new List<GridPoint>();
            double currentXPos = xMin;
            double currentYPos = yMin;

            for (int i=0; i<10; i++)
            {
                GridPoint gridPoint = new GridPoint();

                // Update x / y positions with intervals
                currentXPos = CalculatePos(currentXPos, xIntervalBetweenGridLines);
                currentYPos = CalculatePos(currentYPos, yIntervalBetweenGridLines);

                gridPoint.xAxis = currentXPos;
                gridPoint.yAxis = currentYPos;

                Console.WriteLine($"GridPoint {i}: {gridPoint.xAxis}/{gridPoint.yAxis}");

                gridLinePositions.Add(gridPoint);
            }
        }

        public double CalculatePos(double currentPos, double intervalBetweenGridLines)
        {
            currentPos += intervalBetweenGridLines;
            return currentPos;
        }
    }
}
