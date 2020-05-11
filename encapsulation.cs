using System;

namespace encapsulation{
    class User{
              private string username;
              private string password;
              public string MyUsername { //accessors
                  get {
                      return username;
                  } set {
                      username = value;
                  }
              }  
              public string MyPassword { //accessor
                  get{
                      return password;
                  } set {
                      password = value;
                  }
              }
            }
    class Program{ 
        static void Main(string[] args){
            User myUser = new User();
            myUser.MyUsername = "jsmith";
            myUser.MyPassword = "password";
            Console.WriteLine("Username: " + myUser.MyUsername);
            string myOutput = myUser.MyPassword;
            // Console.WriteLine(myOutput);
            Console.WriteLine("Password: " + myUser.MyPassword);
        }
    }
}
