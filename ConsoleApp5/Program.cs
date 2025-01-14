using System.Text;
//zadacha 1
//char[] vowels = { 'а', 'у', 'о', 'и', 'э', 'ы', 'я', 'ю', 'е', 'ё' };
//StringBuilder text = new StringBuilder(Console.ReadLine());
//StringBuilder newText = new StringBuilder("");
//for (int i = 0; i < text.Length; i++)
//{
//    if (vowels.Contains(text[i]))
//    {
//        newText = text.Replace(text[i], '*');
//    }
//}
//Console.WriteLine(newText.ToString());
//zadacha 2
//string vowels = " ";
//StringBuilder text = new StringBuilder(Console.ReadLine());
//StringBuilder newText = new StringBuilder("");
//for (int i = 0; i < text.Length; i++)
//{
//    if (vowels.Contains(text[i]))
//    {
//        newText = text.Replace(text[i], '_');
//    }
//}
//Console.WriteLine(newText.ToString());
//zadacha 3
//StringBuilder text = new StringBuilder(Console.ReadLine());
//StringBuilder newText = new StringBuilder("");
//string end = ";";
//string[] words = { };
//words = text.ToString().Split(' ');
//int WordCounts = words.Count();
//string maxWord = words[0];
//foreach (string word in words)
//{
//    if (word.Length > maxWord.Length)
//    {
//        maxWord = word;
//    }
//}
//Console.WriteLine(maxWord);
//zadacha 4 
//StringBuilder text = new StringBuilder(Console.ReadLine());
//StringBuilder newtext=new StringBuilder("");
//int numcount = 0;
//char[] nums = {  '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
//for (int i = 0; i < text.Length; i++)
//{
//    if (nums.Contains(text[i]))
//    {
//        numcount++;
//    }
//}
//Console.WriteLine(numcount);
//zadacha 5
//DateTime dateTime= DateTime.Now;
//Console.WriteLine($"week: {dateTime:dddd} ");
//zadacha 8
//DateTime dateTime = DateTime.Now;
//Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
//zadacha 6
//TimeSpan date = DateTime.Now - new DateTime(2025, 01, 20);
//Console.WriteLine(Math.Abs(date.Days));
//zadacha 7

//string result = new string('A', 1000000);
//Console.WriteLine(result);

//StringBuilder text = new StringBuilder("");
//for (int i = 1; i < 1000000; i++)
//{
//    text = text.Append("A");
//}
//Console.WriteLine(text);
