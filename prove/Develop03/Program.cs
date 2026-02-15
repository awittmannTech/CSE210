using System;

class Program
{
    static void Main(string[] args)
    {

        string userResponse = "play";
        int scriptureIndex = 0;
        List<Scripture> scriptureList = new List<Scripture>();

        Reference reference1 = new Reference("Alma", "41", "10");
        scriptureList.Add(new Scripture(reference1, "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness."));
        
        Reference reference2 = new Reference("1 Nephi", "1", "1");
        scriptureList.Add(new Scripture(reference2, "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days."));
        
        Reference reference3 = new Reference("Luke", "11", "11-13");
        scriptureList.Add(new Scripture(reference3, "11 If a son shall ask bread of any of you that is a father, will he give him a stone? or if he ask a fish, will he for a fish give him a serpent? \n12 Or if he shall ask an egg, will he offer him a scorpion? \n13 If ye then, being evil, know how to give good gifts unto your children: how much more shall your heavenly Father give the Holy Spirit to them that ask him?"));


        do {
            scriptureList[scriptureIndex].Display();

            Console.WriteLine("Press enter to continue or type quit to finish: ");
            userResponse = Console.ReadLine();

            

        } while (userResponse != "quit");

        Console.WriteLine("Goodbye!");
    }
}