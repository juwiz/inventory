using System;

 class Tool : Item {
    
    protected int durability;
    protected int rarity;

    protected int strengh = 1;
    //public Type type;

    public void Use(){
        durability -= strengh;
        Console.WriteLine($"gained {strengh} items");
    }
    public override void ItemSpecifics (){
        Console.WriteLine($"{name}\nType: {itemType}\nStrengh: {strengh}\nDurability: {durability}\nRarity:{rarity}");
    }
}


  class Sword : Tool {

    public Sword(int r){
        rarity = r;
        name = "Sword";
        durability = 50 * rarity;
        strengh*=rarity;
        itemType = typeof(Sword);
        
      
    }
}


class Axe : Tool {

    public Axe(int r){
       rarity = r;
       name = "Axe";
        durability = 75 * rarity;
        strengh*=rarity;
        itemType = typeof(Axe);
        
      
    }
}

class Pickaxe : Tool {

    public Pickaxe(int r){
       
       rarity = r;
       name = "Pickaxe";
        durability = 100 * rarity;
        strengh*=rarity;
        itemType = typeof(Pickaxe);
      
    }
}







