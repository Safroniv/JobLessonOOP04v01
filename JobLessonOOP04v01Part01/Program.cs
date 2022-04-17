using System;
using System.Collections;

namespace JobLessonOOP04v01Part01
{
    class Program
    {
        static void Main()
        {
            //Здание #1
            Buildings newBuilding1 = new Buildings();
            newBuilding1.SetBuildingNumber();
            newBuilding1.SetHeightBuilding(48.3);
            newBuilding1.SetFloorsBuilding(18);
            newBuilding1.SetNumberOfApartamentsBuilding(450);
            newBuilding1.SetNumberOfEntrancesBuilding(5);
            newBuilding1.PrintInfo();

            //Здание #2
            Buildings newBuilding2 = new Buildings();
            newBuilding2.SetBuildingNumber();
            newBuilding2.SetHeightBuilding(50.5);
            newBuilding2.SetFloorsBuilding(20);
            newBuilding2.SetNumberOfApartamentsBuilding(400);
            newBuilding2.SetNumberOfEntrancesBuilding(5);
            newBuilding2.PrintInfo();

            Console.ReadLine();
        }
    }
}
