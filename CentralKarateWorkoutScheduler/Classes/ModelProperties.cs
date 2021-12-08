using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralKarateWorkoutScheduler.Classes
{
    public class ModelProperties
    {
        string name;
        string value;

        public ModelProperties()
        {
            name = null;
            value = null;
        }

        public ModelProperties(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name
        {
            get => name; set => name = value;
        }

        public string Value
        {
            get => value; set => this.value = value;
        }
    }
}
