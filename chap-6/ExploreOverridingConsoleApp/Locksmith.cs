namespace ExploreOverridingConsoleApp
{
    internal class Locksmith
    {
        public string Combination { get; set; }
        
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this);
            string contents = safe.Open(Combination);
            ReturnContents(contents, owner);
        }

        public virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}