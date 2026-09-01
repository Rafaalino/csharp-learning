int cA = 5;
//Sophia
int sop1 = 93;
int sop2 = 87;
int sop3 = 98;
int sop4 = 95;
int sop5 = 100;
//nicolas
int nic1 = 80;
int nic2 = 83;
int nic3 = 82;
int nic4 = 88;
int nic5 = 85;
//zahira
int zah1 = 84;
int zah2 = 96;
int zah3 = 73;
int zah4 = 85;
int zah5 = 79;
//jeong
int jeo1 = 90;
int jeo2 = 92;
int jeo3 = 98;
int jeo4 = 100;
int jeo5 = 97;
//soma das notas
int somaSop = sop1 + sop2 + sop3 + sop4 + sop5;
int somaNic = nic1 + nic2 + nic3 + nic4 + nic5;
int somaZah = zah1 + zah2 + zah3 + zah4 + zah5;
int somaJeo = jeo1 + jeo2 + jeo3 + jeo4 + jeo5;
//decimal
decimal mediaSop = (decimal)somaSop / cA;
decimal mediaNic = (decimal)somaNic / cA;
decimal mediaZah = (decimal)somaZah / cA;
decimal mediaJeo = (decimal)somaJeo / cA;
//Console output
Console.WriteLine("Student\t\tAverage\tGrade");
Console.WriteLine("Sophia:\t\t " + mediaSop + "\t A");
Console.WriteLine("Nicolas:\t " + mediaNic + "\t B");
Console.WriteLine("Zahira:\t\t " + mediaZah + "\t B");
Console.WriteLine("Jeong:\t\t " + mediaJeo + "\t A");