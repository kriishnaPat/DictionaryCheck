using System;

class Program {
  public static void printStringArray(String[] array, int start, int stop) {
    // Print out array elements at index values from start to stop 
    for (int i = start; i < stop; i++) {
      Console.WriteLine(array[i]);
    }
  }

  static int linearSearchStr(string[] anArray, string item){
      for (int i=0; i < anArray.Length; i++){
          if (String.Equals(anArray[i], item)){
              return i;
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

  public static void Main (string[] args) {
    // Load data files into arrays
    String[] dictionary = System.IO.File.ReadAllLines(@"data-files/dictionary.txt");
    String aliceText = System.IO.File.ReadAllText(@"data-files/AliceInWonderLand.txt");
    String[] aliceWords = Regex.Split(aliceText, @"\s+");

    while(true){
      Console.WriteLine(@"Main Menu
1: Spell Check a Word (Linear Search)
2: Spell Check a Word (Binary Search)
3: Spell Check Alice In Wonderland (Linear Search)
4: Spell Check Alice In Wonderland (Binary Search)
5: Exit
");
        Console.Write("Enter menu selection: ");
        int user_choice = Convert.ToInt16(Console.ReadLine()); 

        if (user_choice == 1)
        {
            Console.Write("Enter the word you would like to check: ");
            string user_word = Console.ReadLine();
            user_word = user_word.ToLower();
            int index_num = linearSearchStr(dictionary, user_word);
            if(index_num == -1){
                Console.WriteLine($"{user_word} is NOT IN the dictionary at position.");
            }else{
                Console.WriteLine($"{user_word} is IN the dictionary at position {index_num}.");
            }
        } 
        else if (user_choice == 2)
        {
            Console.Write("Enter the word you would like to check: ");
            string user_word = Console.ReadLine();
            user_word = user_word.ToLower();
            int index_Num = binarySearchStr(dictionary, user_word);
            if(index_num == -1){
                Console.WriteLine($"{user_word} is NOT IN the dictionary at position.");
            }else{
                Console.WriteLine($"{user_word} is IN the dictionary at position {index_num}.");
            }
        }
        else if (user_choice == 3) 
        {
            int notFound = 0;
            for (int i = 0; i < aliceWords.Length; i++){
                if (linearSearchStr(dictionary, aliceWords[i]) == -1){
                    notFound++;
                }
            }
            Console.WriteLine($"Number of words not found in dictionary {notFound}!");
        }
        else if (user_choice == 4)
        {
            int notFound_1 = 0;
            for (int i = 0; i < aliceWords.Length; i++){
                if (binarySearchStr(dictionary, aliceWords[i]) == -1){
                    notFound_1++;
                }
            }
            Console.WriteLine($"Number of words not found in dictionary {notFound_1}!");
        }
        else if (user_choice == 5)
        {
            break;
        }
        else 
        {
            Console.Write("Invalid choice");
        }


    }
  }
}