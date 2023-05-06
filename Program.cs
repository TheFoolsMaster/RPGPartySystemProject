namespace VistulaProjekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior hero1 = new Warrior();
            Wizard hero2 = new Wizard();
            Initials hero3 = new Initials();

            Warrior hero4 = new Warrior("Diego",64,12);
            Wizard hero5 = new Wizard("Merlin",12,56,124);
            Initials hero6 = new Initials("Jorg",98,66,43);

            HeroGorup foo = new HeroGorup("Druzyna pierscienia");
            foo.AddMember(hero1, hero2, hero3, hero4, hero5, hero6);

            Console.WriteLine(foo.ToString());
            Console.WriteLine(foo[3].ToString());
            Console.WriteLine(foo[3].HeroStrenght);
            Console.WriteLine(foo[3].HeroHealth);
            Console.WriteLine(foo[3].AttackPower());
            foo[3].ModifyHeroHealth(-61);
            Console.WriteLine(foo.ToString());
            Console.WriteLine(foo[3].ToString());
            Console.WriteLine(foo[3].HeroStrenght);
            Console.WriteLine(foo[3].HeroHealth);
            Console.WriteLine(foo[3].AttackPower());










            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Heros");
            Console.WriteLine(hero1);
            Console.WriteLine(hero2);
            Console.WriteLine(hero3);
            Console.WriteLine(hero4);
            Console.WriteLine(hero5);
            Console.WriteLine(hero6);
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine(hero2);
            Console.WriteLine((Wizard)hero2);
            Console.WriteLine("");
            Console.WriteLine(foo[0].ToString());
            Console.WriteLine(foo[0].ModifyHeroHealth(0));
            Console.WriteLine(foo.ToString());
            Console.WriteLine(foo.GroupAttackInfo());
            Console.WriteLine(foo[0].ToString());


            Console.WriteLine("modifyWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW");
            Console.WriteLine(foo[4].ToString());
            HeroGorup fooClone = (HeroGorup)foo.Clone();
            Console.WriteLine(foo);
            Console.WriteLine(fooClone);
            foo[4].ModifyHeroHealth(+98);
            fooClone[4].HeroName = "Gerwazy";
            Console.WriteLine(fooClone[4].ToString());
            Console.WriteLine(foo[4].ToString());
            Console.WriteLine(foo);
            Console.WriteLine(fooClone);

            Console.WriteLine("");
            fooClone[0].HeroName = "Arn";
            Console.WriteLine(foo[0].ToString());
            Console.WriteLine(fooClone[0].ToString());
            Console.WriteLine("");
            Console.WriteLine(foo.ToString());
            Console.WriteLine(fooClone.ToString());
        }
    }
}