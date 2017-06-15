using System;
namespace GeometricFigures
{
    /// <summary>
    /// Класс "Кольцо"
    /// </summary>
    [Serializable]
    public class Ring : IFigures
    {
        private double _outsideRadius;
        private double _innerRadius;
        

        /// <summary>
        /// Внутренний радиус
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Внешний радиус
        /// </summary>
        public double OutsideRadius
        {
            get { return _outsideRadius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _outsideRadius = value;
            }
        }

        /// <summary>
        /// Проверка радиусов
        /// </summary>
        public void SetRadius(double outsideRadius, double innerRadius)
        {
            if (outsideRadius <= innerRadius)
            {
                throw new ArgumentException("Неправельный внешний или внутренний радиус");
            }
            else
            {
            OutsideRadius = outsideRadius;
            InnerRadius = innerRadius;
            }
        }

        /// <summary>
        /// Пустой конструктор 
        /// </summary>
        public Ring()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Ring(double outsideRadius, double innerRadius)
        {
            SetRadius(outsideRadius, innerRadius);
        }

        /// <summary>
        /// Площадь кольца
        /// </summary>
        public double Area
        {
            get
            {
                if (_innerRadius <= 0 || _outsideRadius <= 0)
                {
                    throw new ArgumentException("Данные не заполнены");
                }
                return (Math.PI * ((Math.Pow(OutsideRadius, 2)) - (Math.Pow(InnerRadius, 2))));
            }
        }
        /// <summary>
        /// Периметр кольца
        /// </summary>
        public double Perimeter
        {
            get
            {
                if (_innerRadius <= 0 || _outsideRadius <= 0)
                {
                    throw new ArgumentException("Данные не заполнены");
                }
                return (2 * Math.PI * (OutsideRadius -InnerRadius));
            }
        }
        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type
        {
            get
            {
                return "Кольцо";
            }
        }
    }
}
