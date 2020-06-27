using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Food
    {
        /// <summary>
        /// Название еды
        /// </summary>
        public string  Name { get; }

        /// <summary>
        /// Белок
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; }


        /// <summary>
        /// Калории за 100 грамм
        /// </summary>
        public double Calories { get; set; }


        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="name"></param>
        public Food(string name) : this(name, 0, 0, 0, 0) {  }

        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
