//Student Name
string firstname = "Sophia";
string lastname = "Johnson";
string fullname = $"{firstname} {lastname}";

//Courses informations
string course1name = "English 101";
string course2name = "Algebra 101";
string course3name = "Biology 101";
string course4name = "Computer Science 101";
string course5name = "Psychology 101";

int course1credits = 3;
int course2credits = 3;
int course3credits = 4;
int course4credits = 4;
int course5credits = 3;

int gradeA = 4;
int gradeB = 3;

int course1grade = gradeA; // A
int course2grade = gradeB; // B
int course3grade = gradeB; // B
int course4grade = gradeB; // B
int course5grade = gradeA; // A

// Calculate total credits and total grade points
int totalCreditHours = 0;
totalCreditHours += course1credits;
totalCreditHours += course2credits;
totalCreditHours += course3credits;
totalCreditHours += course4credits;
totalCreditHours += course5credits;

int totalgradepoints = 0;
totalgradepoints += course1credits * course1grade;
totalgradepoints += course2credits * course2grade;
totalgradepoints += course3credits * course3grade;
totalgradepoints += course4credits * course4grade;
totalgradepoints += course5credits * course5grade;

decimal gradepointaverage = (decimal)totalgradepoints / totalCreditHours;

int leadinigDigit = (int)gradepointaverage;
int firstdigit = (int)(gradepointaverage * 10) % 10;
int seconddigit = (int)(gradepointaverage * 100) % 10;

// Display the results
Console.WriteLine($"Student Name: {fullname}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1name}\t\t{course1grade}\t\t{course1credits}");
Console.WriteLine($"{course2name}\t\t{course2grade}\t\t{course2credits}");
Console.WriteLine($"{course3name}\t\t{course3grade}\t\t{course3credits}");
Console.WriteLine($"{course4name}\t{course4grade}\t\t{course4credits}");
Console.WriteLine($"{course5name}\t\t{course5grade}\t\t{course5credits}");

Console.WriteLine($"\nGrade Point Average: {gradepointaverage:F2}");
Console.WriteLine($"\nFinal GPA:\t\t {leadinigDigit}.{firstdigit}{seconddigit}");
