using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> CurrentMenu { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered Categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Category { get; set; }

        /// <summary>
        /// The minimum IMDB Rating
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CalMin { get; set; }

        /// <summary>
        /// The maximum IMDB Rating
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CalMax { get; set; }

        /// <summary>
        /// The minimum IMDB Rating
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum IMDB Rating
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        public void OnGet()
        {

            CurrentMenu = Menu.FullMenu();

            IEnumerable<IOrderItem> CurDescriptionMenu = Menu.FullMenu();

          

            //Filter by term
            if (SearchTerms != null)
            {
                foreach (string d in SearchTerms.Split(' '))
                {
                    foreach (IOrderItem item in CurrentMenu)
                    {
                        CurDescriptionMenu = CurDescriptionMenu.Where(item => item.Description.ToLower().Contains(d.ToLower()));

                        CurrentMenu = CurrentMenu.Where(item => item.ToString().ToLower().Contains(SearchTerms.ToLower()) || item.Description.ToLower().Contains(d.ToLower()));
                    }
                    foreach (IOrderItem curitem in CurDescriptionMenu)
                    {
                        CurrentMenu.Append(curitem);
                    }

                }

               
            }

           



            //Filter by calories
            if (CalMin != null || CalMax != null)
            {
                foreach (IOrderItem item in CurrentMenu)
                {
                    CurrentMenu = CurrentMenu.Where(item => (CalMin != null && item.Calories >= CalMin) || (CalMax != null && item.Calories <= CalMax));

                    if (CalMax != null && CalMin != null)
                    {
                        CurrentMenu = CurrentMenu.Where(item => item.Calories >= CalMin && item.Calories <= CalMax);
                    }
                }
            }

            //filter by price
            if (PriceMin != null || PriceMax != null)
            {
                foreach (IOrderItem item in CurrentMenu)
                {
                  
                    CurrentMenu = CurrentMenu.Where(item =>  (PriceMin != null && item.Price >= PriceMin) || (PriceMax != null && item.Price <= PriceMax));

                    if (PriceMax != null && PriceMin != null)
                    {
                        CurrentMenu = CurrentMenu.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
                    }
                }
            }

            //filter by category
            if (Category.Count() != 0)
            {
                    foreach (IOrderItem item in CurrentMenu)
                    {
                       
                        CurrentMenu = CurrentMenu.Where(item => (item is Entree && Category.Contains("Entrees")) || (Category.Contains("Sides") && item is Side) || (Category.Contains("Drinks") && item is Drink));
                    }
            }
        }
    }
}

