namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fyrkant fyrkant = new Fyrkant();
            Rektangel rektangel = new Rektangel();
            Circle circle = new Circle();
            Parallellogram logram = new Parallellogram();
            Ellips ellips = new Ellips();

            Console.WriteLine($"The area of the square is: {fyrkant.Area()}");
            Console.WriteLine($"The area of the rectangel is: {rektangel.Area()}");
            Console.WriteLine($"The area of the circle is: {circle.Area()}");
            Console.WriteLine($"The area of the parallellogram is: {logram.Area()}");
            Console.WriteLine($"The area of the ellipse is: {ellips.Area()}");









        }
    }
}