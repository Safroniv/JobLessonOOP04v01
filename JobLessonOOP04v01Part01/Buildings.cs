using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализовать класс для описания здания
//(уникальный номер здания, высота,
//этажность, количество квартир, подъездов).
//Поля сделать закрытыми, предусмотреть методы для заполнения полей
//и получения значений полей для печати.
//Добавить методы вычисления высоты этажа,
//количества квартир в подъезде, количества квартир на этаже и т.д.
//Предусмотреть возможность,
//чтобы уникальный номер здания генерировался программно.
//Для этого в классе предусмотреть статическое поле,
//которое бы хранило последний использованный номер здания,
//и предусмотреть метод, который увеличивал бы значение этого поля.

namespace JobLessonOOP04v01Part01
{
    class Buildings
    {
        //Закрытые поля
        private int _buildingNumber;
        private float _heightBuilding;
        private int _floorsBuilding;
        private int _numberOfApartamentsBuilding;
        private int _numberOfEntrancesBuilding;

        public int BuildingNumber { get; set; }
        public float HeightBuilding { get; set; }
        public float FloorsBuilding { get; set; }
        public float NumberOfApartamentsBuilding { get; set; }
        public float NumberOfEntrancesBuilding { get; set; }


    }
}
