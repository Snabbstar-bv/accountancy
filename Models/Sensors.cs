using System;
namespace Snabbstar_Education.Models
{
    public class sensor_heat
    {
        public int id { get; }
        public string name { get; set; }
        public double data { get; set; }

        public sensor_heat(int id, string name, double data)
        {
            this.id = id;
            this.name = name;
            this.data = data;
        }
    }
}

