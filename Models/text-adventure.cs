using System;


namespace Adventure.Models
{
  public class Horror
  {
    //some attributes
    private int Difficulty;
    public string Name;
    public bool PocketKnife { get; set; }
    public bool Key { get; set; }
    public bool FlashLight { get; set; }
    public bool Dead { get; set; }
    public bool Escaped { get; set; }
    public int RoomID { get; set; }
    public bool BathroomDoor { get; set; }


    public Horror(string playerName, int difficulty)
    {
      Difficulty = difficulty;
      Name = playerName;
      Key = false;
      FlashLight = false;
      PocketKnife = false;
      Escaped = false;
      Dead = false;
      RoomID = 0;
      BathroomDoor = false;
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
        case 4:
          break;
        case 5:
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
      Console.WriteLine("You are standing in the main antechamber.\n1. Go in Dining Room\n2. Go Upstairs");
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
      Console.WriteLine("You are standing in the Dining Room. Spooky.");
      if (Key == false && BathroomDoor == true)
      {
        Console.WriteLine("You see a Key on the table you didn't notice before. Would you like to take it? [Y]es or [N]o?");
        switch (Console.ReadLine().ToLower())
        {
          case "y":
            Key = true;
            break;
          default:
            break;
        }
      }
      Console.WriteLine("There are two doors in the room. \n1. Kitchen\n2. Bathroom\n3. Return to Antechamber");

      switch (Console.ReadLine())
      {
        case "1":
          RoomID = 3;
          break;
        case "2":
          Console.WriteLine("The door handle rattles but the door refuses to open.");
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
      Console.WriteLine("The kitchen is dark and dank. The long decayed remains of elaborate feasts have filled the air with a smell so putrid, that you die instantly.\n RIP");
      Dead = true;
    }
    public void UpstairsHall()
    {
      Console.WriteLine("Your are standing at the top of the stairs.\nThere is a window in front of you and a door to your left and right.");
      Console.WriteLine("1. Try the door on the left \n2. Try the door on the right\n3. Go to the window\n4. Return to antechamber");
      switch (Console.ReadLine())
      {
        case "1":
          break;
        case "2":
          break;
        case "3":
          break;
        case "4":
          RoomID = 0;
          break;
        default:
          break;
      }
    }

    public void MagicDoor()
    {
      Console.WriteLine("You emerge out onto the surface.");
      Escaped = true;
    }
  }
}