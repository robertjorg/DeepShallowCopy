namespace DeepShallowCopy
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ResponseControllers responseControllers = new ResponseControllers();

            Response firstResponse = responseControllers.GetResponse();
            Console.WriteLine("First Response Number {0} Text {1}", firstResponse.Number, firstResponse.ResponseText);

            Response secondResponse = responseControllers.GetResponse();

            Console.WriteLine("Second Response Number {0} Text {1}", secondResponse.Number, secondResponse.ResponseText);

            firstResponse.ResponseText = "No";
            firstResponse.Number = 2;

            Console.WriteLine("First Response Number {0} Text {1}", firstResponse.Number, firstResponse.ResponseText);
            Console.WriteLine("Second Response Number {0} Text {1}", secondResponse.Number, secondResponse.ResponseText);

            Response thirdResponse = firstResponse.CreateDeepCopy();

            firstResponse.ResponseText = "Should not be the same as three";
            firstResponse.Number = 3;

            Console.WriteLine("First Response Number {0} Text {1}", firstResponse.Number, firstResponse.ResponseText);
            Console.WriteLine("Third Response Number {0} Text {1}", thirdResponse.Number, thirdResponse.ResponseText);

            Console.ReadKey();

        }
    }
}
