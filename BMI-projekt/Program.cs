using System;

namespace BMI_projekt
{
    class Program
    {
        static void Main(string[] args)
        


			{   
				int weight;
				int height;
				int bmi;


				Console.WriteLine("prosím zadej výšku v centimetrech: "); 
				height = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("prosím zadej váhu v kilogramech: "); 
				weight = Convert.ToInt32(Console.ReadLine());
           
			
			bmi = (weight * 703) / (height * height);

				
		

					Console.WriteLine("tvoje BMI je {0}. Prosím pokračuj dolů ať víš jestli jsi obézní, hubený, v normě.", bmi); 

					Console.WriteLine("\nHubený: méňe než 18.5\nNormal: mezi 18.5 a 24.9\nNadváha: between 25 and 29.9\nObézní: 30 nebo více.");

			Console.WriteLine("Děkuji za použití BMI kalkulačky, aplikaci ukončíte libovolnou klávesou.");
			Console.ReadKey();







		}

		}
	}
    
