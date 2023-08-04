using System;

public 
 class Item {
    
    protected string name = "";

   
    public Type? itemType; 
    
   public void setName(String n){
        name = n;
   }
   public String getName(){
    return name;
   }

   public virtual void ItemSpecifics(){
      
   }


   protected int quantity;
    public void Add(int n){
        quantity += n;
    }
    public void Take(int n){
        quantity -= n;
    }

   

    public int GetQuantity(){
        return quantity;
    }
    

}