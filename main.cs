// Created by: Venika Sem
// Created on: May 2022
//
// This program lets user order pizza

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program creates and prices a pizza
        const double TAX = 1.13;
        double pizzaSize;
        double sizeCost = 0;
        double toppingsCost = 0;
        double pizzaToppings;
        double totalPrice;

        Console.WriteLine("This program let's you order a pizza");
        Console.WriteLine("");
        Console.WriteLine("Here are the sizes:");
        Console.WriteLine("Large is $6 and Extra large is $10");
        Console.WriteLine("Input 6 for Large and 10 for Extra large:");
        pizzaSize = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        if (pizzaSize == 6)
        {
            sizeCost = 6;
        }

        if (pizzaSize == 10)
        {
            sizeCost = 10;
        }

        Console.WriteLine("");
        Console.WriteLine("How many toppings do you want");
        Console.WriteLine("");
        Console.WriteLine("These are the options:");
        Console.WriteLine("One toppings is $1, two is $1.75, three is $2.50 and four is $3.35");
        Console.WriteLine("Input 1 for one topping, 2 for two toppings, 3 for three toppings and 4 for four toppings:");
        pizzaToppings = Convert.ToDouble(Console.ReadLine());

        if (pizzaToppings == 1)
        {
            toppingsCost = 1.00;
        }

        if (pizzaToppings == 2)
        {
            toppingsCost = 1.75;
        }

        if (pizzaToppings == 3)
        {
            toppingsCost = 2.50;
        }

        if (pizzaToppings == 4)
        {
            toppingsCost = 3.35;
        }


        totalPrice = (toppingsCost + sizeCost) * TAX;
        Console.WriteLine("");
        Console.WriteLine("The total cost of your pizza today is $" + totalPrice.ToString("0.00") + ". Enjoy!");
        Console.WriteLine("\nDone.");
    }
}