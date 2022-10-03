// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string word = "demon";
char[] letters=word.ToCharArray();
int length = letters.Length;
string[] wordpad;
for( int i = 0; i < length; i++){
    wordpad = wordpad + " _";
}
Console.WriteLine(wordpad);
