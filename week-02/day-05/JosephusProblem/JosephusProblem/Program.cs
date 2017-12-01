using System;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 66;
            Console.WriteLine(FindJosephus(number));
            Console.ReadLine();
        }

        static int FindJosephus(int number)
        {
            int[] participants = GenerateParticipantsList(number);
            int pointer = 0;
            int living = number;

            // The pointer shows which is the actual person. The next one will be the one who is pointed by the actual person's pointed.
            // Who is not pointed any more counts as dead. The last person pointed is the winner.
            while (living != 1)
            {
                participants[pointer] = participants[participants[pointer]];
                pointer = participants[pointer];
                living--;
            }
            return participants[pointer] + 1;
        }

        static int[] GenerateParticipantsList(int number)
        {
            int[] participants = new int[number];

            for (int i = 0; i < participants.Length - 1; i++)
            {
                participants[i] = i + 1;
            }
            participants[participants.Length - 1] = 0;

            return participants;
        }
    }
}
