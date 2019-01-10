using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsibilitiesWorkers
{
    class Program
    {

        public static List<Kolhoznik> kolhoz = new List<Kolhoznik>() {
        new Kolhoznik("Иван Иванов", 21, 120, "Крестьянин"),
        new Kolhoznik("Петр Петров", 32, 220, "Тракторист"),
        new Kolhoznik("Сидор Сидоров", 41, 130, "Крестьянин"),
        new Kolhoznik("Лиза Минина", 27, 160, "Доярка"),
        new Kolhoznik("Авас Горидзе", 38, 240, "Комбайнер"),
        new Kolhoznik("Ян Лепалло", 19, 130, "Крестьянин"),
        new Kolhoznik("Анна Минина", 33, 170, "Доярка"),
        new Kolhoznik("Виктор Базюк", 44, 320, "Бригадир"),
        new Kolhoznik("Егор Иванов", 36, 260, "Тракторист"),
        new Kolhoznik("Елена Жмых", 24, 180, "Доярка"),
        new Kolhoznik("Жанна Кайнц", 39, 550, "Агроном"),
        new Kolhoznik("Иван Иванов", 29, 140, "Крестьянин"),
        new Kolhoznik("Петр Иванов", 40, 150, "Крестьянин"),
        new Kolhoznik("Иван Петров", 30, 140, "Крестьянин"),
        new Kolhoznik("Ольга Квас", 29, 160, "Доярка"),
        new Kolhoznik("Вано Гогия", 45, 330, "Бригадир"),
        new Kolhoznik("Арвидас Окс", 36, 210, "Тракторист"),
        new Kolhoznik("Илья Иванов", 50, 150, "Крестьянин"),
        new Kolhoznik("Иван Капуста", 52, 620, "Агроном"),
        new Kolhoznik("Ахмед Самтов", 58, 940, "Председатель")};
                   
        public static List<Kolhoznik> sacrifice = new List<Kolhoznik>(kolhoz);
        public static Form1 form1 = new Form1();

        public static FilterByPosition filterByPosition = new FilterByPosition(null);
        public static FilterBySalary filterBySalary = new FilterBySalary(filterByPosition);
        public static FilterByAge filterByAge = new FilterByAge(filterBySalary);

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
       
        public static void Main()
        {
           
           // Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(form1);
            form1.listBoxBase.Items.Clear();
            form1.listBoxBase.Items.AddRange(kolhoz.ToArray());
        }

        //public static void StartFiltering()
        //{
        //    filterByAge.OperateFilter(sacrifice);
        //}

    }
}
