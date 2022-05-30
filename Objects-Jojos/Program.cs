using System;

namespace School
{
    class Core_school
    {
        public string name;
        public string addres;
        public int fundationAge;

        public void Timbrar()
        {
            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(880, 300); //La
            Console.Beep(987, 500); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(987, 500); //Si
            Console.Beep(793, 300); //fa
            Console.Beep(880, 500); //La

            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(880, 300); //La
            Console.Beep(987, 500); //Si
            Console.Beep(1793, 500); //fa
            Console.Beep(1318, 500); //mi
            Console.Beep(1174, 300); //Re'
            Console.Beep(880, 500); //La

            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(880, 300); //La
            Console.Beep(987, 500); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(987, 500); //Si
            Console.Beep(793, 300); //fa
            Console.Beep(880, 500); //La

            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(987, 500); //Si
            Console.Beep(880, 300); //La
            Console.Beep(987, 500); //Si
            Console.Beep(1793, 500); //fa
            Console.Beep(1318, 500); //mi
            Console.Beep(1174, 300); //Re'
            Console.Beep(880, 500); //La



            // Console.Beep(1318, 500); //mi
            // Console.Beep(1174, 500); //Re'
            // Console.Beep(880, 1500); //La
            // Console.Beep(793, 1500); //fa

            // Console.Beep(783, 250); //Sol
            // Console.Beep(880, 250); //La
            // Console.Beep(987, 1000); //Si

            // Console.Beep(1174, 500); //Re'
            // Console.Beep(880, 1500); //La

            // Console.Beep(987, 1000); //Si
            // Console.Beep(1174, 500); //Re'
            // Console.Beep(1760, 1000); //La'
            // Console.Beep(1567, 500); //Sol'
            // Console.Beep(1174, 1000); //Re'

            // Console.Beep(1046, 250); //Do
            // Console.Beep(987, 250); //Si
            // Console.Beep(880, 1000); //La

            //Console.Beep(523, 500); //Do
        }
         
    }
    class Program 
    {
        static void Main(string[] args)
        {
            var mySchool = new Core_school();
            mySchool.name = "Harvard";
            mySchool.addres = "Cambridge, MA, United States";
            mySchool.fundationAge = 1636;

            Console.WriteLine("Timbrando");

            mySchool.Timbrar(); 
        }
    }
}

