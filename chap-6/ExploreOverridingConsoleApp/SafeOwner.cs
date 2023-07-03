namespace ExploreOverridingConsoleApp
{
    internal class SafeOwner
    {
        private string valueables = "";

        public void ReceiveContents(string safeContents)
        {
            valueables = safeContents;
            Console.WriteLine($"Thank you for returning my {valueables}!");
        }
    }
}