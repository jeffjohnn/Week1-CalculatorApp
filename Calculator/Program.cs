// This integer variable stores the first number. 
// Ask the user to input the first number. 
Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// This integer variable stores the second number. 
// Ask the user to input the second number. 
Console.WriteLine("Type in the second number followed by the Enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Perform the caluculation
int result = firstNumber + secondNumber;

// Output the result
Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);

