﻿namespace AbstractFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      var machine = new HotDrinkMachine();
      var drink = machine.MakeDrink();
      drink.Consume();
    }
  }
}
