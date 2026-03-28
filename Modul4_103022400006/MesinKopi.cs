using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400006
{
    public class MesinKopi
    {

        private string currentState = "OFF";

        public void PowerOn()
        {
            if (currentState == "OFF")
            {
                currentState = "STANDBY";
                Console.WriteLine("Mesin Off berubah menjadi Standby");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
           
        }
        public void StartBrew()
        {
            if (currentState == "STANDBY")
            {
                currentState = "BREWING";
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }

        }
        public void FinishBrew()
        {
            if (currentState == "BREWING")
            {
                currentState = "STANDBY";
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }

        }
        public void StartMaintenance()
        {
            if (currentState == "STANDBY")
            {
                currentState = "MAINTENANCE";
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }

        }
        public void FinishMaintenance()
        {
            if (currentState == "MAINTENANCE")
            {
                currentState = "STANDBY";
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }

        }
        public void PowerOff()
        {
            if (currentState == "STANDBY")
            {
                currentState = "OFF";
                Console.WriteLine("Mesin Standby berubah menjadi Off");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }

        }
    }
}
