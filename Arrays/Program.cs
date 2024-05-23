//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

Console.WriteLine("Hello, Arrays!");

int[] intarr = [1,4,2,5];

foreach( int num in intarr){
    if(num % 2 == 0){
        
        Console.WriteLine(num);

    }
}

string testString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

string[] splitUpString = testString.Split(" ");

foreach( string split in splitUpString){
    Console.WriteLine(split);
}