namespace BusinessLayer.ViewModels
{
    public class CBBItem
    {
        public int Value { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
