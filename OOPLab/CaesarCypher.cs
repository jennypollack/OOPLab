using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab
{
    public class CaesarCypher
    {
        private int offset;
        private string alphabet;
        private string transpose; 

        public CaesarCypher(string alph)
        {
            this.alphabet = alph;

            //this.setTranspose(); 
        }

        public void setOffset(int n)
        {
            this.offset = n;
        }

        public string getTranspose()
        {
            return this.transpose; 
        }

        public void setTranspose()
        {

            char[] result = new char[this.alphabet.Length];
            int fromIndex = 0;
            int newIndex = this.offset;
            for(int counter = 1; counter <= this.alphabet.Length; counter++)
            {

                result[fromIndex] = this.alphabet[newIndex];
                newIndex = newIndex+1;
                fromIndex = fromIndex + 1;
                if(newIndex >= this.alphabet.Length){
                    newIndex = 0;
                }
            }
           
            this.transpose = new String(result);
            
        }

        public string cypher(string input)
        {
            char[] result = new char[input.Length];
            string output = "";
            var index = 0;
            for(int i = 0; i < input.Length; i++)
            {
                index = this.alphabet.IndexOf(input[i]); 
                result[i] = this.transpose[index];
            }

            output = new String(result);
            return output;
        }

        public string decypher(string input)
        {
            char[] result = new char[input.Length];
            string output = "";
            var index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                index = this.transpose.IndexOf(input[i]);
                result[i] = this.alphabet[index];
            }

            output = new String(result);
            return output;

        }
    }

}
;