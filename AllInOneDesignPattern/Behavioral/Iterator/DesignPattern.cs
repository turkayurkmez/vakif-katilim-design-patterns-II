using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /*
     * Karmaşık bir veri yapısından oluşan koleksiyonun içerisinde (yapıyı açığa çıkarmadan) sıralı (adım adım) ilerlemeniz gerekiyorsa bu pattern'i kullanırsınız
     */

    public class Iterator : IEnumerator<string>
    {
        int position = 0;
        List<string> words = new List<string>();
        public string Current => words[position];

        object IEnumerator.Current => Current;


        public void Add(string word)=>words.Add(word);

        public void Dispose()
        {
            position = 0;
            words.Clear();
        }

        public bool MoveNext()
        {
            position++;
            return position < words.Count;
        }

        public void Reset()
        {
            position = 0;
        }

        public string Next()
        {
           return words[position++];
            
        }
        public string First()
        {
            position = 0;
            return words[position];
        }

    }
}
