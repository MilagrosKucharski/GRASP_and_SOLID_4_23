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
        private static List<Product> productCatalog = new List<Product>();

        private static List<Equipment> equipmentCatalog = new List<Equipment>();

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = catalog.Instance.GetProduct("Café con leche");
            recipe.AddStep(new Step(catalog.Instance.GetProduct("Café"), 100, catalog.Instance.GetEquipment("Cafetera"), 120));
            recipe.AddStep(new Step(catalog.Instance.GetProduct("Leche"), 200, catalog.Instance.GetEquipment("Hervidor"), 60));

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {
            catalog.Instance.AddProductToCatalog("Café", 100);
            catalog.Instance.AddProductToCatalog("Leche", 200);
            catalog.Instance.AddProductToCatalog("Café con leche", 300);

            catalog.Instance.AddEquipmentToCatalog("Cafetera", 1000);
            catalog.Instance.AddEquipmentToCatalog("Hervidor", 2000);
        }


    }
}
