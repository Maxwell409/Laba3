using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3.Classes
{
    public class Status
    {
        MainWindow mainWindow;

        private int hungry = 100;
        private int mood = 100;
        private int money = 100;

        public bool isPet = false;
        public bool isTraining = false;
        public bool isMarried = false;
        public int salary = 0;
        public int day = 1;
        public int month = 1;
        public int year = 2000;

        public Status(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public int _hungry
        {
            get
            {
                return hungry;
            }
            set
            {
                if (hungry > 0 && value <= 0)
                    hungry = value;
                else if (value >= 0)
                    hungry = value;
                mainWindow.HungryLabel.Content = hungry;
                if(hungry <= 0)
                {
                    MessageBox.Show("You Died");
                    mainWindow.Close();
                }
            }
        }

        public int _mood
        {
            get
            {
                return mood;
            }
            set
            {
                if(mood > 0 && value <= 0)
                    mood = value;
                else if (value >= 0)
                    mood = value;
                mainWindow.MoodLabel.Content = mood;
                if (mood <= 0)
                {
                    MessageBox.Show("You Died");
                    mainWindow.Close();
                }
            }
        }

        public int _money
        {
            get
            {
                return money;
            }
            set
            {
                if (value >= 0) 
                    money = value;
                else if ((money > 0) && (value <= 0))
                    money = value;
                else if (value > money)
                    MessageBox.Show("Недостаточно денег");

                mainWindow.MoneyLabel.Content = money;
            }
        }

    }
}
