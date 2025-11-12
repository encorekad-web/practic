class Program
{
    static void Main()
    {
        Laptop lp = new Laptop("Dell", 16, 85);
        lp.PowerOn(); 
        lp.Work();    
        lp.Ram = 0;   
    }
}