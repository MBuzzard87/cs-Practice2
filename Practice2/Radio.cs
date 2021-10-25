using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Radio:ElectricalDevice
    {

        public Radio(bool isOn,string brand):base(isOn,brand)
        {
         
        }


        public void ListenRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listening to the {0} radio",Brand);
            } else
            {
                Console.WriteLine("Radio is switched off");
            }
        }

    }
}
