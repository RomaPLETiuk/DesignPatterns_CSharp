namespace SportClub.Domain
{
    internal class GumPlusPoolMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GumPlusPoolMembership(decimal price)
        {
            _price = price;
            _name = "Gum + Pool membership";

        }
        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
