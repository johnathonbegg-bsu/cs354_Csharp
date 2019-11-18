using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabetize
{
    class main
    {

        static void Main(string[] args)
        {
            //given an seriese of words organize them alphabeticaly

            Alpthabetize alpha = new Alpthabetize(args.Length);

            foreach (String str in args) {
                alpha.Insert(str);
            }
            alpha.print();
            Console.ReadLine();
        }
        


    }
    class Alpthabetize {
        private String[] wordList;
        private int length = 0;
        public Alpthabetize(int size) {
            wordList = new String[size];
        }

        public void Insert(String newWord)
        {
            
            
            int compare = 0;

            for (int iter = 0; iter <= length; iter++)
            {
                if (String.IsNullOrEmpty(wordList[iter]))
                {
                    wordList[iter] = newWord;
                    
                }
                else {
                    compare = String.Compare(wordList[iter], newWord, true);
                    //if new word is first alphabeticaly 
                    if (compare == 1)
                    {
                        String temp = wordList[iter];
                        wordList[iter] = newWord;
                        newWord = temp;
                        
                    }
                }
                
               
            }

            length += 1; 
            return;
        }

        public void print() {

            foreach (String str in wordList)
            {
                Console.WriteLine(str);
            }

        }
    }

}
