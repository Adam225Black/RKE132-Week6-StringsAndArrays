string hello = " we are soldiers in the army! we have to fight although we have to cry!";

int stringLenght = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);

//int wordCounter = 1;
//for(int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");