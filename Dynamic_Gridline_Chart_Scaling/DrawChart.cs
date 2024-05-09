using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Gridline_Chart_Scaling
{
    public class DrawChart
    {
        public List<GridPoint> Draw(double width, double height, int numOfGridPoints, double xMin=0, double xMax = 100, double yMin = 0, double yMax = 100) 
        {
            Console.WriteLine($"Chart Initialized: \nWidth: {width}, Height: {height}. \nMin x: {xMin}, Max x: {xMax} \nMin y: {yMin}, Max y: {yMax}");

            double total_xRange = xMax - xMin;
            double total_yRange = yMax - yMin;

            // total_xRange / number of gridPoints
            double xIntervalBetweenGridLines = total_xRange / numOfGridPoints;
            double yIntervalBetweenGridLines = total_yRange / numOfGridPoints;

            List<GridPoint> gridLinePositions = new List<GridPoint>();
            double currentXPos = xMin;
            double currentYPos = yMin;

            for (int i=0; i<10; i++)
            {
                GridPoint gridPoint = new GridPoint();
                SetGridPoint(gridPoint, xIntervalBetweenGridLines, yIntervalBetweenGridLines, gridLinePositions, ref currentXPos, ref currentYPos, i);
            }

            return gridLinePositions;
        }

        private void SetGridPoint(GridPoint gridPoint, double xIntervalBetweenGridLines, double yIntervalBetweenGridLines, List<GridPoint> gridLinePositions, ref double currentXPos, ref double currentYPos, int i)
        {
            // Update x / y positions with intervals
            gridPoint.xAxis = currentXPos;
            gridPoint.yAxis = currentYPos;
            gridPoint.ShowLabel = true;

            gridLinePositions.Add(gridPoint);

            // Increment the coords
            currentXPos += xIntervalBetweenGridLines;
            currentYPos += yIntervalBetweenGridLines;
        }
    }
}
