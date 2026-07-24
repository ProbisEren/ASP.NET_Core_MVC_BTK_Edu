using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller 
    {


        // Dependency Injection Patterni*
        private readonly RepositoryContext _context; // Benim burada db bağlantısı yapmamam için kendisi yapıyo 
                                                     // bunu zaten biz yazmıştık program.cs'te

        public ProductController (RepositoryContext context)
        {
             _context = context;
        }
        // Dependency Injection Patterni*


        //public IEnumerable <Product> Index(){ return _context.Products; } //böyle de yapabiliriz IACtionResult kullanmadan
                                                                            //  ama bu bize güzel bi görünüm sağlamaz 
                                                                            // sadece düz string olarak görürsün
        public IActionResult Index()
        {
            var model = _context.Products.ToList(); // daha rahat çalışmak için ToList yaptık.
            return View(model);
            
            



                // databaseden çektiğin ama kötü bi çekme şekli
                //var context = new RepositoryContext(// default/boş constructor olmadığı için boş tanımlayamadık
                //    new DbContextOptionsBuilder<RepositoryContext >().UseSqlite("Data Source = ProductDb.db ").Options 

                //); 
            
                //return context.Products;
            

            // return new List<Product>()  KENDİN ELLE YAZDIĞIN 
            //{
            //  new Product(){ProductId= 1, ProductName="elma", ProductPrice=10}  

            //};
        } 


        public IActionResult Get(int id) // ürün getirir
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id)); 
            return View(product);

        }
    }   
}