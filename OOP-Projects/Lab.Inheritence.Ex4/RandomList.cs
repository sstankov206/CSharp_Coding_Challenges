namespace Lab.Inheritence.Ex4
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            return this.ElementAt(new Random().Next(this.Count));
        }

        public new void Add(string value)
        {
            base.Insert(new Random().Next(this.Count), value);
        }

        public void Remove()
        {
            base.RemoveAt(new Random().Next(this.Count));
        }
    }
}
