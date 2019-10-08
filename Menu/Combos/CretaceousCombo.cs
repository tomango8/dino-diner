﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;
namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                

            }
        }

        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - .25;
            }
            
        }

        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }

        }

        public override string ToString()
        {
            return $"{Entree} Combo";
        }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }



        }

        

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            
        }
        


    }
}
