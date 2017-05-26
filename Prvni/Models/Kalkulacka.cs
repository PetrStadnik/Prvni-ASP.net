using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prvni.Models
{
    public class Kalkulacka
    {
        [Display(Name = "1. číslo")]
        [Required(ErrorMessage = "Zadejte prosím číslo")]
        public double Cislo1 { get; set; }
        [Display(Name = "2. číslo")]
        [Required(ErrorMessage = "Zadejte prosím číslo")]
        public double Cislo2 { get; set; }
        public double Vysledek { get; set; }
        public string Operace { get; set; }
        public List<SelectListItem> MozneOperace { get; set; }

        public Kalkulacka()
        {
            MozneOperace = new List<SelectListItem>();
            MozneOperace.Add(new SelectListItem { Text = "Sečti", Value = "+", Selected = true });
            MozneOperace.Add(new SelectListItem { Text = "Odečti", Value = "-" });
            MozneOperace.Add(new SelectListItem { Text = "Vynásob", Value = "*" });
            MozneOperace.Add(new SelectListItem { Text = "Vyděl", Value = "/" });
        }
        public void Vypocitej()
        {
            switch (Operace)
            {
                case "+":
                    Vysledek = Cislo1 + Cislo2;
                    break;
                case "-":
                    Vysledek = Cislo1 - Cislo2;
                    break;
                case "*":
                    Vysledek = Cislo1 * Cislo2;
                    break;
                case "/":
                    Vysledek = Cislo1 / Cislo2;
                    break;
            }
        }
    }
}