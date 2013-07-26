using System;
using System.Net;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace HTMLParsing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DisplayInfo("weatherford");
			
		}

		
		public static void DisplayInfo(string city)
		{
			//BestPlaces costOfLiving = new BestPlaces(city, "cost_of_living", "Overall", 2);
			//Console.WriteLine("Cost of Living: " + costOfLiving);
			
			//BestPlaces violentCrime = new BestPlaces(city, "crime", "Violent Crime", 1);
			//Console.WriteLine ("Violent Crime: " + violentCrime);
			//BestPlaces propertyCrime = new BestPlaces(city, "crime", "Property Crime", 1);
			//Console.WriteLine("Property Crime: " + propertyCrime);
			
			//BestPlaces medianAge = new BestPlaces(city, "people", "Median Age", 4);
			//Console.WriteLine("Median Age: " + medianAge);
			//BestPlaces marriedPopulation = new BestPlaces(city, "people", "Married Population", 4);	
			//Console.WriteLine("Married Population: " + marriedPopulation);
		
			
			//BestPlaces airQuality = new BestPlaces(city, "health", "Air Quality (100=best)", 2);
			//Console.WriteLine("Air Quality: " + airQuality);
			//BestPlaces waterQuality = new BestPlaces(city, "health", "Water Quality (100=best)", 2);
			//Console.WriteLine("Water Quality: " + waterQuality);
			
			BestPlaces salesTax = new BestPlaces(city, "economy", "Sales Tax", 5);
			Console.WriteLine ("Sales Tax: " + salesTax);
			//BestPlaces incomeTax = new BestPlaces(city, "economy", "Income Tax", 5);
			//Console.WriteLine ("Income Tax: " + incomeTax);
			
			//BestPlaces homeAppreciation = new BestPlaces(city, "housing", "Home Appreciation", 5);
			//Console.WriteLine ("Home Appreciation: " + homeAppreciation);
			//BestPlaces propertyTaxRate = new BestPlaces(city, "housing", "Property Tax Rate", 5);
			//Console.WriteLine("Property Tax Rate: " + propertyTaxRate);
	
		
				
		}
	}
}