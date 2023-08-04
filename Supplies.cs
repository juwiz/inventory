using System;

public class Supplies : Item {
    
    

     public override void ItemSpecifics(){
            Console.WriteLine($"{name}\nQuantity: {quantity}");
    }

   

   
}

public class Wood : Supplies{

    public Wood(int q){
        quantity = q;
        name = "Wood";
    }

}

public class Stone : Supplies{

    public Stone(int q){
        quantity = q;
        name = "Stone";
    }

}

public class Iron : Supplies{

    public Iron(int q){
        quantity = q;
        name = "Iron";
    }

}

public class Coins : Supplies {
    
    public Coins(int q){
        quantity  = q;
        name = "Coins";
    }

    
}