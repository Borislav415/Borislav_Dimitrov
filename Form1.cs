using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;  
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;


namespace WindowsFormsApplication1
{

    public partial class Form1 : Form     // Инициализация на патриархалния клас "Form1 : Form".
    {
        [Serializable]                    // Клас атрибут "Serializable".
        public class Empty                // Публичен клас "Empty".
        {
            private string Input;         // Деклариране на променлива "Input" тип "string" с достъпност "private".
            public string input           // Деклариране на променлива "Input" тип "string" с достъпност "public".
            {
                get                       // Метод който взима данни и връща стойност.
                {
                    return Input;         // Метода връща стойността обратно на промеливата "Input"
                }
                set                       // Метода избира и присвоява стойността "value" от променливата "Input".
                {
                    Input = value;
                }
            }
            private string List1;
            public string list1
            {
                get
                {
                    return List1;
                }
                set
                {
                    List1 = value;
                }
            }
            private string Text2;
            public string text2
            {
                get
                {
                    return Text2;
                }
                set
                {
                    Text2 = value;
                }
            }
            private string List2;
            public string list2
            {
                get
                {
                    return List2;
                }
                set
                {
                    List2 = value;
                }
            }
            private string Text3;
            public string text3
            {
                get
                {
                    return Text3;
                }
                set
                {
                    Text3 = value;
                }
            }
            private string List3;
            public string list3
            {
                get
                {
                    return List3;
                }
                set
                {
                    List3 = value;
                }
            }
            [NonSerialized]                // Клас атрибут "NonSerialized", който не запазва данни.
            public string additionalIinfo; // Клас "additionalIinfo" от тип данни "string", публичен достъп.

        }

        double FirstNumber;               // Деклариране на променлива "FirstNumber" тип "double". Глобално ниво.
        double SecondNumber;              // Деклариране на променлива "SecondNumber" тип "double". Глобално ниво.
        string Operation;                 // Деклариране на променлива "Operation" тип "string". Глобално ниво.
        public Form1()
        {
            InitializeComponent();
                                          // Инициализация на компонентите.
        }
        int i1;                           // Деклариране на индекс "i1".
        decimal[] m = new decimal[100];   // Деклариране на динамичен масив р от 100 елемента.
        decimal[] p = new decimal[100];

