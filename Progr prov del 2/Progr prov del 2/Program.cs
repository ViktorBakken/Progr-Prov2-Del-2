using System;
using System.Collections.Generic;

namespace Progr_prov_del_2
{
    class Program
    {


        static void Main(string[] args)
        {
            Random rand = new Random();
            int day = 1;
            int nummerOfCars = 0;
            int checkedCars = 0;
            List<Car> cars = new List<Car>();
            List<int> unCheckedCars = new List<int>();
            bool wantToPlay = true;

            Console.WriteLine("welcom to border patrol! You will be checking passing cars for contrabands!\nPress Enter");
            Console.ReadLine();

            while (wantToPlay)
            {
                nummerOfCars = rand.Next(1, 10);
                cars = CreateCars(nummerOfCars, rand, cars);

                Klasser.WriteLine("Day " + day.ToString() + "\n You will check " + nummerOfCars + " cars today!", false);

                while (CheckIfAllCarsAreChecked(cars))
                {
                    PrintUnchecked(cars);

                    int math = nummerOfCars - checkedCars;
                    Console.WriteLine("Which car do you want to check? There are " + math.ToString() + " left out of " + nummerOfCars + "!");

                    string car = Console.ReadLine();
                    int chosenCar = Klasser.IsInt(car, "That is not a number or not an available number!", true, nummerOfCars);
                    while (cars[chosenCar].AlreadyChecked.Equals(true))
                    {
                        Console.WriteLine("You havealready checked that car!");
                        chosenCar = Klasser.IsInt(car, "That is not a number or not an available number!", true, nummerOfCars);
                    }
                    PlayerChoiceMenu(chosenCar, cars, checkedCars);
                }
                day++;
            }

        }
        static List<Car> CreateCars(int nummerOfCars, Random rand, List<Car> cars)
        {
            for (int i = 0; i < nummerOfCars; i++)
            {
                int isContracar = rand.Next(1, 2 + 1);
                Car car;
                if (isContracar.Equals(1))
                {
                    car = new ContraCar();
                }
                else
                {
                    car = new CleanCar();
                }
                cars.Add(car);
            }

            return cars;
        }
        static bool CheckIfAllCarsAreChecked(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].AlreadyChecked == false)
                {
                    return true;
                }
            }
            return false;
        }
        static void PlayerChoiceMenu(int chosenCar, List<Car> cars, int checkedCars)
        {
            Console.Clear();
            string[] choices = { "check", "let go" };
            Console.WriteLine("Do you want to check or let the car go?\nCheck or Let Go");
            string playerChoice = Console.ReadLine();
            Klasser.IsTrueString(choices, playerChoice, "That is not an availalble choice!");
            bool foundContraband;

            if (playerChoice == choices[0])
            {
                foundContraband = cars[chosenCar].Examine();
                if (foundContraband.Equals(true))
                {
                    Klasser.WriteLine("There was a hidden contraband in the car!\nPress Enter", false);
                }
                else
                {
                    Klasser.WriteLine("There were no hidden contraband in the car! You paid the driver 10 dollar\nPress Enter", false);
                }
            }
            else
            {
                Klasser.WriteLine("You decided to trust the driver!", false);
            }
            checkedCars++;
        }
        static void PrintUnchecked(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (true)
                {

                }
            }
        }
    }
}
