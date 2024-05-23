//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");

Dictionary<string, double> students = new Dictionary<string, double>();
string newStudent;

do
{
   Console.WriteLine("Student: ");
   string input = Console.ReadLine();
   newStudent = input;

   if (!Equals(newStudent, "")) {
      Console.WriteLine("Id: ");
      input = Console.ReadLine();
      double newId = double.Parse(input);
      students.Add(newStudent, newId);

      // Read in the newline before looping back
      Console.ReadLine();
   }

} while(!Equals(newStudent, ""));

// Print class roster
Console.WriteLine("\nClass roster:");
double sum = 0.0;

foreach (KeyValuePair<string, double> student in students) {
   Console.WriteLine(student.Key + " (" + student.Value + ")");
   sum += student.Value;
}

// double avg = sum / students.Count;
// Console.WriteLine("Average grade: " + avg);