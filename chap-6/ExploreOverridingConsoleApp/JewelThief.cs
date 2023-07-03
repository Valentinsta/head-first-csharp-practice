namespace ExploreOverridingConsoleApp
{
    internal class JewelThief: Locksmith
    {
        private string stolenJewels;
        public override void ReturnContents(string safeContents, SafeOwner safeOwner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"I'm stealing the jewels! I stole: {stolenJewels}");
        }
    }
}