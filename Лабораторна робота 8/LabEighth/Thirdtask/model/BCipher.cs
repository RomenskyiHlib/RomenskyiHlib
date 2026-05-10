using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thirdtask.@interface;
using static System.Net.Mime.MediaTypeNames;

namespace Thirdtask.model
{
    internal class BCipher: ICipher, IComparable<BCipher>
    {
            public string Text { get; set; }

            public BCipher(string text) 
            {  
            Text = text;
            }

            public string Encode(string input)
            {
                char[] chars = input.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    char c = chars[i];
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        chars[i] = (char)(offset + ('Z' - char.ToUpper(c)));
                        if (char.IsLower(c)) chars[i] = char.ToLower(chars[i]);
                    }
                }
                return new string(chars);
            }
        public string Decode(string input) => Encode(input);

        public int CompareTo(BCipher other)
            {
                if (other == null) return 1;
                return string.Compare(Text, other?.Text);
            }
            public override bool Equals(object obj)
            {
                return obj is BCipher cipher && Text == cipher.Text;
            }
            public override int GetHashCode()
            {
                return Text.GetHashCode();
            }
        }
    }

