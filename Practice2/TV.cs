using System;


namespace Practice2
{
    //  Colon = extend
    class TV : ElectricalDevice
    {
        

        public TV(bool isOn, string brand):base(isOn,brand)
        {
       
        }


        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV");
            }
            else
            {
                Console.WriteLine("TV is off");
            }
        }
    }
}
