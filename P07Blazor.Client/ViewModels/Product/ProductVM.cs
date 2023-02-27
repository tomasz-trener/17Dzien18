using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Blazor.Client.ViewModels.Product
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public double? PriceFrom { get; set; } = 0;

        public double? PriceTo { get; set; } = 0;

        public string MaterialCategory { get; set; } = string.Empty;

        public string[] Adjectives { get; set; }

        public string ImageUrl { get; set; } = string.Empty;


        public string ProductAdjetiveCssClass(string ProductAdjectiveName)
        {
            if (ProductAdjectiveName == "Practical")
                return "badge badge-primary";
            if (ProductAdjectiveName == "Unbranded")
                return "badge badge-success";
            if (ProductAdjectiveName == "Intelligent")
                return "badge badge-warning";

            return "";
        }

        private Dictionary<string, string> materialCategoryCSS = new Dictionary<string, string>()
        {
            { "Granite","t-primary" },
            { "Fresh","t-success" },
            { "Rubber","t-danger" },
            { "Soft","t-warning" },
            { "Frozen","t-dot"},
        };

        public string MaterialCategoryCSS =>
            MaterialCategory == null ? "" : materialCategoryCSS[MaterialCategory];

    }
}
