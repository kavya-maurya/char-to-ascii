   using System ;
   namespace Project
   {

    //class and object 
    class charToAscii
    { 

        //static method in class is called directly by its name with class name
        public static void start()
        {
            Console.WriteLine("let's convert char to ascii");
            Console.WriteLine(" ");

        }

// to call the object under class we have to put it into variable and call it by variable


//field name is choice

        public void choice ()
        {
            int k = 72;
                int l = 69 ;
                int m = 76 ;
                int n = 79 ;
                int o= 34;
                
                Console.Write( Convert.ToChar(k));    
                Console.Write( Convert.ToChar(l));            
                Console.Write( Convert.ToChar(m));            

                Console.Write( Convert.ToChar(m));            
                Console.Write( Convert.ToChar(n));
                Console.Write( Convert.ToChar(o));      


           
          Console.WriteLine(" ");
          Console.Write("please enter a single character --> ");
        
        
         char j= Convert.ToChar(Console.ReadLine());
         int ascii = Convert.ToInt32(j);
                  Console.WriteLine($"the value of {j} in ascii is {ascii}");


                
        }
    

    }


    

    class Program
    {
        static void Main (string[]args)
        {

        //try-catch-finally is used to identify error

       try 
       {
            charToAscii a = new charToAscii();
          charToAscii.start();
          a.choice();

          
       }

         catch (FormatException e)
       {
        Console.WriteLine("unexpected error : " + e);
        
       }


       catch (Exception d)
       {
        Console.WriteLine("unexpected error : " + d);
        
       }

      
       finally 
       {
        Console.Write(" ~ ");


       }



        }





    }
    

   }