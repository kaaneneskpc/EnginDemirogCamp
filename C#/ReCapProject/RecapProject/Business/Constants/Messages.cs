using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Added"; 
        public static string NameInvalid = "Name is Invalid";
        public static string MaintenanceTime="MaintenanceTime";
        public static string Listed="Listed";
        public static string PriceInvalid="Price Invalid";
        public static string Deleted="Deleted";
        public static string Updated="Updated";
        public static string ReturnDateInvalid="Return Date Invalid";
        public static string FailedImageAdd="Image count has max 5";
        public static string AddedImage="Image Added";
        internal static string DeletedImage="Image Deleted";
        public static string AuthorizationDenied = "Authorization is Denied";
        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Succesfully Login";
        public static string UserAlreadyExists = "User has already exists";
        public static string AccessTokenCreated = "Access Token has already created";
    }
}
