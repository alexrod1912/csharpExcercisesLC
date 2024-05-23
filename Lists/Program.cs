//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");

List <int> nums = new List<int> {1,4,2,5,3,6,7,9,2,3};

int sum; 
sum = 0;
foreach(int num in nums){
    sum = sum + num;
}

Console.WriteLine(sum);

List <string> words = new List<string> {"cat", "cats", "kitten", "catss"};

Console.WriteLine("Please insert a length for word: ");
string userNumString = Console.ReadLine();
int userNum = int.Parse(userNumString);
foreach (string word in words){
    if(word.Length == userNum){
        Console.WriteLine("The list has this word: " + word + " that is " + userNum + " characters long");
    }

}
// Console.WriteLine(userNum);