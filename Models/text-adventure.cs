using System;


namespace Adventure.Models
{
  public class Horror
  {
    //some attributes
    public int Difficulty { get; set; }
    public string Name;

    public bool Key { get; set; }

    public bool Dead { get; set; }
    public bool Escaped { get; set; }
    public int RoomID { get; set; }
    public bool BathroomDoor { get; set; }
    public bool Ghost { get; set; }


    public Horror(string playerName, int difficulty)
    {
      Difficulty = difficulty;
      Name = playerName;
      Key = false;
      Escaped = false;
      Dead = false;
      RoomID = 0;
      BathroomDoor = false;
      Ghost = false;
    }

    public void RoomSwitch()
    {
      switch (RoomID)
      {
        //Antechamber
        case 0:
          FirstRoom();
          break;
        //Dining Room
        case 1:
          DiningRoom();
          break;
        //Upstairs Hall
        case 2:
          UpstairsHall();
          break;
        //Kitchen
        case 3:
          Kitchen();
          break;
        //PuzzleRoom
        case 4:
          PuzzleRoom();
          break;
        case 5:
          Window();
          break;
        case 6:
          break;
        case 7:
          break;
        case 8:
          break;
      }
    }
    public void FirstRoom()
    {
      Console.WriteLine(
@"                          You are standing in the main antechamber.

                           1. Go in Dining Room 2. Go Upstairs");
      int userInput = int.Parse(Console.ReadLine());
      switch (userInput)
      {
        case 1:
          RoomID = 1;
          break;
        case 2:
          RoomID = 2;
          break;
      }
    }

    public void DiningRoom()
    {
      Console.WriteLine(
@"                   You are standing in the Dining Room. It's spooky in here.");
      if (Key == false && BathroomDoor == true)
      {
        Console.WriteLine(
@"                      You see a Key on the table you didn't notice before.
                                Would you like to take it?
                                  
                                    [Y]es or [N]o?");
        switch (Console.ReadLine().ToLower())
        {
          case "y":
            Key = true;
            Console.WriteLine(
@"               
                                        /- -\ ______________     
                                       | ( ) |_____   _   __|
                                        \- -/      | | | |_
                                                  |_| |_ _|   
                                                      ");
            break;
          default:
            break;
        }
      }
      Console.WriteLine(
@"                                There are two doors in the room.
            
                                1. Kitchen 2. Bathroom
                                3. Return to Antechamber");

      switch (Console.ReadLine())
      {
        case "1":
          RoomID = 3;
          break;
        case "2":
          Console.WriteLine(
@"                      The door handle rattles but the door refuses to open.");
          RoomID = 1;
          BathroomDoor = true;
          break;
        case "3":
          RoomID = 0;
          break;
      }
    }


    public void Kitchen()
    {
      Console.WriteLine(
@"                            The kitchen is dark and dank.
                     The long decayed remains of elaborate feasts fill the air
                       with a smell so putrid, that you die instantly.
                                          RIP");
      Dead = true;
    }
    public void UpstairsHall()
    {
      Console.WriteLine(
@"                        You are standing at the top of the stairs.
                    There is a window in front of you and a door to your left and right.
                          
                      1.Try the door on the left  2.Try the door on the right
                          3.Go to the window  4.Return to Antechamber");
      switch (Console.ReadLine())
      {
        case "1":
          if (Key)
          {
            MagicDoor();
          }
          else
          {
            Console.WriteLine(
@"                You try to open the door, but it appears to be deadbolted shut. 
                                      You might need a key.");
          }
          break;
        case "2":
          RoomID = 4;
          break;
        case "3":
          RoomID = 5;
          break;
        case "4":
          RoomID = 0;
          break;
        default:
          break;
      }
    }

    public void Window()
    {
      Console.WriteLine(
@"                  
                            ==================================
                            ||         ######    ######        ||
                            ||       ########    ########      ||
                            ||       #####   __   __ ####      ||
                            ||       #####   \|  |/   ###      ||
                            ||       ####            ####      ||
                            ||       #####    \___/   ###      ||
                            ||         |####       ####|       || 
                            ||         | ______________|       ||
                            ||         /                \      ||
                            ||         |  Christie-bear |      ||
                            ||         \________________/      || 
                            ==================================               
              
                        You see a picture frame with a little girl in it.
                              Beneath the photo is simply written: 
                                        Christie-bear
                                        
                          Press any button to go back to the top of the stairs.      ");

      RoomID = 2;
      Console.ReadLine();
    }
    public void PuzzleRoom()
    {
      if (!Ghost)
      {
        Ghost = true;
        Console.WriteLine(
@"                        You hear some eery breathing coming from up above
                    As you look up, you feel a pair of tiny hands slip around your throat...
                                    ~I CAN'T REMEMBER MY NAME~
                                    ~PLEASE TELL ME MY NAME~ : ");
        switch (Console.ReadLine())
        {
          case "Christie-bear":
            Console.WriteLine(
@"                                    The ghost softly whispers:
                                'Oh. Thank you for reminding me...! :Giggle:...
                   With a smile she fades away, and you stumble back out into the hallway.");

            RoomID = 2;
            break;
          default:
            Console.WriteLine(
@"              As you rack your brain for what this tiny spectre's name could possibly be, 
                      your vision slowly fades and the last thing you hear is...
                                       'get rekt m8'");
            Dead = true;
            break;
        }
      }
      else
      {
        Console.WriteLine(
@"                The room is filled with a child's possessions: a small bed, toys, stuffed animals.
     Much of the floor has rotted away; a fallen-through floorboard gives you access to the Dining Room below.
                           
                   1. Jump down to the Dining Room 2. Return to the hallway");
        switch (Console.ReadLine())
        {
          case "1":
            RoomID = 1;
            break;
          case "2":
            RoomID = 2;
            break;
        }
      }

    }
    public void MagicDoor()
    {
      Console.WriteLine("You emerge out onto the surface.");
      Escaped = true;
    }
  }
}