using System;

public class Inventory {
    

     protected Item[] inventory = new Item[10];
    

    



    public void PickUpItem(String s, int q){

        s = s.ToLower();

        Random r = new Random();

        int freeSpace = 0;

        
            for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                freeSpace = i;
                break;
            }
        }

        bool isSupply = false;
        if(q != 1)
        {

            

            for (int i = 0; i < inventory.Length; i++)
            {
               if (inventory[i] != null && inventory[i].getName().ToLower() == s)
               {
                    freeSpace = i;
                    isSupply = true;
                    break;
               }
            }   

        }

        
        bool validInput = true;

        switch (s)
        {
            case "food":

                inventory[freeSpace] = new Food(r.Next(1, 5), r.Next(1, 10) * 5);
            break;

            case "sword":

                inventory[freeSpace] =  new Sword(r.Next(1,8));

            break;

            case "axe":

                inventory[freeSpace] =  new Axe(r.Next(1,8));
            break;

            case "pickaxe":


                inventory[freeSpace] =  new Pickaxe(r.Next(1,8));
            break;

            case "coins":
                if (isSupply)
                {
                    inventory[freeSpace].Add(q);
                    break;
                }
                
                inventory[freeSpace] = new Coins(q);
            break;

            case "iron":

                if (isSupply)
                {
                    inventory[freeSpace].Add(q);
                    break;
                }

                inventory[freeSpace] = new Iron(q);
            break;

            case "stone":

                if (isSupply)
                {
                    inventory[freeSpace].Add(q);
                    break;
                }

                inventory[freeSpace] = new Stone(q);
            break;

            case "wood":

                if (isSupply)
                {
                    inventory[freeSpace].Add(q);
                    break;
                }

                inventory[freeSpace] = new Wood(q);
            break;
            

            
            default: Console.WriteLine("no such item exists");

            validInput = false;

            break;
        }

        if (validInput)
        {   
            Console.WriteLine($"{s} picked up");
        }
        

    }

   public void TrowAwayItem(int id, int q){


    id = id -1;

        if(inventory[id ] != null){

             String Item = inventory[id].getName().ToLower();

            if (Item == "coins" || Item == "iron" || Item == "wood" || Item == "stone" )
            {
                inventory[id].Take(q);
                if (inventory[id].GetQuantity() <= 0)
                {
                    inventory[id] = null;   
                }
            }
            else
            {
                inventory[id] = null;
            }

            Console.WriteLine($"{Item} trowed away");
        }
        else
        {
            Console.WriteLine("Slot is already empty");
        }


   }

   public void GetItemInfo(int slot){

    if (inventory[slot - 1] != null)
    {
         inventory[slot - 1].ItemSpecifics();
    }
    else
    {
        Console.WriteLine("Place in inventory is empty");
    }
   
   }

    public void ShowInventory(){


        for (int i = 0; i < 10; i++)
        {
            if (inventory[i] != null)
            {
                 Console.WriteLine($"| {i + 1}.  {inventory[i]}  |");
            }
            else
            {
                 Console.WriteLine($"| {i + 1}.   -   |");
            }
          
            
        }



    }

   

}