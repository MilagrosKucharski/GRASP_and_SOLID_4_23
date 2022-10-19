//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = Catalog.Instance.GetProduct("Café con leche");
            recipe.AddStep(Catalog.Instance.GetProduct("Café"), 100, Catalog.Instance.GetEquipment("Cafetera"), 120);
            recipe.AddStep(Catalog.Instance.GetProduct("Leche"), 200, Catalog.Instance.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {
            Catalog.Instance.AddProductToCatalog("Café", 100);
            Catalog.Instance.AddProductToCatalog("Leche", 200);
            Catalog.Instance.AddProductToCatalog("Café con leche", 300);

            Catalog.Instance.AddEquipmentToCatalog("Cafetera", 1000);
            Catalog.Instance.AddEquipmentToCatalog("Hervidor", 2000);
        }


    }
}
