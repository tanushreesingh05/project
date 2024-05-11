using System;
using System.Collections;
 

//Program of Queue implementation using linkedlist
namespace Oppsprogram
    {

   
        class Program
        {
   

        static void Main(string[] args)
            {

            Hashtable my_hashtable1= new Hashtable();

            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "C sharp");
            my_hashtable1.Add("key1", "value1");

            my_hashtable1.Add("key2", "value2");



            foreach (DictionaryEntry ele in my_hashtable1)
            {
                Console.WriteLine(ele.Key+" "+ele.Value);

            }
            Console.WriteLine("COUNT OF HASHTABLE BEFORE DELETION IS : " + my_hashtable1.Count);
            my_hashtable1.Remove("A1");

            foreach (DictionaryEntry ele in my_hashtable1)
            {
                Console.WriteLine(ele.Key + " " + ele.Value);

            }
            Console.WriteLine("COUNT OF HASHTABLE AFTER DELETION IS : " + my_hashtable1.Count);


            //USING Contains
            Console.WriteLine(my_hashtable1.Contains("A1"));

            //using
            //ContainsKey
            Console.WriteLine(my_hashtable1.ContainsKey("A2"));

            //using ContainsValue
            Console.WriteLine(my_hashtable1.ContainsValue("to"));


            //upadating the valueof existing key

            string keyToUpdate = "key1";
            if (my_hashtable1.ContainsKey(keyToUpdate))
            {
                my_hashtable1[keyToUpdate] = "newValue";
            }
            //accessing the updated value
            string updatedValue = (string)my_hashtable1[keyToUpdate];
            Console.WriteLine("Updated value:"+ updatedValue);
            //print all pairs in hashtable
            foreach(DictionaryEntry delement in my_hashtable1)
            {
                Console.WriteLine("Key:"+ delement.Key+" "+"Values:"+delement.Value);

            }


        }
    }
    }


