using OATools.Models;
using System.Collections.Generic;

namespace OATools.ViewModel
{
    public class ToolkitViewModel
    {
        public IEnumerable<Tool> Tools { get; set; }
        public IEnumerable<Toolkit> Toolkit { get; set; }
        public TimedBitchLetter TimedBitchLetter { get; set; }
    }
}