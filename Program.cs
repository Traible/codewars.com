﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

#region костыльне часы
//bool Check = false; // Проверка условия
//bool Delta = false;
//char? CheckChar = null; // 
//int CheckUniqueLetters = 0; //26
//string str = "The quick brown fox jumps over the lazy dog.";
//string Temporary = str.ToLower();
//int Temp = Temporary.Length;
//for (int i = 0; i < Temporary.Length; i++)
//{
//    if (Temporary[i] >= 'a' && Temporary[i] <= 'z')
//    {
//        CheckChar = Temporary[i];
//        CheckUniqueLetters++;
//        for (int j = i; j < Temporary.Length; j++)
//            if (Temporary[j] == CheckChar) { Temporary = Temporary.Remove(j, 1); j--; Delta = true; }
//            else if (Temporary[j] < 'a' || Temporary[j] > 'z') { Temporary = Temporary.Remove(j, 1); j--; Delta = true; }
//        if (Delta == true) { i--; Delta = false; }
//    }
//    else { Temporary = Temporary.Remove(i, 1); Temp--; i--; }
//    if (Delta == true) i--;
//}
//if (CheckUniqueLetters == 26) { Check = true; Console.WriteLine("Успех!"); }
//else Console.WriteLine("Неудача!");

//int[] numbers = { 8, 3, 5, -1, 2 };
//int Temp = 0;
//for (int i = 0; i < numbers.Length; i++)
//    if (numbers[i] >= 0) Temp++;
//int[] NewArray = new int[Temp];
//int j = 0;
//for (int i = 0; i < numbers.Length; i++)
//    if (numbers[i] >= 0) { NewArray[j] = numbers[i]; j++; }
//Array.Sort(NewArray);
//int Result = NewArray[0] + NewArray[1];
//Console.WriteLine(Result);
//return Result;

//int Population = 1500000;
//double PercentPlusPoppulationPerYear = 0.25;
//int MovingPlusPoppulationPerYear = 1000;
//int WaitingPopulation = 2000000;
//int result = 0;
//PercentPlusPoppulationPerYear /= 100;
//while (true)
//{
//    Population += Convert.ToInt32(Population * PercentPlusPoppulationPerYear) + MovingPlusPoppulationPerYear;
//    result++;
//    if (Population >= WaitingPopulation) break;
//}
//Console.WriteLine(result.ToString());
//Console.ReadLine();
//return result;

//int a = -10;
//int b = 10;
//int Result = 0;
//if (a == b) { Result = a; } // return Result;
//else if (b > a) { int Temp = a; a = b; b = Temp; }
//for (int i = b; i < a + 1; i++)
//Result += i;

//string timeString = "00;11;22";
//if (timeString == null || timeString == "" || timeString == "0") {} // return timeString;
//int Check = timeString.Length - 1;
//string Hours = ""; string Minuts = ""; string Seconds = "";
//Hours += timeString[Check]; Check--; Hours += timeString[Check]; Check--; bool result1 = int.TryParse(Hours, out var TempHours); if (result1 != true) {} // return null;
//if (timeString[Check] == ':' || timeString[Check] == ';') Check--;
//Minuts += timeString[3] + timeString[4]; bool result2 = int.TryParse(Minuts, out var TempMinuts); if (result2 != true) {}// return null;
//if (timeString[Check] == ':' || timeString[Check] == ';') Check--;
//Seconds += timeString[6] + timeString[7]; bool result3 = int.TryParse(Seconds, out var TempSeconds); if (result3 != true) {} //return null;
//while (true) { if (TempSeconds > 59) { TempSeconds -= 60; TempMinuts++; } else break; }
//while (true) { if (TempMinuts > 59) { TempMinuts -= 60; TempHours++; } else break; }
//while (true) { if (TempHours > 23) TempHours -= 24; else break; }
//timeString = Convert.ToString(TempHours) + ":" + Convert.ToString(TempMinuts) + ":" + Convert.ToString(TempSeconds);
//Console.WriteLine(timeString);Console.ReadLine();   
//// return timeString;

