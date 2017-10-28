using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class Sample:ISample
    {
        public void Run()
        {
            var sandwhich = new Sandwhich(
                new WheatBread(),
                new CondimentList(
                    new List<Condiment> {new MayoCondiment(), new MustardCondiment(), new KetchupCondiment()}),
                new IngredientList(
                    new List<Ingredient> {new LettuceIngredient(), new ChickenIngredient()}),
                new CondimentList(new List<Condiment> {new KetchupCondiment()}),
                new WheatBread());
              
            sandwhich.Interpret(new Context());
        }
    }
}
