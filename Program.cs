// Jacob Dekok
// 10/17/2022
// Git Hub Transfer - Mini Challenge #6 Even or Odd
// This is a console project that will determine if
// a number is even or odd

Console.Clear();


string playAgain = "YES";

while(playAgain == "YES"){

string num;
bool isConverted = false;
bool isNumber;
int validNum = 0;


while(!isConverted){

    Console.Write("Please enter a whole number: ");
    num = Console.ReadLine();

    isNumber = Int32.TryParse(num, out validNum);

    if(isNumber == true){
        isConverted = true;
    }else{
        Console.WriteLine("Invalid entry, please try again.");
    }
}

if(validNum%2 == 0){
    Console.WriteLine(validNum + " is an even number.");
}else if(validNum%2 == 1){
    Console.WriteLine(validNum + " is an odd number.");
}else{
    Console.WriteLine("How did you fuck up this bad?");
}

Console.WriteLine("Would you like to give me another number? 'YES' 'NO'");
playAgain = Console.ReadLine().ToUpper();

if(playAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (playAgain != "YES" && playAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }

}