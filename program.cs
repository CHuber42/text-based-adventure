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
      Console.WriteLine("You have stumbled upon a (clearly haunted) house.\nA voice whispers: 'tell me your name...'");
      Horror game = new Horror(Console.ReadLine(), 0);

      //Game Loop
      while (game.Dead == false && game.Escaped == false)
      {
        game.RoomSwitch();
      }

      //End of Game
      if (game.Dead == true)
      {
        Console.WriteLine("You died, sucks to be you");
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("You succesfully escaped! With a heavy sigh of relief, you vow never to return to this place.");
        Environment.Exit(0);
      }
    }
  }
}