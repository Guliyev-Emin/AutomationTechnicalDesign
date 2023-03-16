using System.Collections.Generic;

namespace AutomationTechnicalDesign.Models
{
    public class Action
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> OperationsId { get; set; }
    }
}