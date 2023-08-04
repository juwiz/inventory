using System;



public class Control {
    
    Inventory inv = new Inventory();
    public void Commands(String s){

        String [] sa = s.Split("-");

        switch (sa[0])
        {
            case "help": case "h":

               Console.WriteLine("pickup-object-quantity  → picks up specific item and adds it to inventory\ntrow-inventoryid-quantity  → trows away item in specific inventory slot\ninventory → writes out inventory\nitem-inventoryid → writes out specifics of item\nitemlist -> list of possible items");

            break;

            case "pickup":

                if(sa.Length == 3 && int.TryParse(sa[2], out _))
                {

                    inv.PickUpItem(sa[1],  int.Parse(sa[2]));
                }
                else{
                    Error();
                }



            break;

            case "trow":

             if(sa.Length == 3 && int.TryParse(sa[1], out _) && int.TryParse(sa[2], out _))
                {

                    inv.TrowAwayItem(int.Parse(sa[1]),  int.Parse(sa[2]));
                }
                else{
                    Error();
                }

            break;

            case "inventory":

                if (sa.Length == 1)
                {
                    inv.ShowInventory();
                }
                else
                {
                    Error();
                }
                

            break;

            case "item":

                if (sa.Length == 2 && int.TryParse(sa[1], out _))
                {
                 inv.GetItemInfo(int.Parse(sa[1]));   
                }else
                {
                    
                }

            break;

            case "itemlist":
                Console.WriteLine("Food\nSword\nAxe\nPickaxe\nWood\nIron\nStone\nCoins");

            break;

            case "end":
            Environment.Exit(0);
            break;


            
            default:  Console.WriteLine("Unknown command");
            break;
        }


    }

    public void Error(){

        Console.WriteLine("Wrong command");

    }

}