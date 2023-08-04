using System;


 class Food : Item{

    


    private int quality;
    private float timeTillRot;

    public Food(int q, float t){
        itemType = typeof(Food);
        quality = q;
        timeTillRot = t;
    }

    public void Rot(){
        this.timeTillRot -= 1;
    }

    public override void ItemSpecifics (){
        Console.WriteLine($"{name}\nType: {itemType}\nQuality: {quality}\nRots in {timeTillRot} min");
     }

    

}