//string timeString = "25:99:99";
//if (timeString == null || timeString == "" || timeString == "0") Console.ReadLine(); // return timeString;
//if (timeString.Length < 8) Console.ReadLine(); // return null;
//string Temporary = "";
//for (int i = 0; i < timeString.Length; i++)
//{
//    if (timeString[i] >= '0' && timeString[i] <= '9') Temporary += timeString[i];
//    else if (timeString[i] == ';') Console.ReadLine(); // { return null; }
//}
//if (Temporary.Length < 6) Console.ReadLine(); // return null;
//int Check = 0;
//string Hours = ""; string Minuts = ""; string Seconds = "";
//Hours += Temporary[Check]; Check++; Hours += Temporary[Check]; Check++; bool result1 = int.TryParse(Hours, out var TempHours); if (result1 != true)  Console.ReadLine();  // { return null; }
//Minuts += Temporary[Check]; Check++; Minuts += Temporary[Check]; Check++; bool result2 = int.TryParse(Minuts, out var TempMinuts); if (result2 != true)  Console.ReadLine();  // { return null; }
//Seconds += Temporary[Check]; Check++; Seconds += Temporary[Check]; bool result3 = int.TryParse(Seconds, out var TempSeconds); if (result3 != true)  Console.ReadLine();  // { return null; }
////Hours += Temporary[Check]; Check++; Hours += Temporary[Check]; Check++; int TempHours = Convert.ToInt32(Hours);
////Minuts += Temporary[Check]; Check++; Minuts += Temporary[Check]; Check++; int TempMinuts = Convert.ToInt32(Minuts);
////Seconds += Temporary[Check]; Check++; Seconds += Temporary[Check]; int TempSeconds = Convert.ToInt32(Seconds);
//while (TempSeconds > 59) { TempSeconds -= 60; TempMinuts++; }
//while (TempMinuts > 59)  { TempMinuts -= 60; TempHours++; }
//while (TempHours > 23) TempHours -= 24;
//if (TempHours < 10) Temporary = "0" + Convert.ToString(TempHours) + ":"; else Temporary = Convert.ToString(TempHours) + ":";
//if (TempMinuts < 10) Temporary += "0" + Convert.ToString(TempMinuts) + ":"; else Temporary += Convert.ToString(TempMinuts) + ":";
//if (TempSeconds < 10) Temporary += "0" + Convert.ToString(TempSeconds); else Temporary += Convert.ToString(TempSeconds);
//Console.WriteLine(Temporary); Console.ReadLine();
#endregion
#region Ката
//string a = "inmanylanguages";
//string b = "theresapairoffunctions";

//var Temporary = a + b;
//char Check = 'a';
//string Result = string.Empty;
//for (int i = 0; i < 27; i++)
//{
//    bool CheckTry = false;
//    for (int j = 0; j < Temporary.Length; j++)
//    {
//        if (Temporary[j] == Check) { Result += Check; Check++; CheckTry = true; }
//    }
//    if (CheckTry == false) Check++;
//}
//Console.WriteLine(Result); Console.ReadLine();
#endregion Ката
#region Ката
//int[] array = {};
//if (array[0] == null) array[0] = 0;
//int Temporary = array.Sum();
//// if (Temporary % 2 == 0) return "even";
//// else return "odd";
//Console.WriteLine(Temporary.ToString()); Console.ReadLine();
#endregion Ката
#region часы но менее костыльные
//int seconds = 359999;
//int HH = 0; int MM = 0; int SS = 0;
//string Temporary = string.Empty;
//    while(true)
//    {
//        if (seconds < 60) { SS += seconds; seconds = 0; }
//        if (seconds >= 60) { MM++; seconds -= 60; }
//        if (MM >= 60) { HH++; MM -= 60; }
//        if (seconds == 0) break;
//    }
//if (HH < 10) Temporary = "0" + Convert.ToString(HH) + ":"; else Temporary = Convert.ToString(HH) + ":";
//if (MM < 10) Temporary += "0" + Convert.ToString(MM) + ":"; else Temporary += Convert.ToString(MM) + ":";
//if (SS < 10) Temporary += "0" + Convert.ToString(SS); else Temporary += Convert.ToString(SS);
//Console.WriteLine(Temporary); Console.ReadLine();
#endregion
#region что-то с алфавитом
//for (int i = 0; i < text.Length; i++)
//{
//    if (TemporaryLower[i] >= 'a' && TemporaryLower[i] <= 'z')
//        for (int j = 0; j < 26; j++)
//        {
//            if (TemporaryLower[i] == (char)('a' + j))
//            {
//                if (Check == true) Result += " " + (j + 1);
//                else { Check = true; Result += (j + 1); }
//            }
//        }
//}
//Console.WriteLine(Result); Console.ReadLine();

