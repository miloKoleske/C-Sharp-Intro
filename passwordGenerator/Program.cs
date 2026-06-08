//// See https://aka.ms/new-console-template for more information

//using System.Dynamic;

////make an iteration of a random object named res
//Random res = new Random();

////make a string that will be parsed to create a password
//string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~`!@#$%^&*()_-+={[}]|\\:;\"'<,>.?/";

////make an empty pswrd string
//string pswrd = "";

////make a variable that determines the length of the pswrd string
//int size = 16;

////make a for loop that will build the pswrd string for as long as int i is less than size
//for (int i = 0; i < size; i++)
//{
//    //select a random index from the str string
//    int x = res.Next(str.Length);
//    //append character at that index to the pswrd string
//    pswrd = pswrd + str[x];
//}

//// copy the password to the clipboard 
//Console.WriteLine(pswrd);

//--------------------------------------------
//make a password generator using classes and a main function

//using System.Dynamic;

//create variable outside of the method and call them in
//Random rand = new Random();
//string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~`!@#$%^&*()_-+={[}]|\\:;\"'<,>.?/";
//string pswrd = "";
//int size = 16;

//write it with a global function by creating a static method in a namespace
namespace MyNameSpace
{
    public static class GlobalFunctions
    {
        public static Random rand = new Random();
        public static string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~`!@#$%^&*()_-+={[}]|\\:;\"'<,>.?/";
        public static int size = 16;
        public static string pswrd = "";
        public static string GeneratePassword()
        {
            for (int i=0; i<size; i++)
            {
                int x = rand.Next(str.Length);
                pswrd = pswrd + str[x];
            }
            Console.WriteLine(pswrd);
            return pswrd;
        }
        static void Main(string[] args)
        {
            GlobalFunctions.GeneratePassword();
        }
    }
}