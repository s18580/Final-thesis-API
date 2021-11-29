using Final_thesis_api.Models.DictionaryModels;
using System;
using System.Collections.Generic;

namespace Final_thesis_api.Models
{
    public class Valuation
    {
        public int IdValuation { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? OfferValidityDate { get; set; }
        public double GraphicDesignPrice { get; set; }
        public double SamplePrintoutsPrice { get; set; }
        public bool PrintingOnReverse { get; set; }
        public double UnitPriceNet { get; set; }
        public int Circulation { get; set; }
        public int? Capacity { get; set; }
        public string InsideFormat { get; set; }
        public string CoverFormat { get; set; }
        public string InsideSheetFormat { get; set; }
        public string CoverSheetFormat { get; set; }
        public int PrintingPlateNuber { get; set; }
        public double PrintPrice { get; set; }
        public int IdAuthor { get; set; }
        public int IdOrderItem { get; set; }
        public int? IdBindingType { get; set; }

        public Worker Author { get; set; }
        public BindingType BindingType { get; set; }
        public ICollection<File> Files { get; set; }
        public ICollection<Color> CoverColors { get; set; }
        public ICollection<Color> InsideColors { get; set; }
        public ICollection<Paper> CoverPapers { get; set; }
        public ICollection<Paper> InsidePapers { get; set; }
        public ICollection<Service> CoverServices { get; set; }
        public ICollection<Service> InsideServices { get; set; }
        public ICollection<ValuationPriceList> PriceListPrices { get; set; }
    }
}