//string str1 = "aabbcamaomsccdd";
//string str2 = "commas";
//if (str2.Length > str1.Length) { Console.WriteLine("False"); Console.ReadLine(); } // return False; 
//string Temporary1 = str2;
//string Temporary2 = string.Empty;
//for (int i = 0; i < str2.Length; i++)
//{
//    if (str2[i] == ' ') continue;
//    char Temp = str2[i];
//    int Check1 = 0;
//    int Check2 = 0;
//    for (int j = 0; j < str2.Length; j++)  // сколько искомых символов в первой строке
//    {

//        if (Temp == str2[j]) Check1++;
//    }
//    for (int j = 0; j < str1.Length; j++)        // сколько искомых символов во второй строке
//    {
//        if (Temp == str1[j]) Check2++;   // если искомых символов больше либо равно, записываем и удаляем (если нет - FALSE)
//        if (Check2 == Check1) break;
//    }
//    if (Check2 == Check1) 
//    {
//        for (int j = 0; j < Check1; j++) 
//        {
//            Temporary2 += Temp;
//        }
//        str1 = str1.Replace(Temp, ' ');
//        str2 = str2.Replace(Temp, ' ');
//    }
//}
//if (Temporary1.Length == Temporary2.Length) { Console.WriteLine("True"); Console.ReadLine(); }
//else { Console.WriteLine("False"); Console.ReadLine(); }

//int[] array = { 5, 3, 2, 8, 1, 4 };
//int[] Temporary = new int[array.Count()];

//int Check = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0) Temporary[i] = array[i];
//    else { Temporary[i] = 0; Check++; }
//}
//int[] Temporary2 = new int[Check];
//Check = 0;
//for (int i = 0; i < array.Length; i++)
//    if (array[i] % 2 != 0) { Temporary2[Check] = array[i]; Check++; }
//Array.Sort(Temporary2);
//Check = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0) Temporary[i] = array[i];
//    else { Temporary[i] = Temporary2[Check]; Check++; }
//}

//var str1 = string.Join(" ", Temporary);
//var str2 = string.Join(" ", Temporary2);
//Console.WriteLine(str1);
//Console.WriteLine(str2);
//Console.ReadLine();
#endregion
#region IEnumerable
//IEnumerable<int> array = new [] { 1, 2, 1, 1, 1, 1 };
//// int [] array = { 1, 1, 1, 1, 2, 1 };
//// string Temporary = string.Empty;
//int Check1 = 0; int Check2 = 0; int Check3 = 0;
//foreach (var Temp in array)
//{
//    if (Check1 == 0) { Check1 = Temp; continue; }
//    if (Check2 == 0) { Check2 = Temp; continue; }
//    if (Check3 == 0) { Check3 = Temp; break; }
//}
//int Constanta = 0;
//int Delta = 0;
//if (Check1 == Check2) Constanta = Check1;
//else if (Check2 == Check3) { Constanta = Check3; Delta = Check1; }
//else Delta = Check2;
//if (Delta == 0)
//foreach (var Temp in array) if (Constanta != Temp) { Delta = Temp; break; }
//Console.WriteLine(Delta);
//Console.ReadLine();
#endregion IEnumerable
#region Неработающая Хуета
//int CheckOut = 0;
//int Check = 0;
//List<string> Hueta = new List<string>();
//List<string> Variants = new List<string>();
//List<string> SinglePermutations = new List<string>();
//string s = "abcqwer";
//Random rnd = new Random();
//char[] Temp;
//Temp = s.ToCharArray(0, s.Length);

////while (CheckOut != s.Length * s.Length * 256)
////{
////    List<int> Array = new List<int>();
////    for (int i = 0; i < s.Length; i++) Array.Add(i);
////    Check = 0;
////    string Temporary = string.Empty; 
////    while (Check != s.Length)
////        {
////            int unique = rnd.Next(0, s.Length);
////            for (int i = 0; i < Array.Count; i++)
////                {
////                    if (unique == Array[i]) { Temporary += Temp[Array[i]]; Array.RemoveAt(i); Check++; break; }
////                }
////            if (Array.Count == 1) { Temporary += Temp[Array[0]]; Check++; break; }
////    }
////    SinglePermutations.Add(Temporary);
////    CheckOut++;
////}


