﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_8_2
{
    enum MeatCategory { ExtraClass = 50, FisrtCalss = 40, SecondClass = 30 };
    enum KindOfMeat { Mutton, Veal, Pork, Chicken };
    class Meat : Product
    {
        public MeatCategory MeatCategory { get; set; }
        public KindOfMeat KindOfMeat { get; set; }

        public Meat()
        {

        }
        public Meat(string name, double price, double weight, int expirationDate, DateTime productionDate,
            MeatCategory meatCategory, KindOfMeat kindOfMeat)
            : base(name, price, weight, expirationDate, productionDate)
        {
            MeatCategory = meatCategory;
            KindOfMeat = kindOfMeat;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Meat meat = (Meat)obj;
            return (this.MeatCategory == meat.MeatCategory && this.KindOfMeat == meat.KindOfMeat);
        }

        public override string ToString()
        {
            return base.ToString() + $"Category: {this.MeatCategory}\nKind: {this.KindOfMeat}";
        }

        public override void Parse(string s)
        {
            string[] values = s.Split(' ');
            string inputToParse = String.Empty;

            for (int i = 0; i < 6; i++)
            {
                inputToParse += values[i] + " ";
            }

            base.Parse(inputToParse);

            switch (values[6])
            {
                case "ExtraClass": MeatCategory = MeatCategory.ExtraClass; break;
                case "FisrtCalss": MeatCategory = MeatCategory.FisrtCalss; break;
                case "SecondClass": MeatCategory = MeatCategory.SecondClass; break;
            }

            switch (values[7])
            {
                case "Mutton": KindOfMeat = KindOfMeat.Mutton; break;
                case "Veal": KindOfMeat = KindOfMeat.Veal; break;
                case "Pork": KindOfMeat = KindOfMeat.Pork; break;
                case "Chicken": KindOfMeat = KindOfMeat.Chicken; break;
            }

        }
        public override void ChangePrice(double percentage)
        {
            base.ChangePrice(percentage);

            if (percentage > 0)
            {
                switch (MeatCategory)
                {
                    case MeatCategory.ExtraClass:
                        Price += (double)MeatCategory.ExtraClass * Price / 100;
                        break;
                    case MeatCategory.FisrtCalss:
                        Price += (double)MeatCategory.FisrtCalss * Price / 100;
                        break;
                    case MeatCategory.SecondClass:
                        Price += (double)MeatCategory.SecondClass * Price / 100;
                        break;
                }
            }
            else if (percentage < 0)
            {
                switch (MeatCategory)
                {
                    case MeatCategory.ExtraClass:
                        Price -= (double)MeatCategory.ExtraClass * Price / 100;
                        break;
                    case MeatCategory.FisrtCalss:
                        Price -= (double)MeatCategory.FisrtCalss * Price / 100;
                        break;
                    case MeatCategory.SecondClass:
                        Price -= (double)MeatCategory.SecondClass * Price / 100;
                        break;
                }
            }
            else
            {
                return;
            }

        }
    }
}
