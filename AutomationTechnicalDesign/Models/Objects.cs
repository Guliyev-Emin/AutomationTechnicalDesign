using System.Collections.Generic;

namespace AutomationTechnicalDesign.Models
{
    public class Objects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> ConditionalId { get; set; }
    }
}