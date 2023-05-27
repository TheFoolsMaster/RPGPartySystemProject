namespace RPGPartySystemProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior hero1 = new Warrior();
            Wizard hero2 = new Wizard();
            JP hero3 = new JP();

            Warrior hero4 = new Warrior("Diego",64,12);
            Wizard hero5 = new Wizard("Merlin",12,56,124);
            JP hero6 = new JP("Jorg",98,66,43);

            HeroGorup foo = new HeroGorup("Druzyna pierscienia");
            foo.AddMember(hero1, hero2, hero3, hero4, hero5, hero6);

            foo[3].ModifyHeroHealth(-61);
            Console.WriteLine(foo.ToString());
        }
    }
}