////int Target = 1;
////for (int i = 1; i < s.Length + 1; i++) Target *= i;

////while (CheckOut != Target)
////{
////    bool Error = false;
////    string Temporary = string.Empty;
////    while (Check != s.Length)
////    {
////        Error = false;
////        int unique = rnd.Next(0, s.Length);
////        if (Temporary == string.Empty) { Temporary += unique; Check++; continue; }
////        foreach (var temp in Temporary)
////            if (unique == Convert.ToInt32(Convert.ToString(temp))) Error = true;
////        if (Error == false) { Temporary += unique; Check++; }
////    }
////    if (Variants.Count != 0)
////    {
////        foreach (var temp in Variants) if (Temporary == temp) { Error = true; break; }
////    }
////    if (Error == false) { Variants.Add(Temporary); CheckOut++; }
////    Check = 0;
////}

//string Output = string.Empty;
//for (int i = s.Length - 1; i >= 0; i--)
//    Output += i;


//int pizda = Convert.ToInt32(Output);

//for (int i = 0; i < pizda; i++)
//{
//    bool Dublicate = false;
//    string temp = i.ToString();
//    if (temp.Length != s.Length) continue;
//    if (temp.Length >= 5) for (int j = 0; j < temp.Length; j++) { if (j != 0 && temp[j] == temp[0] || temp[0] == temp[1] || temp[0] == temp[2]) Dublicate = true; }
//    if (Dublicate == false) Hueta.Add(temp);
//}


//foreach (string temp in Hueta)
//{
//    if (temp.Length == s.Length) Variants.Add(temp);
//}


//// Variants.Add(Convert.ToString(Hueta.Distinct().Count()));


//for (int i = 0; i < Variants.Count; i++)
//{
//    for (int j = 0; j < Variants.Count - 1; j++)
//    {
//        if (i != j && Variants[i] == Variants[j]) { Variants.RemoveAt(j); j--; }
//        if (i == Variants.Count) break;
//    }
//}



//foreach (var temp in Variants)
//{
//    string Temporary = string.Empty;
//    for (int i = 0; i < s.Length; i++) 
//    {
//        if (temp[i] == '0') { Temporary += s[0]; continue; }
//        if (temp[i] == '1') { Temporary += s[1]; continue; }
//        if (temp[i] == '2') { Temporary += s[2]; continue; }
//        if (temp[i] == '3') { Temporary += s[3]; continue; }
//        if (temp[i] == '4') { Temporary += s[4]; continue; }
//        if (temp[i] == '5') { Temporary += s[5]; continue; }
//        if (temp[i] == '6') { Temporary += s[6]; continue; }
//    }
//    SinglePermutations.Add(Temporary);
//}

//for (int i = 0; i < SinglePermutations.Count; i++)
//{
//    for (int j = 0; j < SinglePermutations.Count - 1; j++)
//    {
//        if (i != j && SinglePermutations[i] == SinglePermutations[j]) { SinglePermutations.RemoveAt(j); j--; }
//        if (i == SinglePermutations.Count) break;
//    }
//}


//foreach (var temp in SinglePermutations)
//Console.WriteLine(temp);
//Console.ReadLine();
#endregion
#region хуйня выше но работающая
//var random = new Random();

//string Generate()
//{
//    int size = random.Next(2, 5);

//    string rlt = string.Empty;

//    for (int i = 0; i < size; i++)
//        rlt += string.Empty + Convert.ToChar((int)'a' + random.Next(0, 26));

//    return rlt;
//}
//List<string> Perebor(string value, string result)
//{
//    if (value == string.Empty)
//    {
//        if (result != string.Empty)
//            return new List<string>() { result };
//        return new();
//    }

//    List<string> trn = new();
//    for (int i = 0; i < value.Length; i++)
//    {
//        string substr = string.Empty;
//        if (i != 0)
//            substr += value.Substring(0, i);
//        if (i + 1 <= value.Length - 1)
//            substr += value.Substring(i + 1);
//        trn.AddRange(Perebor(substr, result + value[i]));
//    }
//    return trn;
//}

//var size = random.Next(5, 20);
//List<string> strings = new();

//for (int i = 0; i < size; i++)
//    strings.Add(Generate());

//for (int i = 0; i < size; i++)
//{
//    var list = Perebor(strings[i], string.Empty);
//    list.Sort();

