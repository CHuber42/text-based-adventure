using System;
using System.Collections.Generic;
using Adventure.Models;

namespace Models
{

  public class Program
  {
    public static void Main()
    {
      //Game initiation/intro
      Console.WriteLine(
@"                     You have stumbled upon a (clearly haunted) house.
                         A voice whispers: 'tell me your name...'
                            
                           /'screw-you' to enable hard mode/");
      Horror game = new Horror(Console.ReadLine(), 0);
      if (game.Name == "screw-you")
      {
        game.Difficulty += 1;
      }
      Random hardMode = new Random();


      //Game Loop
      while (game.Dead == false && game.Escaped == false)
      {
        game.RoomSwitch();
        Console.WriteLine(
@"                               ---------------------------             
                                -------------------------
                         ");
        if (game.Difficulty == 1)
        {
          int squeek = hardMode.Next(1, 10);
          if (squeek == 1)
          {
            Console.WriteLine(
@"                   your surroundings suddenly cave in on you!");
            game.Dead = true;
          }
          else
          {
            Console.WriteLine(
@"                      The entire building creaks ominously...
                          It could collapse at any time..!
                            -----------------------"
            );
          }
        }

      }

      //End of Game
      if (game.Dead == true)
      {
        Console.WriteLine(
@"                            You died. sucks to be you.");
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine(
@"                   You succesfully escaped! With a heavy sigh of relief,
                          you vow never to return to this place.");
        Environment.Exit(0);
      }
    }
  }
}