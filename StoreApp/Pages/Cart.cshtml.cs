using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;
using StoreApp.Infrastructure.Extensions;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {

        private readonly IServiceManager _manager;

  
        public Cart Cart { get; set; }

        public CartModel(IServiceManager manager, Cart cartService)
        {
            _manager = manager;
          
            Cart = cartService;

        }
      

        public string ReturnUrl { get; set; } = "/";

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
           
        }
        

        public IActionResult OnPost(int productId, string returnUrl)
        {
            Product? product = _manager.ProductService.GetOneProduct(productId, false);

            if (product is not null)
            {
               
                Cart.AddItem(product, 1);
               
            }
            
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Product.ProductId.Equals(id)).Product);
           
            return Page();
        }
    }

}