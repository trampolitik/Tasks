using DbTask;
using DbTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Extensions.Options;
using System.Runtime.Intrinsics.X86;


//Запрос, который был проверен в Managment Studio. 
var request = @" SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT OUTER JOIN ManyToMany
ON Products.Id = ManyToMany.ProductsId
LEFT OUTER JOIN Categories
ON ManyToMany.CategoriesId = Categories.Id";




//using(DbAppContext db = new DbAppContext())
//{
//    db.Database.EnsureDeleted();
//    db.Database.EnsureCreated();

//    var gun = new Product { ProductName = "Пистолет" };
//    var cup = new Product { ProductName = "Чашка" };
//    var book = new Product { ProductName = "Книга" };
//    db.Products.AddRange(gun, cup, book);

//    var toys = new Category { CategoryName = "Игрушки" };
//    var dishes = new Category { CategoryName = "Посуда" };
//    db.Categories.AddRange(toys, dishes);


//    gun.Categories.Add(toys);
//    cup.Categories.Add(dishes);
//    cup.Categories.Add(toys);

//    db.SaveChanges();



//}

Console.WriteLine("work");