using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Radio
    {

        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public Radio(bool isOn,string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void ListenRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listening to the radio");
            } else
            {
                Console.WriteLine("Radio is switched off");
            }
        }

    }
}
