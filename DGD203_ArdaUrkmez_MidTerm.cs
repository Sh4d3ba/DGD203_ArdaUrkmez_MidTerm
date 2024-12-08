using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Game!");
        Console.Write("Please enter your name: ");

        string playerName = Console.ReadLine();

        Console.WriteLine($"\nHello, {playerName}! Get ready!\n");

        Console.WriteLine("I have some questions for you!");
        Console.WriteLine("Let's begin with the first one...\n");
        
        string answer1 = "", answer2 = "", answer3 = "", answer4 = "";
        bool validAnswer = false; 
        
        while (!validAnswer)
        {
            Console.WriteLine("Do you think the earth is flat?");
            Console.WriteLine("A. Of course not, I am not an idiot!");
            Console.WriteLine("B. Duh!");
            Console.WriteLine("C. How do I know?");
            
            Console.Write("\nWrite your answer here: ");
            answer1 = Console.ReadLine().ToUpper();

            switch (answer1)
            {
                case "A":
                    Console.WriteLine("\nGood to know.");
                    validAnswer = true;
                    break;
                case "B":
                    Console.WriteLine("\nOK... Let's continue, shall we? (You lost the game from the first one btw)");
                    validAnswer = true;
                    break;
                case "C":
                    Console.WriteLine("\nYou know! Answer again.\n");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter A, B, or C.\n");
                    break;
            }
        }

        Console.WriteLine("\nLet's move on to the next question!\n");
        
        validAnswer = false;
        while (!validAnswer)
        {
            Console.WriteLine("Do you think the pyramids were built by aliens?");
            Console.WriteLine("A. Absolutely not, they were built by humans!");
            Console.WriteLine("B. Yes, aliens are the only explanation!");
            Console.WriteLine("C. I'm not sure, maybe?");
            
            Console.Write("\nWrite your answer here: ");
            answer2 = Console.ReadLine().ToUpper();

            switch (answer2)
            {
                case "A":
                    Console.WriteLine("\nYou're correct! Ancient humans were capable of great feats.");
                    validAnswer = true;
                    break;
                case "B":
                    Console.WriteLine("\nInteresting perspective... But let's give humans some credit!");
                    validAnswer = true;
                    break;
                case "C":
                    Console.WriteLine("\nFair enough. I am going to let it slip this time.");
                    validAnswer = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter A, B, or C.\n");
                    break;
            }
        }

        Console.WriteLine("\nNext question coming up...\n");
        
        validAnswer = false;
        while (!validAnswer)
        {
            Console.WriteLine("Do you think Princess Diana's death was an accident?");
            Console.WriteLine("A. Yes, it was an unfortunate accident.");
            Console.WriteLine("B. No, it was a planned event.");
            Console.WriteLine("C. I'm not sure, it's a mystery.");
            
            Console.Write("\nWrite your answer here: ");
            answer3 = Console.ReadLine().ToUpper();

            switch (answer3)
            {
                case "A":
                    Console.WriteLine("\nA tragic accident indeed.");
                    validAnswer = true;
                    break;
                case "B":
                    Console.WriteLine("\nYou believe it was planned? Interesting perspective.");
                    validAnswer = true;
                    break;
                case "C":
                    Console.WriteLine("\nWhat are you Mr. Indecisive?");
                    validAnswer = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter A, B, or C.\n");
                    break;
            }
        }

        Console.WriteLine("\nFinal question coming up...\n");
        
        validAnswer = false;
        while (!validAnswer)
        {
            Console.WriteLine("Do you think the moon landing was fake?");
            Console.WriteLine("A. No, it was a real achievement!");
            Console.WriteLine("B. Yes, it was all staged, of course.");
            Console.WriteLine("C. I'm not sure, it could go either way in my opinion.");
            
            Console.Write("\nWrite your answer here: ");
            answer4 = Console.ReadLine().ToUpper();

            switch (answer4)
            {
                case "A":
                    Console.WriteLine("\nYou're right! The moon landing is one of humanity's greatest accomplishments.");
                    validAnswer = true;
                    break;
                case "B":
                    Console.WriteLine("\nYou think it was staged? You are one of those jackals huh?");
                    validAnswer = true;
                    break;
                case "C":
                    Console.WriteLine("\nOk, shut the game down at this point, do you know anything about anything?");
                    validAnswer = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter A, B, or C.\n");
                    break;
            }
        }

        //I used AI on the upcoming code 
        
        Console.WriteLine("\nAnalyzing your answers...\n");
        string remark = "";
        
        if (answer1 == "A" && answer4 == "A")
        {
            remark = "You're a person who trusts science and logic. Good for you!";
        }
        else if (answer2 == "B" || answer3 == "B")
        {
            remark = "You seem to have a taste for conspiracy theories. That's fascinating!";
        }
        else if (answer4 == "C")
        {
            remark = "You're open-minded and prefer to keep possibilities open. Admirable!";
        }
        else
        {
            remark = "You have an interesting perspective on these topics. It's always fun to see unique viewpoints!";
        }
        
        Console.WriteLine($"Thank you for playing, {playerName}!\nHere is what i think about you: {remark}");
    }
}
