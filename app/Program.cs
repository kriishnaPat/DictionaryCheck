// Spell Check Starter
// This start code creates two lists
// 1: dictionary: an array containing all of the words from "dictionary.txt"
// 2: aliceWords: an array containing all of the words from "AliceInWonderland.txt"

using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("hey");
    // Load data files into arrays
    String[] dictionary = System.IO.File.ReadAllLines(@"data-files/dictionary.txt");
    String aliceText = System.IO.File.ReadAllText(@"data-files/AliceInWonderLand.txt");
    String[] aliceWords = Regex.Split(aliceText, @"\s+");
    
    // Print first 50 values of each list to verify contents
    Console.WriteLine("***DICTIONARY***");
    printStringArray(dictionary, 0, 50);

    Console.WriteLine("***ALICE WORDS***");
    printStringArray(aliceWords, 0, 50);
  }

  public static void printStringArray(String[] array, int start, int stop) {
    // Print out array elements at index values from start to stop 
    for (int i = start; i < stop; i++) {
      Console.WriteLine(array[i]);
    }
  }

  public static void spellCheck(string[] args){
    while(true){
      Console.WriteLine(@"Main Menu
1: Spell Check a Word (Linear Search)
2: Spell Check a Word (Binary Search)
3: Spell Check Alice In Wonderland (Linear Search)
4: Spell Check Alice In Wonderland (Binary Search)
5: Exit
");
      Console.WriteLine("Enter menu selection; ");
      int userChoice = Convert.ToInt16(Console.ReadLine());
    }
  }

  static int linearSearch(int[] anArray, int item){
      for (int i=0; i < anArray.Length; i++){
          if (anArray[i] == item){
              return i;
          }
      }
      return -1;
  }

  static int linearSearchStr(string[] anArray, string item){
      for (int i=0; i < anArray.Length; i++){
          if (String.Equals(anArray[i], item)){
              return i;
          }
      }
      return -1;
  }
  static int binarySearch(int[] anArray, int item){
            int lower_index = 0;
            int upper_index = anArray.Length - 1;
            while (lower_index <= upper_index){
                int middle_index = (lower_index + upper_index)/2;
                if(item == anArray[middle_index]){
                    return middle_index;
                }else if(item < anArray[middle_index]){
                    upper_index = middle_index-1;
                }else{
                    lower_index = middle_index+1;
                }
            }
            return -1;
        }

        static int binarySearchStr(string[] anArray, string item){
            int lower_index = 0;
            int upper_index = anArray.Length - 1;
            while (lower_index <= upper_index){
                int middle_index = (lower_index + upper_index)/2;
                if(item == anArray[middle_index]){
                    return middle_index;
                }else if(string.Compare(item,anArray[middle_index])<0){
                    upper_index = middle_index-1;
                }else{
                    lower_index = middle_index+1;
                }
        }
        return -1;
        }
}

  