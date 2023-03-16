using System.Collections.Generic;

namespace AutomationTechnicalDesign.Models
{
    public class Controls
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> ToolsId { get; set; }
        public List<int> OperationsId { get; set; }
    }
}