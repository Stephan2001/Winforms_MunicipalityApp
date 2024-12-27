using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalAppPROGPOE
{
    public class Issues
    {
        public Issues(string location, string category, string description, byte[] fileContent)
        {
            this.Location = location;
            this.Category = category;
            this.Description = description;
            this.fileContent = fileContent;
        }

        string Location { get; set; }
        string Category { get; set; }
        string Description { get; set; }
        byte[] fileContent { get; set; }

        // for testing
        public override string ToString()
        {
            return "Location: " + Location + "| Category: " + Category + "| Description: " + Description;
        }

    }
}
