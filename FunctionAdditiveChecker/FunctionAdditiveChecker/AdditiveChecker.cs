using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FunctionAdditiveChecker
{
    public class AdditiveChecker
    {
        static IMapToNumber mapToNumber = new SecretClass();

        static bool validateInput(string[] args, out int inputNumber)
        {
            inputNumber = 0;

            if (args.Length == 0)
            {
                WriteLine("Argument cannot be null, please enter a integer as input parameter");
                return false;
            }
            else if (args.Length > 1)
            {
                WriteLine("Invalid number of input argumets, Please enter a integer as input parameter");
                return false;
            }
            else
            {
                if (!int.TryParse(args[0], out inputNumber))
                {
                    WriteLine("Input argument must be a integer, Please enter a integer as input parameter");
                    return false;
                }
                else if (inputNumber < 1)
                {
                    WriteLine("Error: Please enter integer argument > 1");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        static void Main(string[] args)
        {
            int inputNumber;

            try
            {
                if (validateInput(args, out inputNumber)) // Check if entered input is valid
                {
                    WriteLine("Input to secret function is: " + inputNumber);

                    /* Call secret function */
                    inputNumber = Convert.ToInt32(mapToNumber.Secret(inputNumber));

                    WriteLine("Output of secret function is: " + inputNumber);

                    /* Generate prime numbers */
                    IPrimeNumberGenerator primegenerator = new SievePrimeGenerator(inputNumber);
                    List<int> sieveResult = primegenerator.GeneratePrimeNumbers();

                    WriteLine("Number of primes generated: " + sieveResult.Count);
                    
                    /*Check if function is additive*/
                    if (isAdditive(inputNumber, sieveResult))
                        WriteLine("Secret function is additive.");
                    else
                        WriteLine("Secret function is not additive.");

                } //End validateInput
            }
            catch(Exception e)
            {
                WriteLine("Error occured: "+ e.Message);
            }
            finally
            {
                GC.Collect();
            }

            WriteLine("Press any key to exit.");
            ReadKey();            
                
        } // End main
        
        static bool isAdditive(int sum, List<int> sieveResult)
        {
            if (sieveResult.Count < 2)
                return false;
            
            int x = 0, y = 0, xPlusY = 0;

            for (int i = 0; i < sieveResult.Count-1; i++)
            {
                for (int j = i + 1; j < sieveResult.Count; j++)
                {
                    x = sieveResult[i];
                    y = sieveResult[j];
                    xPlusY = sieveResult[i] + sieveResult[j];

                    //Write("\n X: "+ x +" Y: "+ y +" X+Y: " + xPlusY);
                    if (mapToNumber.Secret( xPlusY ) != mapToNumber.Secret(x) + mapToNumber.Secret(y))
                        return false;
                }
            }
            return true;
        }

    } // End Class
}
