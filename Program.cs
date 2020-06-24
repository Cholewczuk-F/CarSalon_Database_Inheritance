using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisSamochodowy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }

    abstract class Car
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string year { get; set; }
    }

    class OffroadCar : Car
    {
        public bool hasDifflock { get; set; }

        public OffroadCar(int id, string brand, string model, string year, bool hasDifflock)
        {
            base.id = id;
            base.brand = brand;
            base.model = model;
            base.year = year;
            this.hasDifflock = hasDifflock;
        }
    }

    class FamilyCar : Car
    {
        public int seatsValue { get; set; }

        public FamilyCar(int id, string brand, string model, string year, int seatsValue)
        {
            base.id = id;
            base.brand = brand;
            base.model = model;
            base.year = year;
            this.seatsValue = seatsValue;
        }
    }

}
