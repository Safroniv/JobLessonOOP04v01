using System;

namespace JobLessonOOP04v01Part01
{
    class Buildings
    {
        //Закрытые поля
        private int _buildingNumber;//Номер здания
        private double _heightBuilding;//Высота здания
        private int _floorsBuilding;//Количество подъездов в здании
        private int _numberOfApartamentsBuilding; // Количество квартир в здании
        private int _numberOfEntrancesBuilding; // Количество подъездов в здании


        private static int _generator = 1; // Уникальный номер здания

        //статичный методы для генерации уникального номера здания
        public static int GenerateNumberBuilding() { return _generator++; }


        //методы для заполнения полей и получения значений
        public int GetBuildingNumber() { return _buildingNumber; }
        public void SetBuildingNumber()
        { _buildingNumber = GenerateNumberBuilding(); }

        public double GetHeightBuilding() { return _heightBuilding; }
        public void SetHeightBuilding(double heightBuilding)
        { _heightBuilding = heightBuilding; }

        public int GetFloorsBuilding() { return _floorsBuilding; }
        public void SetFloorsBuilding(int floorsBuilding)
        { _floorsBuilding = floorsBuilding; }

        public int GetNumberOfApartamentsBuilding() { return _numberOfApartamentsBuilding; }
        public void SetNumberOfApartamentsBuilding(int numberOfApartamentsBuilding)
        { _numberOfApartamentsBuilding = numberOfApartamentsBuilding; }

        public int GetNumberOfEntrancesBuilding() { return _numberOfEntrancesBuilding; }
        public void SetNumberOfEntrancesBuilding(int numberOfEntrancesBuilding)
        { _numberOfEntrancesBuilding = numberOfEntrancesBuilding; }

        //хотя можно и так (но это свойства):
        //public int BuildingNumber { get; set; } = GenerateNumberBuilding();
        //public float HeightBuilding { get; set; }
        //public float FloorsBuilding { get; set; }
        //public float NumberOfApartamentsBuilding { get; set; }
        //public float NumberOfEntrancesBuilding { get; set; }

        //метод вычисления высоты этажа
        public double HeightFloor()
        {
            double heightFloor = 0;
            heightFloor = Math.Round(GetHeightBuilding() / GetFloorsBuilding(), 2);
            return heightFloor;
        }
        //метод вычисления количества квартир в подъезде
        public int SummApartamentsEntrance()
        {
            int summApartamentsEntrance = 0;
            summApartamentsEntrance = GetNumberOfApartamentsBuilding() / GetNumberOfEntrancesBuilding();
            return summApartamentsEntrance;
        }
        //метод вычисления количества квартир на этаже
        public int SummApartamentsFloor()
        {
            int summApartamentsFloor = 0;
            summApartamentsFloor = SummApartamentsEntrance() / GetFloorsBuilding();
            return summApartamentsFloor;
        }
        public void PrintInfo()
        {
            //Вывод на печать информации о здании
            Console.WriteLine(
                $"Здание № {_buildingNumber}." + "\n" +
                $"Высота здания № {_buildingNumber}: {_heightBuilding} метров." + "\n" +
                $"В здании № {_buildingNumber} - {_floorsBuilding} этажей." + "\n" +
                $"В здании № {_buildingNumber} - {_numberOfApartamentsBuilding} квартир." + "\n" +
                $"В здании № {_buildingNumber} - {_numberOfEntrancesBuilding} подъезда(ов)." + "\n" +
                $"Высота этажей: {HeightFloor()} метров" + "\n" +
                $"Количество квартир в подъезде: {SummApartamentsEntrance()}" + "\n" +
                $"Количество квартир на этаже: {SummApartamentsFloor()}" + "\n" +
                $"======================================================== ");
        }

    }
}
