using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;


namespace kursuppgift
{
    class Functions
    {
        // Funktion som skriver ut listan
        public static void printOutList() 
        {
            Console.WriteLine("\n\t\tVälkommen till Funktionstestprogram\n");
            Console.WriteLine("1-Funktion som skriver ut ”Hello World” i konsolen.\n" +
                "2-Funktion som tar in input från användaren och sedan skriver ut (Förnamn, Efternamn, Ålder).\n" +
                "3-Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen.\n" +
                "4-Funktion för att skriva ut dagens datum.\n" +
                "5-Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.\n" +
                "6-Funktion som genererar att slumpmässigt tal mellan 1 och 100,användaren ska gissa tale.\n" +
                "7-Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken.\n" +
                "8-Funktion där en fil läses in från hårddisken.?\n" +
                "9-Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur, upphöjt till 2 och upphöjt till 10.\n" +
                "10-Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.\n" +
                "11-Funktion som skapar två arrayer.Första fylls med slumpmässiga tal.Andra fylls från den första i stigande ordning.\n" +
                "12-Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom eller inte.\n" +
                "13-Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.\n" +
                "14-Funktion som sorterar ett antal värden (komma-separerade siffror) och skrivs ut efter udda och jämna värden.\n" +
                "15-Funktion där användaren skriver in ett antal värden(komma-separerade siffor) som sedan adderas och skrivs ut.\n" +
                "16-Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare med slumpmässiga värden för Hälsa, Styrka och Tur.\n"+
                " \t ********** eller tryck på 0 för att avsluta programmet! **********\n ");
            Console.WriteLine(" Skriv numret på metoderna du vill testa eller tryck på 0 för att avsluta\n");
        }
        /// <summary>
        /// fn1 - Funktion som skriver ut ”Hello World” i konsolen
        /// </summary>
        // 
        public void fn1()
        {
            Console.WriteLine("-+-+-+- Testing Funktion no.1 -+-+-+-\n" +
                "Hello World");
        }

        /// <summary>
        /// fn2 - Funktion som tar in input från användaren och sedan skriver ut (Förnamn, Efternamn, Ålder)
        /// </summary>

        public void fn2()
        {
            string firstName, lastName, age;

            Console.WriteLine("T-+-+-+- Testing Funktion no.2 -+-+-+-\n" +
                " Vad har du för förnamn ? : ");
            try
            {
                firstName = Console.ReadLine();
                while (hasDigit(firstName))
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Namnet måste bara innehålla tecken. Försök igen!! ");
                    Console.BackgroundColor = default;
                    Console.WriteLine("Vad har du för förnamn ? : ");
                    firstName = Console.ReadLine();
                }

                Console.WriteLine("Vad har du för efternamn ? : ");
                lastName = Console.ReadLine();
                while (hasDigit(lastName))
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Efternamet måste bara innehålla tecken. Försök igen!! ");
                    Console.BackgroundColor = default;
                    Console.WriteLine("Vad har du för Efteramn ? : ");
                    lastName = Console.ReadLine();
                }

                Console.WriteLine("Hur gammal är du ? : ");
                age = Console.ReadLine();
                while (hasChar(age))
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ålder måste bara innehålla tal. Försök igen!! ");
                    Console.BackgroundColor = default;
                    Console.WriteLine("Hur gammal är du ? : ");
                    age = Console.ReadLine();
                }

