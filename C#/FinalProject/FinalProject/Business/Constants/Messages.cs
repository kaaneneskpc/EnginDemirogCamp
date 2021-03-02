using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added"; 
        public static string ProductNameInvalid = "Product Name is Invalid";
        public static string MaintenanceTime="MaintenanceTime";
        public static string ProductsListed="Product is Listed";
        public static string UnitPriceInvalid="Price is Invalid";

        public static string ProductCountOfCategoryError = "Category must have to max 10 products";

        public static string ProductNameAlreadyExists = "Product Name has already exists";
        public static string CategoryLimitExceded = "Category Limit Exceded";
        public static string AuthorizationDenied= "Authorization is Denied";
        public static string UserRegistered="User Registered";
        public static string UserNotFound="User Not Found";
        public static string PasswordError="Password Error";
        public static string SuccessfulLogin="Succesfully Login";
        public static string UserAlreadyExists="User has already exists";
        public static string AccessTokenCreated="Access Token has already created";
    }
}