//    Console.WriteLine($"{strings[i]}: [{string.Join(",", list.AsEnumerable().Distinct())}]");
//}
#endregion
#region Фибоначи, не работает с ультрабольшими числами
//int n = 18867;
//ulong a = 0;
//ulong b = 1;
//ulong Output = 1;
//if (n >= 1) for (int i = 0; i < n; i++)
//    {
//        ulong temp = a;
//        a = b;
//        b = temp + b;
//         Output += b;
//    }
//else Output = 4;
//Output *= 4;
//Console.WriteLine(Output);
//Console.ReadLine();
#endregion
#region Расшифровка
//static int FoundNumber(char T, string Temporary)
//{
//    for (int i = 0; i < Temporary.Length; i++)
//            if (Temporary[i] == T) return i;
//    return -1;
//}

//string Task = "EBG13 rknzcyr.";
//string Input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//string Output = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
//string Result = string.Empty;

//for (int i = 0; i < Task.Length; i++)
//    {
//        int Check = FoundNumber(Task[i], Input);
//        if (Check != -1) Result += Output[Check];
//        else Result += Task[i];
//    }
//Console.WriteLine(Result);
//Console.ReadLine();
#endregion
#region Делает максимальное число из цифр представленного числа
//long n = 2017;
//List<long> numbers = new();
//string Temporary = Convert.ToString(n);

//foreach (var temp in Temporary)
//    if (temp != '0') numbers.Add(Convert.ToInt32(temp) - 48);
//    else numbers.Add(0);

//numbers.Sort();
//numbers.Reverse();
//long Result = 0;

//foreach (var i in numbers)
//    Result = (Result * 10) + i;
//if (Result == n) Result = -1;

//Console.WriteLine(Result);
//Console.ReadLine();
#endregion
#region Задача с кубиками
//int Check1 = 0; int Check2 = 0; int Check3 = 0; int Check4 = 0; int Check5 = 0; int Check6 = 0;
//int Score = 0;
//int[] dise = new int[] { 2, 3, 4, 6, 2 };
//foreach (int temp in dise)
//{
//    if (temp == 1) { Check1++; continue; }
//    if (temp == 2) { Check2++; continue; }
//    if (temp == 3) { Check3++; continue; }
//    if (temp == 4) { Check4++; continue; }
//    if (temp == 5) { Check5++; continue; }
//    if (temp == 6) { Check6++; continue; }
//}
//    if (Check1 >= 3) { Check1 -= 3; Score += 1000; }
//    if (Check2 >= 3) { Check2 -= 3; Score += 200; }
//    if (Check3 >= 3) { Check3 -= 3; Score += 300; }
//    if (Check4 >= 3) { Check4 -= 3; Score += 400; }
//    if (Check5 >= 3) { Check5 -= 3; Score += 500; }
//    if (Check6 >= 3) { Check6 -= 3; Score += 600; }

//if (Check1 >= 1) Score += Check1 * 100;
//if (Check5 >= 1) Score += Check5 * 50;

//Console.WriteLine(Score);
//Console.ReadLine();
#endregion
#region Доделать https://www.codewars.com/kata/5324945e2ece5e1f32000370/train/csharp 
string a = "999999999999";
string b = "45609999999";
string max = string.Empty;
string min = string.Empty;

if (a.Length > b.Length) { max = a; min = b; }
else { max = b; min = a; }

int CheckZero = max.Length - min.Length;

List<int> maxlist = new List<int>(max.Length);
List<int> minlist = new List<int>(max.Length);
List<int> Result = new List<int>();

foreach (int temp in max)
    maxlist.Add(temp - 48);
foreach (int temp in min)
{
    if (CheckZero != 0) while (CheckZero != 0) { minlist.Add(0); CheckZero--; }
    minlist.Add(temp - 48);
}

for (int i = 0; i < maxlist.Count; i++)
    Result.Add(maxlist[i] + minlist[i]);

Result.Reverse();
for (int i = 0; i < Result.Count - 1; i++)
{
    if (i != Result.Count - 1) while (Result[i] >= 10) { Result[i + 1] += 1; Result[i] -= 10; }
    else if (Result[i] >= 10) { Result.Add(0); while (Result[i] >= 10) { Result[i + 1] += 1; Result[i] -= 10; } }
}
Result.Reverse();


string Output = string.Empty;
foreach (var temp in Result)
Output += temp.ToString(); 

Console.WriteLine(Output);
Console.ReadLine();
#endregion















