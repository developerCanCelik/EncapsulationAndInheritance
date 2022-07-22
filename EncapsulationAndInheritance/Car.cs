using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndInheritance
{
    public class Car
    {
        public string marka;
        public int uretim_yil;
        private string model;
        public string enModel
        {
            get
            {
                return model;
            }
            set
            {
                if (value.Length > 3 && value.Length < 20)
                {
                    model = value;
                }
                else
                {
                    model = "Error";
                }
            }
        }

        public void ArabaBilgiGoster()
        {
            Console.WriteLine("Marka: " + marka+ "\nModel: " + model + "\nÜretim yılı: " + uretim_yil);
        }
    }
}
