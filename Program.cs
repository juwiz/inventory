using System;

public class Program {

     static void Main(){

        
        Control c = new Control();

        while (true)
        {
            String? s = Console.ReadLine();
            if(s != null){
                c.Commands(s);

            }
        }

    }
}


