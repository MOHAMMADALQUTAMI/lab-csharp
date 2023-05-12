   User ahmad = new User();
   ahmad.name="mohammad";
   ahmad.ageInYears=24;

   Console.WriteLine("please enter your name ");
   string name =Console.ReadLine();

   Console.WriteLine("please enter your age in years ");
   int ageInYears = Convert.ToInt32(Console.ReadLine());
   int ageInMonths = ageInYears * 12;
   
    if(ageInYears<12){
       Console.WriteLine("Hello, " + name + "! You are " + ageInMonths + " baby.");
    }
else{
  Console.WriteLine($"Hello, " + name + "! You are " + ageInMonths + " month old.");
}
Console.WriteLine(ahmad.checkAge());
    public class User
    {
      
    public string name {get;set;}
    public int ageInYears { get; set;}

    public bool checkAge(){
       if(ageInYears <= 12)
        {
            return false;
        } 
        else
        {
            return true;
    }
    
        

        
    
        
}
    }
//Console.WriteLine("Plaese Enter your Name");
//string name =Console.ReadLine();

//Console.Write("Enter your age in years: ");
        //int ageInYears = Convert.ToInt32(Console.ReadLine());

        //int ageInMonths = ageInYears * 12;

        //string greeting;
        //if ((ageInYears<12)) {dot
            //greeting = $"Hello young one! You are {ageInMonths} months old.";
        //} else {
          //  greeting = $"Hello! You are {ageInMonths} months old.";
        //}

        //Console.WriteLine(greeting);
    
        
 
