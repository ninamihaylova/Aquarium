class Aquarium {
    public static void Main (String[]args)
    {

        int lengthAquarium = int.Parse(Console.ReadLine());
        int widthAquarium=int.Parse(Console.ReadLine());
        int heightAquarium=int.Parse(Console.ReadLine());
        double percent=double.Parse(Console.ReadLine());

        double totalLitters=(lengthAquarium*widthAquarium*heightAquarium)*0.001;
        double littersNeeded=totalLitters*(1-percent/100);
        Console.WriteLine($"{littersNeeded:F2}");
        
    }
}