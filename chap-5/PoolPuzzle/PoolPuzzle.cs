class Q
{
    public Q(bool add)
    {
        if (add)
            Op = '+';
        else
            Op = '*';
        
        N1 = R.Next(1, 10);
        N2 = R.Next(1, 10);
    }

    public static Random R = new();
    public int N1 { get; private set; }
    public string Op { get; private set; }
    public int N2 { get; private set; }

    public bool Check(int a)
    {
        if (Op == '+')
            return a == N1 + N2;
        return a == N1 * N2;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Q q = new Q(Q.R.Next(2) == 1);
        while (true) {
            Console.WriteLine($"{q.N1} {q.Op} {q.N2} = ?");
            if (!int.TryParse(Console.ReadLine(), out int a))
                Console.WriteLine("Thanks for playing!");
                return;
            if (q.Check(a))
            {
                Console.WriteLine("Correct!");
                q = new Q(Q.R.Next(2) == 1);
            }
            else Console.WriteLine("Wrong! Try again.");
        }
    }
}