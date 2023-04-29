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
            foo.AddMember(hero1);
            foo.AddMember(hero2);
            foo.AddMember(hero3);
            foo.AddMember(hero4);
            foo.AddMember(hero5);
            foo.AddMember(hero6);
            Console.WriteLine(foo[0].ToString());
            Console.WriteLine(foo[0].ModifyHeroHealth(0));
            Console.WriteLine(foo.ToString());
            Console.WriteLine(foo.AllAttackInfo());
            Console.WriteLine(foo[0].ToString());


            Console.WriteLine(  );
            Console.WriteLine(foo[0].ToString());
            HeroGorup fooClone = (HeroGorup)foo.Clone();
            fooClone[0].HeroName = "Gerwazy";
            Console.WriteLine(fooClone[0].ToString());

            fooClone[0].HeroName = "Arn";
            Console.WriteLine(foo[0].ToString());
            Console.WriteLine(fooClone[0].ToString());
            Console.WriteLine(  );
            Console.WriteLine(foo.ToString());
            Console.WriteLine(fooClone.ToString());



            foo.lootest = 4214;
            Console.WriteLine(foo.lootest);
            Console.WriteLine(fooClone.lootest);
        }
    }
}