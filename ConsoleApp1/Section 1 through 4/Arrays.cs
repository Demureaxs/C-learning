namespace ConsoleApp1;

public class Arrays
{
    private int number1;
    private int number2;
    private int number3;

    // during declaration if you know the values already for the array you must put 
    // them inside of curly braces after the array initialization
    private int[] Numbers = new int[3] { 1, 2, 3 };

    public void ModifyArray()
    {
        Numbers[0] = 12;
    }
}