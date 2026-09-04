namespace ForeachLoopChallenge
{

    public class Aluno
    {
        public string Nome;
        public int[] Notas;

        public void gradeCurricular()
        {
            int soma = 0;
            string grade = "";
            string status = "Reprovado";
            foreach (int nota in Notas)
            {
                soma += nota;
            }
            double media = (double)soma / Notas.Length;

            if (media >= 97)
                grade = "A+"; 
            else if (media >= 93)
                grade = "A";
            else if (media >= 90)
                grade = "A-";
            else if (media >= 87)
                grade = "B+";
            else if (media >= 83)
                grade = "B";
            else if (media >= 80)
                grade = "B-";
            else if (media >= 77)
                grade = "C+";
            else if (media >= 73)
                grade = "C";
            else if (media >= 70)
                grade = "C-";
            else if (media >= 67)
                grade = "D+";
            else if (media >= 63)
                grade = "D";
            else if (media >= 60)
                grade = "D-";
            else
                grade = "F";

                bool aprovado = media >= 60;
                if (aprovado) {
                    status = "Aprovado";
                }

            Console.WriteLine($"Aluno: {Nome}\t\t{media:F2}\t\t{grade}\t\t{status}");
        }

    }

    class Program
    {
        static void Main(String[] args)
        {
            /*           
            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Sophia";
            aluno1.Notas = new int[] { 88, 79, 100, 56, 32 };

            Aluno aluno2 = new Aluno();
            aluno2.Nome = "Nicolas";
            aluno2.Notas = new int[] { 95, 87, 92, 88, 90 };

            Aluno aluno3 = new Aluno();
            aluno3.Nome = "Isabella";
            aluno3.Notas = new int[] { 100, 100, 100, 100, 100 };

            Aluno aluno4 = new Aluno();
            aluno4.Nome = "Lucas";
            aluno4.Notas = new int[] { 70, 75, 80, 85, 90 };

            Aluno[] alunos = new Aluno[] { aluno1, aluno2, aluno3, aluno4 };

            foreach (Aluno aluno in alunos)
            {
                aluno.gradeCurricular();
                Console.WriteLine();

            }
            */

            Console.WriteLine($"Estudante\t\tMedia\t\tNota\t\tAprovado");

            Aluno[] alunos =
            {
                new Aluno
                { Nome = "Sophia", Notas = new int[] { 88, 79, 100, 56, 32 } },
                new Aluno
                { Nome = "Nicolas", Notas = new int[] { 95, 87, 92, 88, 90 } },
                new Aluno
                { Nome = "Isabella", Notas = new int[] { 100, 100, 100, 100, 100 } },
                new Aluno
                { Nome = "Lucas", Notas = new int[] { 70, 75, 80, 85, 90 } },
                new Aluno
                { Nome = "Olivia", Notas = new int[] { 60, 65, 70, 75, 80 }  },
                new Aluno
                { Nome = "Ethan", Notas = new int[] { 14, 53, 61, 27, 35 } },
                new Aluno
                { Nome = "Ava", Notas = new int[] { 12, 27, 7, 85, 9 } }
            };

            foreach (Aluno aluno in alunos)
            {
                
                aluno.gradeCurricular();
                
            }
        }

    }

}
