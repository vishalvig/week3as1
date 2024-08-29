using EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Week3EntityFramework.Dtos;

var context = new IndustryConnectWeek2Context();

var customersWithoutSales = context.Customers
            .Where(c => !context.Sales.Any(s => s.CustomerId == c.Id))
            .ToList();

// Output the results
foreach (var customer in customersWithoutSales)
{
    Console.WriteLine($"Customer without sales: {customer.FirstName} {customer.LastName}");
}

var newCustomer = new Customer
{
    FirstName = "Nihit",
    LastName = "Vig",
    DateOfBirth = DateTime.Now.AddYears(-30) // Example date of birth
};

// Create a new sale
var newSale = new Sale
{
    ProductId = 1, // Replace with actual product ID
    DateSold = DateTime.Now,
    Customer = newCustomer, // Associate the sale with the new customer
    StoreId = 3
};

// Add the customer and sale to the context
context.Customers.Add(newCustomer);
context.Sales.Add(newSale);

// Save changes to the database
context.SaveChanges();

Console.WriteLine("New customer and sale have been added to the database.");

//var store = new Store
//{ };
        
//        Console.WriteLine("Add the new store");
//        Console.WriteLine("Please enter the store name?");
//        store.Name = Console.ReadLine();

//        Console.WriteLine("Please enter the store location?");

//        store.Location = Console.ReadLine();

//Console.WriteLine($"Your new store name and location is {store.Name} {store.Location}");

//Console.WriteLine("Do you want to save this store to the database?");

//var response = Console.ReadLine();

//if (response?.ToLower() == "y")
//{
//    context.Stores.Add(store);
//    context.SaveChanges();
//}

//Find the list of all stores that have sales 

var allstorewithsale = context.Stores
    .Where(s => context.Sales.Any(sa => sa.StoreId == s.Id))
    .ToList();

foreach (var ste in allstorewithsale)
{
    Console.WriteLine($"List of all store with sales: {ste.Name} {ste.Location}");
}


//var customer = new Customer
//{
//    DateOfBirth = DateTime.Now.AddYears(-20)
//};


//Console.WriteLine("Please enter the customer firstname?");

//customer.FirstName = Console.ReadLine();

//Console.WriteLine("Please enter the customer lastname?");

//customer.LastName = Console.ReadLine();


//var customers = context.Customers.ToList();

//foreach (Customer c in customers)
//{   
//    Console.WriteLine("Hello I'm " + c.FirstName);
//}

//Console.WriteLine($"Your new customer is {customer.FirstName} {customer.LastName}");

//Console.WriteLine("Do you want to save this customer to the database?");

//var response = Console.ReadLine();

//if (response?.ToLower() == "y")
//{
//    context.Customers.Add(customer);
//    context.SaveChanges();
//}



//var sales = context.Sales.Include(c => c.Customer)
//   .Include(p => p.Product).ToList();

//var salesDto = new List<SaleDto>();

//foreach (Sale s in sales)
//{
// salesDto.Add(new SaleDto(s));
//}



//context.Sales.Add(new Sale
//{
//    ProductId = 1,
//    CustomerId = 1,
//    StoreId = 1,
//    DateSold = DateTime.Now
//});


//context.SaveChanges();




//Console.WriteLine("Which customer record would you like to update?");

//var response = Convert.ToInt32(Console.ReadLine());

//var customer = context.Customers.Include(s => s.Sales)
//   .ThenInclude(p => p.Product)
//   .FirstOrDefault(c => c.Id == response);


//var total = customer.Sales.Select(s => s.Product.Price).Sum();


//var customerSales = context.CustomerSales.ToList();

//var totalsales = customer.Sales



//Console.WriteLine($"The customer you have retrieved is {customer?.FirstName} {customer?.LastName}");

//Console.WriteLine($"Would you like to updated the firstname? y/n");

//var updateResponse = Console.ReadLine();

//if (updateResponse?.ToLower() == "y")
//{

//    Console.WriteLine($"Please enter the new name");

//    customer.FirstName = Console.ReadLine();
//    context.Customers.Add(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//    context.SaveChanges();
//}



Console.ReadLine();









