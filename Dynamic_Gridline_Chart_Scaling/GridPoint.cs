using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Gridline_Chart_Scaling
{
    public class GridPoint
    {
        public double xAxis { get; set; }
        public double yAxis { get; set; }
        public double NearestNeighborDistance { get; set; }
        public bool ShowLabel { get; set; }
    }
}
