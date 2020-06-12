using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    /// 
    [Serializable]
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Конструктор для создания пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">День рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Проверки ввода данных
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользвователя не может быть пустым.", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1980") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Недействительная дата рождения.", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Вес не может быть нулевым.", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentException("Рост не может быть нулевым.", nameof(height));
            }
            #endregion

            Name = name;

            Gender = gender;

            BirthDate = birthDate;

            Weight = weight;

            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
