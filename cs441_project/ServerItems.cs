﻿using Xamarin.Forms;
using System;

// items containing data relevant to a certain task
namespace cs441_project
{
    // the object returned from the server
    public class ResponseItem
    {
        public bool Success { get; set; }
        public string Response { get; set; }
        public string Data { get; set; }
    }

    // ask the server to check if email and password are in the database
    public class ValidateUserItem
    {
        public readonly string Command = "VALIDATE_USER"; //every item must have a "Command" data member
        public string Email { get; set; }
        public string Password { get; set; }
    }

    // ask the server to check if email is in database and if it is, email the password
    public class ForgotPasswordItem
    {
        public readonly string Command = "FORGOT_PASSWORD"; //every item must have a "Command" data member
        public string Email { get; set; }
    }

    // ask the server to add a new user
    public class AddUserItem
    {
        public readonly string Command = "ADD_USER"; //every item must have a "Command" data member
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