                Console.WriteLine($"Hello {firstName + " " + lastName} , Du är {age} år gammal ");
            }


            catch (Exception e)
            {
                Console.WriteLine("Något gått fel ); 'fel datainmatning' försök igen !!\n" + e);
            }
        }

        /// <summary>
        /// fn3 - Funktion som ändrar färgen på texten i konsolen
        /// </summary>  
        public void fn3()
        {
            Console.WriteLine("-+-+-+- Testing Funktion no.3 -+-+-+-\n");
            Random random = new Random();

            if (Convert.ToInt32(Console.ForegroundColor) == 7)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(15);
                Console.WriteLine("Slumpmässig Textfärg Appliceras !");
            }
            else
            {
            Console.ResetColor();
            Console.WriteLine("Originalfärg Appliceras !");
            }
        }

        /// <summary>
        ///fn4 -  Funktion för att skriva ut dagens datum
        /// </summary>
        public void fn4()
        {

            Console.WriteLine("-+-+-+- Testing Funktion no.4 -+-+-+-\n" +
                "Dagens datum är : " + DateTime.Now.ToString("dddd, dd MMMM yyyy")+ "  Klockan är : "+ DateTime.Now.ToString("HH:mm")) ;
        }

        /// <summary>
        ///fn5 -  Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.
        /// </summary>
        public void fn5()
        {
            string num1, num2;
            Console.WriteLine("-+-+-+- Testing Funktion no.5 -+-+-+-\n" +
                "Ange det första numret : ");
            try
            {
                num1 = Console.ReadLine();
                while (hasChar(num1))
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numret måste bara innehålla tal. Försök igen!! ");
                    Console.BackgroundColor = default;
                    Console.WriteLine("Ange det första numret : ");
                    num1 = Console.ReadLine();
                }
                Console.WriteLine("Ange det andra numret : ");
                num2 = Console.ReadLine();
                while (hasChar(num2))
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numret måste bara innehålla tal. Försök igen!! ");
                    Console.BackgroundColor = default;
                    Console.WriteLine("Ange det andra numret : ");
                    num2 = Console.ReadLine();
                }

                if (Convert.ToInt32(num1) == Convert.ToInt32(num2))
                    Console.WriteLine($"Första numret {num1} och Andra numret {num1} är lika!");
                else if (Convert.ToInt32(num1) > Convert.ToInt32(num2))
                    Console.WriteLine($" Första numret {num1} Är störst!");
                else
                    Console.WriteLine($" Andra numret {num2} Är störst!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Något gått fel ); 'fel datainmatning' försök igen !!\n" + e);
            }
        }

        /// <summary>
        ///fn 6 - Funktion som genererar att slumpmässigt tal mellan 1 och 100,användaren ska gissa tale.
        /// </summary>
        public void fn6()
        {
            int count = 1;
                string userInput;
            Console.WriteLine("-+-+-+- Testing Funktion no.6 -+-+-+-\n");
            Random random = new Random();
           int randomNum= random.Next(0,101);

            try
            {
                do
                {
                    Console.WriteLine($"Ange ett nummer för att gissa det slumpmässiga värdet : ");
                    userInput = Console.ReadLine();
                    while ((hasChar(userInput)) || (Convert.ToInt32(userInput) <= 0) || (Convert.ToInt32(userInput) >= 100))
                    {
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du måste skriva ett tal mellan 0 til 100. Försök igen!! ");
                        Console.BackgroundColor = default;
                        Console.WriteLine($"Försök ( {count} ), Ange ett nummer för att gissa det slumpmässiga värdet : ");
                        userInput = Console.ReadLine();
                    }

                    if (Convert.ToInt32(userInput) > randomNum)
                    {
                        Console.WriteLine($" {userInput} större än slumpmässigt tal, försök med ett mindre tal! ...Försöket no.({count})");
                        count++;
                    }
                    else if (Convert.ToInt32(userInput) < randomNum)
                    {
                        Console.WriteLine($" {userInput} mindre än slumpmässigt tal, försök med ett större tal! ...Försöket no. ({count})");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($" Bra jobbat !! Numret {userInput} är rätt, du gjorde ({count++}) Försök");
                        break;
                    }

                }
                while (Convert.ToInt32(userInput) != randomNum);
            }

            catch (Exception e)
            {
                Console.WriteLine("Något gått fel ); 'fel datainmatning' försök igen !!\n" + e);
            }
        }

        /// <summary>
        /////fn7 - Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken
        /// </summary>
        public void fn7() 
        {
            string fileName, text;
            Console.WriteLine("-+-+-+- Testing Funktion no.7 -+-+-+-\n" +
                " Skriv den text här , När du klart, tryck på retur :");
            try
            {
                text = Console.ReadLine();
                Console.Write("Texten sparas, skriv filnamn eller tryck på retur så kommer blir automatiskt.\n" +
                    "OBS! om du skriver samma namn på en befintlig fil raderas den gamla.\n" +
                    "File namn är : ");
                fileName = Console.ReadLine();
                if (fileName == "")
                    fileName = Convert.ToString(DateTime.Now.ToString("MM.dd.yyyy HH-mm"));
                string path = @"C:\Sparade textfiler\" + fileName + ".txt";


                if (!Directory.Exists(@"C:\Sparade textfiler"))
                    System.IO.Directory.CreateDirectory(@"C:\Sparade textfiler");

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                FileStream fileStream = File.Create(fileName);
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(text);
                streamWriter.Close();
                Console.WriteLine($"Allt är klar !! gå på C:\\Sparade textfiler mappen och kolla på {fileName} fil.");
            }

            catch(Exception e)
            {
                Console.WriteLine("Något gått fel ); 'fel datainmatning' försök igen !!\n" + e);
            }
            finally
            {   
            }
        }


        /// <summary>
        ///fn8 -  Funktion där en fil läses in från hårddisken
        /// </summary>
        public void fn8()
        {
            string fileName;
            
            Console.WriteLine("-+-+-+- Testing Funktion no.8 -+-+-+-\n" +
                "Här är en lista över alla textfiler i mappen Sparade textfiler\n");
            try
            {
                string[] files = Directory.GetFiles(@"C:\Sparade textfiler", "*.txt");

                foreach (var file in files)
                {
                    Console.WriteLine(file.Remove(0, 21));

                }
                fileName = Console.ReadLine();

                string path = @"C:\Sparade textfiler\" + fileName;


                if (!Directory.Exists(@"C:\Sparade textfiler"))
                {
                    System.IO.Directory.CreateDirectory(@"C:\Sparade textfiler");
                    Console.WriteLine("Error !!! försök först skapa en fil och placera den i C:\\Sparade textfiler ");
                    // throw as FileNotFoundException;
                }

                using (StreamReader filereader = new StreamReader(path))
                {
                    Console.WriteLine($"filen laddad klar, texten i {fileName} är : ");
                    Console.WriteLine(filereader.ReadToEnd());
                    Console.WriteLine("------------------------Slut på filen------------------------");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Något gått fel ); 'fel datainmatning' försök igen !!\n" + e);
            }

        }

        /// <summary>
        ///fn9 - Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur, upphöjt till 2 och upphöjt till 10.
        /// </summary>
        public void fn9()
        {
            decimal num;
            Console.WriteLine($"-+-+-+- Testing Funktion no.9 -+-+-+-\n" +
                "ange ett decimaltal, använd punkten '.' för bråken");
            try 
            {    
          num= Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("Roten av  "+num +"    : " + Math.Sqrt((double)num));
            Console.WriteLine("Upphöjt till 2  : " + Math.Pow((double)num, 2));
            Console.WriteLine("Upphöjt till 10 : " + Math.Pow((double)num,10));
            }
            catch (Exception e) 
            {
                Console.WriteLine("fel data, bara siffror och punkt är acceptabla, 'till exempel 3  ' 1.5 ' 17.8  .. försök igen !!!\n"+e);
            }
        }

        /// <summary>
        ///fn10 -  Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.
        /// </summary>
        public void fn10()
        {
            Console.WriteLine("-+-+-+- Testing Funktion no.10 -+-+-+-\n" +
                "\t\t...... Multiplikationstabell från 1 till 10 ...... ");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("\n..1..\t..2..\t..3..\t..4..\t..5..\t..6..\t..7..\t..8..\t..9..\t..10..");
            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine();
                for(int j = 1; j <= 10; j++)
                Console.Write($"{i}*{j}={i * j}\t");
            }
            Console.WriteLine("\n\n---------------------------------------------------------------------------------"); 
        }
        /// <summary>
        ///fn11 - Funktion som skapar två arrayer. Den första fylls med slumpmässiga tal. Den andra fylls med talen från den första i stigande ordning.
        /// </summary>
        public void fn11()
        {
           
            Console.WriteLine("-+-+-+- Testing Funktion no.11 -+-+-+-\n" + 
                "Programmet kommer att skapa en array och sedan sortera den från största till lägsta\n" +
                "Ange arrray storlek : ");
            string arraySize = Console.ReadLine();
            try
            {
                while (hasChar(arraySize) || (Convert.ToInt32(arraySize) <= 0 || Convert.ToInt32(arraySize) > 24))
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Måste bara innehålla tal från 1 upp till 24. Försök igen!! ");
                    Console.BackgroundColor = default;
                    Console.Write("Ange arrray storlek : ");
                    arraySize = Console.ReadLine();
                }
                int size = Convert.ToInt32(arraySize);
                int[] array = new int[size];
                Random random = new Random();
                Console.Write(" Array med slumpmässiga tal : ");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 99);
                    Console.Write(" | " + array[0] + " | ");
                }
                Console.WriteLine();

                Array.Sort(array);
                Console.Write(" Array i stigande ordning   : ");
                foreach (int num in array)
                {
                    Console.Write(" | " + num + " | ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Något gått fel ); försök igen !!\n" + e);
            }
        }

        /// <summary>
        ///f12 - Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom 
        /// (alltså samma ord från båda håll, såsom Anna eller radar.
        /// </summary>
        public void fn12()
        {

            Console.WriteLine("-+-+-+- Testing Funktion no.12 -+-+-+-\n" +
                "Ange ett ord eller nummer för att testa det om det är det palindrom eller inte : ");
            try
            {
                string input = Console.ReadLine();
                char[] txt = input.ToLower().ToCharArray();
                txt.Reverse();
                bool result = true;
                if (txt.Length == 2 && txt[0] != txt[1])
                    result = false;
                else
                {
                    for (int i = 1; i < txt.Length / 2; i++)
                    {
                        if (!(txt[i - 1] == txt[txt.Length - i]))
                        {
                            result = false;
                            break;
                        }
                    }
                }

                if (result == true)
                    Console.WriteLine($"{input} är palindrom");
                else
                    Console.WriteLine($"{input} är inte palindrom");

            }
            catch (Exception e)
            {
                Console.WriteLine("Något gått fel ); 'fel datainmatning' försök igen !!\n" + e);
            }

            /*in mathmatical way for numbers only
            
            string number = Console.ReadLine();

            while (hasChar(number))
            {
                Console.Beep();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Måste bara innehålla tal . Försök igen!! ");
                Console.BackgroundColor = default;
                Console.Write("Ange ett nummer för att testa det om det är det palindrom eller inte : ");
                number = Console.ReadLine();
            }
            int num = Convert.ToInt32(number);
            int result=0, reminder, quotient = num;
            while (quotient != 0)
            {
                reminder = quotient % 10;
                result = result * 10 + reminder;
                quotient = quotient / 10;
            }
            if (result == num)
                Console.WriteLine($"Numret {num} är palindrom !!");
            else 
                Console.WriteLine($"Numret {num} är inte palindrom !!");
            */
           

        }

        /// <summary>
        ///fn13 - Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.
        /// </summary>
        public void fn13()
        {
            string txt1, txt2;
            List<int> numberList1 = new List<int>();
            List<int> numberList2 = new List<int>();

            Console.Write("-+-+-+- Testing Funktion no.13 -+-+-+-\n" +
                "Ange den första texten : ");
            try
            {
                txt1 = Console.ReadLine();
                string[] splitTxt1 = Regex.Split(txt1, @"\D+");
                Console.Write("Ange den andra texten : ");
                txt2 = Console.ReadLine();
                string[] splitTxt2 = Regex.Split(txt2, @"\D+");

                for (int i = 0; i < splitTxt1.Length; i++)
                    if (!string.IsNullOrEmpty(splitTxt1[i]))
                        numberList1.Add(int.Parse(splitTxt1[i]));

                for (int i = 0; i < splitTxt2.Length; i++)
                    if (!string.IsNullOrEmpty(splitTxt2[i]))
                        numberList2.Add(int.Parse(splitTxt2[i]));

                var intersectNumbers = numberList1.Intersect(numberList2);
                if (!intersectNumbers.Any())
                    Console.WriteLine("Ingen siffror som är mellan de två inputse !!!");
                else
                {
                    Console.Write("Siffror som är mellan de två inputse är : ");
                    foreach (int x in intersectNumbers)
                        Console.WriteLine(x + " ,");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Något gått fel ); 'fel datainmatning' försök igen !!\n" + e);
            }
        }


        /// <summary>
        ///fn14 - Funktion där användaren skickar in ett antal värden (komma-separerade siffror)
        /// som sedan sorteras och skrivs ut efter udda och jämna värden. 
        /// </summary>
        public void fn14()
        {
            
            string input;
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
           // IList<string> numbers = new List<string>();


            Console.WriteLine("-+-+-+- Testing Funktion no.14 -+-+-+-\n" +
                "Ange ett antal värden med kommaseparerade tal 'till exempel 1,2,3,10,119,..' för att sortera : \n");
            try
            {
                input = Console.ReadLine();
                var numbers = (Regex.Split(input, @"\D+").Where(v =>!string.IsNullOrEmpty(v)).ToList());
                foreach (string x in numbers)
                {
                    Console.WriteLine("x = " +x);
                    int numToCheck = Int32.Parse(x);
                    if (numToCheck % 2 != 0)
                        oddNumbers.Add(numToCheck);
                    else
                        evenNumbers.Add(numToCheck);
                }
                if (oddNumbers.Count() != 0)
                {
                    Console.Write("\nUdda siffror Är :");
                    oddNumbers.ForEach(odd => Console.Write((odd) + ","));
                    Console.Write($"\t...Totalt udda tal är ({oddNumbers.Count()})...");
                }
                if (evenNumbers.Count() != 0)
                {
                    Console.Write("\nJämna siffror Är :");
                    evenNumbers.ForEach(even => Console.Write((even) + ","));
                    Console.Write($"\t...Totalt jämna tal är ({evenNumbers.Count()})...\n");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e+"fel data, bara siffror och komma är acceptabla, 'till exempel 1, 2, 3, 10, 119, ..', försök igen !!!\n");
            }
        }
        /// <summary>
        ///fn15 - Funktion där användaren skriver in ett antal värden(komma-separerade siffor) som sedan adderas och skrivs ut.
        /// </summary>
        public void fn15()
        {

            Console.WriteLine("-+-+-+- Testing Funktion no.15 -+-+-+-\n" +
                "Ange ett antal värden med komma-separerade tal 'till exempel 1,2,3,10,119,..' för att addera :");
            int total = 0; string txtNumsInOneLine = "";
            
            try 
            {
                string input = Console.ReadLine();
                var numbers = (Regex.Split(input, @"\D+").Where(v => !string.IsNullOrEmpty(v)).ToList());
                foreach (string x in numbers)
                {
                    txtNumsInOneLine += x+ "+";
                    int num = Int32.Parse(x);
                    total += num;
                }
                Console.WriteLine($"Summan av {txtNumsInOneLine.Remove(txtNumsInOneLine.Length-1,1)} = {total}");
            }
            catch(Exception e) 
            {
                Console.WriteLine("fel data, bara siffror och komma är acceptabla, 'till exempel 1, 2, 3, 10, 119, ..', försök igen !!!"+e);
            }
        }

        /// <summary>
        ///fn16 -  Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare. 
        /// Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur,
        /// som sparas i en instans av en klass.
        /// </summary>
        public void fn16(string character, string opponent)
        {
            Console.WriteLine("-+-+-+- Testing Funktion no.16 -+-+-+-\n");
          //  string ch
        }


        
        // Metod som stänger av programmet
        public static void closeApp()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stäng av Programmet, Hejdå!!!");
            Program.inputValidity = !Program.inputValidity;
            Thread.Sleep(3000);
        }

        // Metod som tester input om det har numeriskt värde
        static bool hasDigit(string s)
        {
           
                bool isDigit = s.Any(c => char.IsDigit(c));
                return isDigit;
              
        }

        // Metod som tester input om det har bokstäver 
        public static bool hasChar(string s)
        {

            bool isLetter = s.Any(c => char.IsLetter(c));
            return isLetter;

        }
    }
}
