using System;
using System.Collections.Generic;

namespace election_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> candidate_list = new List<Candidate>();
            candidate_list.Add(new Candidate("Jones"));
            Console.Write("Which candidate would you like to vote for?: ");
            string input = Console.ReadLine();
            Console.WriteLine("Congratulations! You voted for " + input);
            if (check_name(input, candidate_list) == false)
            {
                candidate_list.Add(new Candidate(input));
            }
            foreach (var i in candidate_list)
            {
                if (input.Equals(i.name))
                {
                    i.votes ++;
                }
                Console.WriteLine(i.name + " : " + i.votes);
            }
        }
        public class Candidate
        {
            public int votes = 0;
            public string name;
            public Candidate(string n)
            {
                name = n;
            }
        }
        static bool check_name(string name, List<Candidate> list)
        {
            foreach (Candidate i in list)
            {
                if (i.name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
