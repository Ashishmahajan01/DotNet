
using Catalog;
using CRM;
using Membership;
using OrderProcessing;
using ShoppingCart;


//Property Initializer
Product p1=new Product{ Id=12,
                        Title="Gerbera",
                         Description="Wedding Flower",
                         UnitPrice=10,
                         Quantity=56000};

p1.Title="Jasmine";
Console.WriteLine(p1.Id + " "+ p1.Title + " "+ p1.Description);
