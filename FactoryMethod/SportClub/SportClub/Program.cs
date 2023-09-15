

using SportClub.Domain;
using SportClub.Factories;

class Program
{ 
    static void Main()
    {
        string membershipType = "1";

        Console.WriteLine(">>> Welcome to Sport Club CRM <<<");
        do
        {
            Console.WriteLine("> Enter the membership type you would like to create: ");
            Console.WriteLine("");
            Console.WriteLine("> G - Gym");
            Console.WriteLine("> P - Gym + Pool");
            Console.WriteLine("> T - Individual Training");

            membershipType = Console.ReadLine();

            MembershipFactory factory = GetFactory(membershipType);

            if (factory != null)
            {
                IMembership membership = factory.GetMembership();

                Console.WriteLine("\n> Membership you've just created: \n");

                Console.WriteLine(
                    $"\t Name \t\t {membership.Name}\n" +
                    $"\t Price \t\t {membership.GetPrice()}\n" +
                    $"\t Description \t {membership.Description}" +
                    "");
            }
            else
            {
                Console.WriteLine("Invalid membership type. Please enter G, P, or T.");
            }
        } while (membershipType != "0");

        Console.ReadLine();

    }
    private static MembershipFactory GetFactory(string membershipType)
    {
       return membershipType.ToLower() switch
        {
            "g" => new GumMembershipFactory(250, "Gum membership"),
            "p" => new GumPlusPoolMembershipFactory(280, "Gum + Pool membership"),
            "t" => new IndividualTrainingMembershipFactory(490, "Individual Training Membership"),
            _ => null
        };
    }

}
