﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlapp.models;
using sqlapp.services;

namespace sqlapp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        public void OnGet()
        {
            ProductService productservice = new ProductService();
            Products = productservice.GetProducts();
        }
    }
}