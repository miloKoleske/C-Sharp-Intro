// See https://aka.ms/new-console-template for more information

using System.Dynamic;

Random res = new Random();

//make a string that will be parsed to create a password
string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~`!@#$%^&*()_-+={[}]|\\:;\"'<,>.?/";

//make an empty pswrd string
string pswrd = "";

//make a variable that determines the length of the pswrd string
int size = 16;

//make a for loop that will build the pswrd string for as long as int i is less than size
for (int i = 0; i < size; i++) 
{
    //select a random index from the str string
    int x = res.Next(str.Length);
    //append character at that index to the pswrd string
    pswrd = pswrd + str[x];
}

Console.WriteLine(pswrd);