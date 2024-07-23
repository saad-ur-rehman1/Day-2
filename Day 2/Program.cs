// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*string? input =Console.ReadLine();
Console.WriteLine(input);


int age = 98;
string ageString = age.ToString();
*/
/*Console.WriteLine("Enter your age");
string? age= Console.ReadLine();
bool isInput = int.TryParse(age,out int ageint);
if (isInput == true && ageint >= 18)
{
    Console.WriteLine(" you are adult"); }
else {

    Console.WriteLine("you are not adult");
}*/

//Loops
// print 1 to 100 digits
// Startingpoint-condition-increment/decrement

double sum = 0;
for (double start = 1; start <= 100000; start++)
{

    if (start % 2 == 0)
    {
        
        //Console.WriteLine(start++);
        sum += start;
      
    }
   

}
Console.WriteLine(sum);
