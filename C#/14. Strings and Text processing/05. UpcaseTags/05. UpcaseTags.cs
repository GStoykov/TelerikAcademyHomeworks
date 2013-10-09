using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class UpcaseTagsram
 {
     static void Main()
     {
         // You are given a text. Write a program that changes the text in all regions
         // surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

         // Example: 
         // We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

         string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
         bool betweenTags = false;
         //string openingTag = "<upcase>";
         //string closingTag = "</upcase>";
         int startIndex = 0;
         int endIndex = 0;
         

         for (int i = 0; i < text.Length - 8; i++)
         {
             if (text.Substring(i, 8) == "<upcase>")
             {
                 startIndex = i + 8;
                 i = startIndex;
             }
             if (text.Substring(i, 9) == "</upcase>")
             {
                 endIndex = i;
                 int length = endIndex - startIndex;
                 string upperStr = text.Substring(startIndex, length).ToUpper();
                 text = text.Remove(startIndex, length);
                 text = text.Insert(startIndex, upperStr);
                 text = text.Remove(startIndex - 8, 8);
                 text = text.Remove(endIndex - 8, 9);
             }
         }
         Console.WriteLine(text);



     }
 }