        private void button1_Click(object sender, EventArgs e)  // Деклариране на бутон1 чрез функция.
        {
            decimal point;                // Деклариране на променливата от тип decimal "point".
            try
            {

                point = Convert.ToDecimal(textBox1.Text); // Метод за конвектиране на данни. 
                p[i1] = point;                            // Елемента на масив и неговия индекс "p [i1]" присвоява стойността на променливата "point".
                i1++;                                     // Индекс "i1" увеличава стойността си с една единица.
                listBox1.Items.Add(p[i1 - 1]);            // Метода за прехвърляне на данни от масив "p", чийто индекс "i1" намаля стойността си с една единица.  

            }
            catch (Exception) { }                         // Метод за хващане на изключения. Важи за "текст кутия 1".
            textBox1.Text = "0";
        }
        private double square(double A)                   // Структура на патриархалния клас "Form1",  "double square" от тип "double", приема един аргумент.
        {
            double Square;
            Square = Convert.ToDouble(A);                 // Метода коневектира и присвоява стойността "А".
            if (Square > 0)
            {
                Math.Sqrt(Square);                        // Мметода използва математическа библиотека за смятане на корен квадратен.
                return Convert.ToDouble(Math.Sqrt(Square)); // Връща стойността обратно "(Math.Sqrt(Square))".
            }
            else
            {

                return Convert.ToDouble(Math.Sqrt(Square));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)  // Деклариране на "текстбокс1" чрез функция.
        {

        }

        private void button2_Click(object sender, EventArgs e)  // Деклариране на бутон2 чрез функция.
        {
            int ch = 0;                                         // Деклариране на брояч на елементи в списъка "ch".
            List<decimal> lista = new List<decimal>();          // Деклариране на списък с елементи и типа данни, който е "decimal".

            foreach (decimal x in listBox1.Items)               // Цикъл "foreach" и нейната променлива "decimal x" присвояват данните от "списъчна кутия1".
            {
                lista.Add(Convert.ToDecimal(x));                // Метод за конвектиране в листа или списък с елементи от променливата "x".
            }
            lista.Sort();
            foreach (decimal a in lista)                         // Цикъл "foreach" и нейната променлива "decimal a" присвояват данните 
            // от сортирания списък "lista".           
            {

                ch++;                                            // Брояча "ch" увеличава стойността си с една единица.
                listBox2.Items.Add(a);                           // Метода "Items.Add" присвоява стойността от променливата "а" в "списъчна кутия 2" вече сортиран.
                textBox2.Text = Convert.ToString(ch);            // Метода  "Convert.ToString" конвектира данните на брояча "ch" тип интиджер в тип "string".


            }
            MessageBox.Show("Данните са сравнени !");            // Метод за извеждане на текстово съобщение.
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) // Деклариране на функция за "списъчна кутия 2".
        {

        }

        private void button3_Click(object sender, EventArgs e)               // Функция на "бутон 3".
        {

            listBox1.Items.Clear();                                // Метода "Items.Clear", изтрива данните от списъчните и текст кутиите.
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        public int i { get; set; }

        public int t { get; set; }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) //Функция за "списъчна 3".
        {


        }

        private void Chek_Click(object sender, EventArgs e)       // Бутон "Chek" деклариран чрез функция.
        {
            int num = 0;                                          // Деклариране на променлива от тип интиджер (брояч).
            List<decimal> lista = new List<decimal>();         // Деклариране на списъка с елементи и типа на данни, който е "decimal".

            foreach (decimal a in listBox2.Items)                 // Цикъл "foreach" и нейната променлива от тип "decimal x" присвояват данните от "списъчна кутия 2".
            {
                lista.Add(Convert.ToDecimal(a));                  // Метод за конвектиране на данни.

            }
            foreach (decimal b in lista)                          // Цикъл "foreach" и нейната променлива от тип "decimal b" присвояват данните от "lista".
            {

                decimal[] array = lista.ToArray();            // Деклариране на масив с име "array".
                if (b < 1)
                {
                    string v;                                    // Деклариране на променлива от тип  "string".
                    var listB = lista.FindAll(x => x < 1);       // Метод за намиране на еднакви елементи.
                    num++;                                       // Инициализация на брояча
                    listB.Add(Convert.ToDecimal(b));             // Конвектиране на данни от тип "вар" в тип "Decimal".

                    v = Convert.ToString(b);                     // Променливата от тип "стринг" "v", конвектира и присвоява стойността на променливата "b"(децимал).
                    listBox3.Items.Add(v);                       // Метод за извеждане на разултат чрез "списъчна кутия 3".
                }
                textBox3.Text = Convert.ToString(num);           // Метод за конвектиране на данни от тип "интиджер" в тип "стринг" (брояч).

            }

            MessageBox.Show("Данните от сравнението, показват че невронните мрежи са с най - добър резултат!"); // Текстово съобщение.
        }

        private void n1_Click(object sender, EventArgs e)          // Функция за деклариране на бутон "n1" (генерира се автоматично от системата).
        {
            if (textBox1.Text == "0" && textBox1.Text != null)     // Метод за сръвнение на данни.
            {
                textBox1.Text = "1";                               // Присвоява се стойността "1" в "текст кутия 1".
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";               // Метод  за копиране на данни(запазват се данните и не се губят).
            }
        }

        private void n2_Click(object sender, EventArgs e)          // Функция за деклариране на бутон "n1" (генерира се автоматично от системата).
        {
            if (textBox1.Text == "0" && textBox1.Text != null)     // Конструкцията "if " прави логическо сравнение.
            {
                textBox1.Text = "2";                               // "Текст кутия 1" присвоява стойността "2".
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";                // "Текст кутия 1" присвоява стойността "2".
            }
        }

        private void n3_Click(object sender, EventArgs e)           // Бутон "n3_Click". Отговаря на числото "3".
        {
            if (textBox1.Text == "0" && textBox1.Text != null)      // Конструкцията "if " прави логическо сравнение.
            {
                textBox1.Text = "3";                                // "Текст кутия 1" присвоява стойността "3".
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";                // "Текст кутия 1" присвоява стойността "3".
            }
        }

        private void n4_Click(object sender, EventArgs e)           // Бутон номер 4
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void n5_Click(object sender, EventArgs e)             // Бутон номер 5
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

        }

