using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;



  
    


namespace PP_03_bilsjappe_Lars_og_Daniel
    {
        internal class Bilsjappe
        {
            private List<Car> cars = new List<Car>
            {
            new Car("Ferrari", "F40", 1994, 185000, "LH65403"),
            new Car("VolksWagen", "Golf", 2003, 234810, "LH82366"),
                new Car("Audi", "R8", 2024, 6500, "LJ54302"),
            new Car("Ford", "Focus", 2011, 112050, "KZ43809"),
            new Car("Morris", "Mini", 1975, 329720, "DF29540"),
        };

            public void Run()
            {
                while (true)
                {
                    Console.WriteLine("Velkommen til Bilsjappa!\nVennligst velg en av følgende:");
                    Console.WriteLine("[1] Se på biler");
                    Console.WriteLine("[2] Sorter bilene etter km.stand eller årsmodell");
                    Console.WriteLine("[3] Kjøp en av bilene");
                    Console.WriteLine("[0] Gå ut av Bilsjappa");

                    string carshopChoice = Console.ReadLine();

                    switch (carshopChoice)
                    {

                        case "1":
                            WatchCars();
                            break;
                        case "2":
                            SortCars();
                            break;
                        case "3":
                            BuyCar();
                            break;
                        case "0":
                            Console.WriteLine("Takk for at du stakk innom Bilsjappa. Velkommen tilbake!");
                            return;
                        default:
                            Console.WriteLine("Feil tastevalg. Velg på nytt.");
                            break;
                    }
                }
            }

            public void WatchCars()
            {
                Console.WriteLine("For øyeblikket har vi disse bilene tilgjengelige:\n");

                foreach (var car in cars)
                {
                    Console.WriteLine($"Bilmerke: {car.Brand}");
                    Console.WriteLine($"Modell: {car.Model}");
                    Console.WriteLine($"Årgang: {car.Year}");
                    Console.WriteLine($"Km.stand: {car.KmLength}km");
                    Console.WriteLine($"Reg.nr: {car.RegNo}\n");
                }
            }

            public void SortCars()
            {
            //Sort the list by year
         var sortedCars = cars.OrderBy(car => car.Year).ToList();


            Console.WriteLine("Enter the year to search for cars:");
            int input = Convert.ToInt32(Console.ReadLine());

            // see if there is a car with the specified year.
            var matchingCars = sortedCars.Where(car => car.Year >= input).ToList();

            if (matchingCars.Any())
            {
                foreach (Car car in matchingCars)
                {
                    Console.WriteLine($"year: {car.Year} \n brand: {car.Brand}\n model: {car.Model} \n Km.stand: {car.KmLength} \n Reg.nr: {car.RegNo} \n\n");
                }
            }


        }

            public void BuyCar()
            {
                Console.WriteLine("Skriv inn reg.nr på bilen du ønsker å kjøpe.");
                



            }

        }
    }










