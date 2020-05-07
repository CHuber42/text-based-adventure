using System;


namespace Adventure.Models
{
  public class Horror
  {
    //some attributes
    private int Difficulty;
    public string Name;
    public int PocketKnife { get; set; }
    public int Key { get; set; }
    public int FlashLight { get; set; }
    public bool Dead { get; set; }
    public bool Escaped { get; set; }
    public int RoomID { get; set; }


    public Horror(string playerName, int difficulty)
    {
      Difficulty = difficulty;
      Name = playerName;
      Key = 0;
      FlashLight = 0;
      PocketKnife = 0;
      Escaped = false;
      Dead = false;
      RoomID = 0;
    }

    public void RoomSwitch()
    {
      switch (RoomID)
      {
        case 0:
          FirstRoom();
          break;
        case 1:
          DiningRoom();
          break;
        case 2:
          UpstairsHall();
          break;
        case 3:
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
    }

    public void UpstairsHall()
    {
      Console.WriteLine("Your are standing at the top of the stairs.\nThere is a window in front of you and a door to your left and right.\n ")
    }
  }
}