        private void n6_Click(object sender, EventArgs e)             // Бутон номер 6
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }



        }

        private void n7_Click(object sender, EventArgs e)            // Бутон номер 7
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }

        }

        private void n8_Click(object sender, EventArgs e)             // Бутон номер 8
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }

        }

        private void n9_Click(object sender, EventArgs e)            // Бутон номер 9
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }



        }

        private void n0_Click(object sender, EventArgs e)            // Бутон номер 0
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bc_Click(object sender, EventArgs e)            // Бутон "С"
        {
            textBox1.Text = "0";

        }

        private void ndot_Click(object sender, EventArgs e)         // Бутон "."
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bad_Click(object sender, EventArgs e)          // Бутон "+"
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);          // Променливата "FirstNumber " присвоява конвектираните данни(тип "Double") от "текст кутия 1".
            textBox1.Text = textBox1.Text;                          // Запазва въведената стойност от използвания предходен бутон.
            textBox1.Text = "0";
            Operation = "+";                                        // Променливата "Operation" от тип стринг извършва операцията събиране. 
        }

        private void bsub_Click(object sender, EventArgs e)         // Бутон "-" 
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text;
            textBox1.Text = "0";
            Operation = "-";                                         // Променливата "Operation" от тип стринг извършва операцията изваждане. 
        }

        private void bmult_Click(object sender, EventArgs e)         // Бутон"*"
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text;
            textBox1.Text = "0";
            Operation = "*";                                         // Променливата "Operation" от тип стринг извършва операцията умножение. 
        }

        private void bdiv_Click(object sender, EventArgs e)          // Бутон "/" деление
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text;
            textBox1.Text = "0";
            Operation = "/";                                         // Променливата "Operation" от тип стринг извършва операцията деление. 
        }

        private void bequal_Click(object sender, EventArgs e)        // Бутон " = " равно той извършва действията от събиране, изваждане, умножение и деление.
        {

            double Result;
            SecondNumber = Convert.ToDouble(textBox1.Text);
            if (Operation == "+")                                    // Метода извършва операция събиране.
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")                                    // Метода извършва операция изваждане.
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")                                     // Метода извършва операция умножение.
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "x^y")                                   // Метода извършва операция степенуване на числото "х" на степен "У" или ("х" на степен "n") .
            {                                                         // Въведеното число "х" се умножава толкова пъти на степен "n", колкото е самото число"х" по-себе си .
                double result = 1;
                int number = int.Parse(textBox1.Text);                // Метода присвоява стойността от текст кутията в променливата "number" в тип  "int".
                int power = int.Parse(textBox1.Text);                 // Метода присвоява стойността от текст кутията в променливата "power" в тип  "int".

                // Изчислява Abs само веднъж преди цикъл.
                for (int i = 1; i <= Math.Abs(power); ++i)
                    result *= number;                                 // Присвоява стойността от променливата "number" в променливата "result".

                if (power < 0)                                        
                    result = 1 / result;               
                Result = result;
                textBox1.Text = Convert.ToString(Result);             // Текст кутията присвоява и конвектира данните в тип "String" от променливата "Result",
                double result1;                                       // която е променлива от тип "double"
                result1 = Convert.ToDouble(textBox1.Text);

            }
            if (Operation == "x % y")                                // Деклариран е бутона "x % y". Изчислява се число "Х" от процента "У".
            {
                Result = (FirstNumber / SecondNumber * 100);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "/")                                    // Извършва процедурата деление "/".
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)    // Tекст кутия номер 3
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sqrt_Click(object sender, EventArgs e)        // Бутон корен квадратен "√"
        {

            double firstNum = Convert.ToInt32(textBox1.Text);
            double squareRoot = square(firstNum);
            textBox1.Text = "" + squareRoot;
            Operation = "√";

        }

        private void percentage_Click(object sender, EventArgs e)    // Деклариран е бутона "%", който извършва пресмятането.
        {


            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text;
            Operation = "%";
            textBox1.Text = (FirstNumber / 100).ToString("#0.00");

        }

        private void x_procent_y_Click(object sender, EventArgs e)   // Деклариран е бутона "x % y", който изчислява число "Х" от процента "У".
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text;
            textBox1.Text = "0";
            Operation = "x % y";
        }

        private void XdegreeY_Click(object sender, EventArgs e)    // Деклариран е бутона "x^y"
        {

            textBox1.Text = "0";
            Operation = "x^y";
        }

        private void Input_Click(object sender, EventArgs e)      // Деклариран е етикет с името "Input".
        {

        }



        private void Text2_Click(object sender, EventArgs e)     // Деклариран е етикет с името "Text2".
        { 

        }

        private void List3_Click(object sender, EventArgs e)     // Деклариран е етикет с името "List3".
        {

        }

        private void List1_Click(object sender, EventArgs e)     // Деклариран е етикет с името "List1".
        {

        }

        private void label2_Click(object sender, EventArgs e)    // Деклариран е етикет с името "List2".
        {
        

        }

        private void Text3_Click(object sender, EventArgs e)    // Деклариран е етикет с името "Text3".
        {

        }   
            

     
        private void label1_Click(object sender, EventArgs e)   // Деклариран е етикет с името "label1".
        {

        }

        private void button5_Click(object sender, EventArgs e)  // Деклариран е Бутонa "File open".
        {
            OpenFileDialog openFile = new OpenFileDialog();     // Декларира се класа  "OpenFileDialog" с името "openFile"
            openFile.InitialDirectory = "e:\\cpp";              // Метода инициализира и показва пътя на директорията.
            openFile.Filter = "text Files (*.txt)|*.txt|All files (*.*)|*.*"; // Метода " openFile.Filter" прочита текстовия файл (филтър).
            openFile.FileName = String.Format("File name.txt", textBox1.Text, textBox2.Text, textBox3.Text, listBox1.Items, listBox2.Items, listBox3.Items);
            // Променливата чете всички форматирани данни от текстовите и списъчните кутии.
            OpenFileDialog f = new OpenFileDialog();     // Декларира се класа "OpenFileDialog" с името "f".
            if (f.ShowDialog() == DialogResult.OK)       // Прави се сравнение между "f.ShowDialog()" и "DialogResult.OK"
            {
                listBox1.Items.Clear();                  // Метода изчиства всички елементи от списъчната кутия 1.

                List<string> lines = new List<string>();                  // Декларира се списък с името "lines" с тип данни "string".
                using (StreamReader r = new StreamReader(f.OpenFile()))   // Прочита данните от променливата "f.OpenFile".
                {
                    string line;                                          // Деклариране на променливата с името "line" от тип "string".
                    while ((line = r.ReadLine()) != null)                 // Метода връща съхраняваните данни в променливата "line".
                    {
                        listBox1.Items.Add(line);                         // Метода присвоява данните от променливата "line" в списъчна кутия 1.
                                         
                    }
                }
                MessageBox.Show("Programs open!");                         // Системно съобщение.

                Empty emp = new Empty();                                   // Инициализация на класа с името "Empty" и нейния аргумент "emp".

                BinaryFormatter bf = new BinaryFormatter();                // Инициализация на класа с името "BinaryFormatter" и нейния аргумент "bf".
                                                                           // Извършва бинарно форматиране на данни.
                FileStream fsin = new FileStream("empty.binary", FileMode.Open, FileAccess.Read, FileShare.None);
                // Метода "FileStream" и нейния аргумен с името "fsin" присвояват и прочитат бинарния файл. 
                try                                                        
                {
                    using (fsin)
                    {
                        emp = (Empty)bf.Deserialize(fsin);                   // Чрез метода се извършва десериализация на обекта, 
                                                                             // и резултата се присвоява от променливата "emp" на класа "Empty". 
                        textBox1.Text = emp.input;                           // присвояват се данните от текстовите и списъчните кутии.
                        listBox1.ToString();
                        listBox2.ToString();
                        listBox3.ToString();
                        textBox2.Text = emp.text2;
                        listBox2.Text = emp.list2;
                        textBox3.Text = emp.text3;
                        listBox3.Text = emp.list3;
                        MessageBox.Show("Object is Deserialize");

                    }
                }
                catch                                                        // Метод за улавяне на изключения.
                {
                    MessageBox.Show("An error has occured");                 // Ситемно съобщение.
                }
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)     // Бутона "file save" извършва записване на данни в текстов файл, името на проекта,
        {                                                          // бинарния файл на компонентите (списъчни и текстови кутии).
              SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            savefile.InitialDirectory = "e:\\cpp";
            savefile.FileName = String.Format("File name.txt",textBox1.Text, listBox1.Items, textBox2.Text, listBox2.Items, textBox3.Text, listBox3.Items);
            // Метода присвоява форматираните данни от тип "String" в тексов файл.
            savefile.DefaultExt = "*.txt*";
            savefile.Filter = "text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {

                const string sPath = "save.txt";
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath); // Метода записва данни от списъчните кутии.
                foreach (var item in listBox1.Items)                                 // Метода присвоява елементи от списъчна кутия 1.
                {
                    SaveFile.WriteLine(item);                            // Метода записва промеливата "item" и нейните елементи.
                }
                 
                    foreach (var item2 in listBox2.Items)
                    {
                        SaveFile.WriteLine(item2);
                    }
                    foreach (var item3 in listBox3.Items)
                    {
                        SaveFile.WriteLine(item3);
                    }

                    SaveFile.Close();
                    MessageBox.Show("Programs saved!");                   // Системно съобщение.


                    Empty emp = new Empty                                 // клас "Empty" и променливата "emp"
                    {
                        list1 = listBox1.ToString(),
                        list2 = listBox2.ToString(),
                        list3 = listBox3.ToString(),
                        input = textBox1.Text,
                        text2 = textBox2.Text,
                        text3 = textBox3.Text,
                    };
                    BinaryFormatter bf = new BinaryFormatter();            // Метод за бинарно форматиране на данни.

                    FileStream fsout = new FileStream("empty.binary", FileMode.Create, FileAccess.Write, FileShare.None);
                        // Метода извършва действие записване на бинарния файл.
                    try
                    {

                        using (fsout)
                        {
                            bf.Serialize(fsout, emp);                   // Метод за сериализиране.
                            MessageBox.Show("Object is serialized");    // Системно съобщение.   
                        }
                    }
                    catch                                               // Метод за улавяне на изключения.                           
                    {
                        MessageBox.Show("An Eror");
                    }
                }


            }
                  
        }
    }    




            
        
    


            
        
         

     
      
  
           

        

    
        
