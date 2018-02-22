using System;
using System.Collections.Generic;
using System.Linq;
using Models.ItemModels;
using Models;
using ItemService;

namespace GildedRose
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Gilded Rose.");
            List<InputData> inputData = LoadData();

            foreach (InputData data in inputData)
            {
                Item item = ItemFactory.GetItem(data.ItemName, data.SellInValue, data.Quality);
                if (item == null)
                    Console.WriteLine("NO SUCH ITEM");
                else
                {
                    item.EndOfDay();
                    Console.WriteLine(data.ItemName + " " +  item.SellIn.ToString() + " " + item.Quality.ToString());
                }
            }
            Console.WriteLine("Please close the application when you have finished.");
        }

        private static List<InputData> LoadData() 
        {
            Console.WriteLine("Please enter the filepath of your .txt input file:");
            List<InputData> inputData = new List<InputData>();

            string filepath = Console.ReadLine();

            try
            {
                string[] inputLines = System.IO.File.ReadAllLines(@filepath);
                foreach (string item in inputLines)
	            {
                    inputData.Add(ConvertStringToInputData(item));
	            }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to open file "+filepath+". \nPlease ensure this file exists, is a .txt format and contains the correct data.");
                Console.WriteLine("Please try again or close the application.");
                LoadData();
            }
            return inputData;
        }

        private static InputData ConvertStringToInputData(string input) 
        {
            InputData result = new InputData();

            //get all text before the first digit and trim whitespace
            result.ItemName = string.Concat(input.TakeWhile(c => (c < '0' || c > '9') && c != '-')).Trim();

            //get the rest of the string and split it for the numbers
            input = input.Substring(result.ItemName.Length).Trim();
            string[] values = input.Split(' ');

            //parse the ints without whitespace
            result.SellInValue = int.Parse(values[0].Trim());
            result.Quality = int.Parse(values[1].Trim());
            
            return result;
        }
    }
}
