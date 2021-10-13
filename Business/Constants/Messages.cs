using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        internal static string BrandAdded = "New Brand Added!";
        internal static string BrandDeleted = "Brand Deleted";
        internal static string BrandUpdated = "Brand Update";
        internal static string BrandListed = "Brand Listed";
        internal static List<Brand> MaintainanceTimeBrand;

        internal static string CarAdded = "New Car Added!";
        internal static string CarDeleted = "Car Deleted";
        internal static string CarNameInvalid = "Invalid Car Name";
        internal static string CarUpdated = "Car updated";
        internal static string CarListed = "Cars listed succesfully";
        internal static List<Car> MaintainanceTimeCar;

        internal static string ColorAdded = "New Color Added!";
        internal static string ColorDeleted = "Color Deleted";
        internal static string ColorUpdated = "Color Updated";
        internal static string ColorsListed = "Colors Listed";
        internal static string MaintainanceTimeColor;
        
        internal static string CustomerAdded = "New Customer Added";
        internal static string CustomerDeleted = "Customer Deleted";
        internal static string CustomerUpdated = "Customer Updated";
        internal static string CarsListedForCustomers = "Customers Listed";
        internal static List<Customer> MaintainanceTimeCustomer;
        
        internal static string UserAdded = "New User Added";
        internal static string UserDeleted = "User Deleted";
        internal static string UserUpdated = "User Updated";
        internal static string InformationsCantBeEmpty = "Informations cannot be left blank. Please enter the required information.";
        internal static string UserListed = "User Listed";
        internal static List<User> MaintainanceTimeUser;

        internal static string RentInfoAdded = "Rents Info Added";
        internal static string RentInfoDeleted = "Rents Info Deleted";
        internal static string RentInfoUpdated = "Rent Info Updated";
        internal static string RentCarListed = "Rental cars are listed ";
        internal static string RentUnavaible ="Car cant be rent,Pleas select others";
        internal static string MaintainanceTimerRent;
    }
}
