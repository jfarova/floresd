internal class Program
{
    private static void Main(string[] args)
    {
        int num,fac=1;
        Console.WriteLine("ingrese numero");
        num=int.Parse(Console.ReadLine());
        while(num !=0){
            fac = fac * num;
            num=num-1;
        }
        Console.WriteLine("el factorial es: " + fac);
        Console.ReadKey(true);
    }
}