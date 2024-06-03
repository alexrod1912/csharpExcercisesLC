// --------- Divide By Zero! ----------


static double Divide(double x, double y)
{
     if (y == 0.0)
      {
         throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
      }
      else
      {
         Console.WriteLine(x/y);
         return x / y;
      }
}


// Test out your Divide() function here!
    // Divide(7, 1);

// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    if(fileName == null || fileName == ""){
        throw new ArgumentNullException("filename", "Filename cannot be null");
    }
    else {
        if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
         {
            Console.WriteLine("1");
            return 1;
         }
         else
         {
            Console.WriteLine("0");
            return 0;
         }
    }
}


// Test out your CheckFileExtension() function here!



Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Elizabeth", "MyCode");
students.Add("Brad", "");

foreach (var student in students)
{
    CheckFileExtension(student.Value);
}


