// See https://aka.ms/new-console-template for more information
using static Members;

var member1 = new Members();
member1.firstName = "BILBO";
member1.lastName = "BAGGINS";
member1.favoriteBook = "The Hobbit";

var member2 = new Members();
member2.firstName = "GANDALF";
member2.lastName = "THE GREY";
member2.favoriteBook = "The Lord of the Rings";

var member3 = new Members();
member3.firstName = "SMEAGOL";
member3.lastName = "AKA GOLLUM";
member3.favoriteBook = "American Psycho";

var membersList = new List<Members> { member1, member2, member3 };

var recommendedBook1 = new BookRecommendation();
recommendedBook1.title = "TOOLS OF TITANS";
recommendedBook1.author = "TIM FERRIS";

var recommendedBook2 = new BookRecommendation();
recommendedBook2.title = "NEVER SPLIT THE DIFFERENCE";
recommendedBook2.author = "CHRIS VOSS";


var recommendedBook3 = new BookRecommendation();
recommendedBook3.title = "CANT HURT ME";
recommendedBook3.author = "DAVID GOGGINS";

var recommendationList = new List<BookRecommendation> { recommendedBook1, recommendedBook2, recommendedBook3 };

 WelcomeMessage(); //why is the method not working here? :( 
 GiveInstructions(); //why is the method not working here? :( 

while (true)
{
   var userInput = 0;
   Console.WriteLine("Which option would you like to execute? Please enter the number."); 
   int.TryParse(Console.ReadLine(), out userInput);

if (userInput == 0) 
    {
        break;     
    }

switch (userInput)
{
    case 1:   
     Console.WriteLine("You have entered 1, here is a list of members in the Book Club.\n");
    
     foreach (var member in membersList)
     {
       member.DisplayMemberDetails();
     }
     break;
    
     case 2:   
      Console.WriteLine("You have entered 2, here is the recommended reading list from the Book Club.\n");
    
     foreach (var recommendedBook in recommendationList)
     {
       recommendedBook.DisplayBookRecommendation();
     }
     break;

     case 3: 
       var addingMember = true;

      while(addingMember)
      {
      Console.WriteLine("Option 3, please enter the name of the person you would like to add to the Book Club.\n"); 
      membersList.Add(Console.ReadLine().Trim().ToUpper()); // how to add to memberlist when the fields are different?
      
      Console.WriteLine("Would you like to enrol another? Enter Y or N.\n"); 

      if (Console.ReadLine().ToUpper() != "Y") 
      
      addingMember = false;  
      }
      break;

     default:
       ErrorMessageWrongInput();
       Console.WriteLine(" ");
       GiveInstructions();
      break;
}

static void WelcomeMessage()
{
 Console.WriteLine("Welcome to the Maroubra Book Club 🐱📖📖📖🐱.");
 Console.WriteLine("Here you will be able to choose from the following options:\n");  
}

static void GiveInstructions()
{
 Console.WriteLine("1 = Press 1 to see the members of the Book Club.");
 Console.WriteLine("2 = Press 2 to see the Recommended Reading List");
 Console.WriteLine("3 = Press 3 to add a member to the Book Club.");
 Console.WriteLine("4 = Press 4 to add a book to the Recommended Reading List");
 Console.WriteLine("5 = Press 5 to add a book to the favorite Reading List of a member");
 Console.WriteLine("0 = Exit");
 Console.WriteLine(""); 
}

static void ErrorMessageWrongInput()
{
    Console.WriteLine("Sorry, that was an incorrect input. Please look at the options again."); 
}
}
public class Members
{

    public string firstName;

    public string lastName;

    public string favoriteBook;
    public void DisplayMemberDetails()
    {
        Console.WriteLine($"\tMember Name: {firstName} {lastName} Favorite Book: {favoriteBook}\n");
    }
public class BookRecommendation
{
    public string title;
    public string author;
    public void DisplayBookRecommendation()
    {
        //return $"\t{title}, {author}";
        Console.WriteLine($"\tBook Recommendation Title: {title} Author: {author}\n");
    }
}
}

