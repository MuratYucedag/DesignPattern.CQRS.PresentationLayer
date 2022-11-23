using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results
{
    public class GetProductPlannerQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductMinStock { get; set; }
        public int ProductMaxStock { get; set; }
        public bool ProductStatus { get; set; }
    }
}
