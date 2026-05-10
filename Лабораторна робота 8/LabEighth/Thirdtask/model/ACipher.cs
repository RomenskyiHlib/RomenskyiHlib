using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thirdtask.@interface;
using static System.Net.Mime.MediaTypeNames;

namespace Thirdtask.model
{
    internal class ACipher : ICipher, IComparable<ACipher>
    {
        public string Text { get; set; }
        private const int key = 1;
        private const int alphabet = 26;

        public ACipher(string text)
        {
            Text = text;
        }
        public string Encode(string input)
        {
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!char.IsLetter(chars[i]))
                    continue;

                char offset = char.IsUpper(chars[i]) ? 'A' : 'a';

                chars[i] = (char)((chars[i] - offset + key) % alphabet + offset);
            }

            return new string(chars);
        }

        public string Decode(string input)
        {
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!char.IsLetter(chars[i]))
                    continue;

                char offset = char.IsUpper(chars[i]) ? 'A' : 'a';

                chars[i] = (char)((chars[i] - offset - key + alphabet) % alphabet + offset);
            }

            return new string(chars);
        }

        public int CompareTo(ACipher other)
        {
            if (other == null) return 1;
            return string.Compare(Text, other?.Text);
        }

        public override bool Equals(object obj)
        {
           return obj is ACipher cipher && Text == cipher.Text;
        }
        public override int GetHashCode() 
        { 
            return Text.GetHashCode(); 
        }
    }
}

