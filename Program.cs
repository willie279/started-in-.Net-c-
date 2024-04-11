//https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//No es lo mismo a pesar de que la impresion en la salida deje el mismo valor. 
Console.WriteLine("false");
Console.WriteLine(false);
Console.WriteLine("27");
Console.WriteLine(27);

//Asignacion de variables
string firstName;
firstName = "mav.";
Console.WriteLine(firstName);
firstName = "Diana";
Console.WriteLine(firstName);
//Al declarar una variables lo mejor es asignarle su valor inmediatamente
int salonClase = 10;
Console.WriteLine(salonClase);

//Variables implicitas
var message = "cafe de la mañana";
Console.WriteLine(message);

//ejercicio
string Name = "Bob";
int message1 = 3;
var grados = 34.4f;
Console.Write("Hello, ");
Console.Write(Name);
Console.Write(" you have ");
Console.Write(message1);
Console.Write(" messages in your inbox.");
Console.Write("The temperature is  ");
Console.Write(grados );
Console.Write("celsius.\n");

//Secuencia de escape de caracteres 
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"pues!\"");
Console.WriteLine("c:\\destkop\\fotos\n");

//exercise
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\Invoice"); // la arroba hace omitir el uso de los escapes de caracteres. 

//literal de cadena textual
Console.WriteLine(@"   c:\desktop\fotos
    (this is where your code goes)");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// concatenacion de cadenas
string thirdName = "Gyllary";
string saludo = "hello  "+ thirdName;
Console.WriteLine(saludo);
thirdName = "luisa";
string saludoUno = "hola que tal";
string gretting = saludoUno + " " + thirdName + "!";
Console.WriteLine(gretting);

//evitar variables intermedias
Console.WriteLine(saludoUno + " " + thirdName + "!");
//interpolacion de cadenas
string grettting2 = "hola";
string firstName3 = "que tal";
string message3 = $"{grettting2} {firstName3}";
Console.WriteLine(message3);
string message4 = $"{grettting2} caro";
Console.WriteLine(message4);

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}");

string projectName = "first-project";
Console.WriteLine($@"c:\Output\{projectName}\data");  // me permite usar la interpolacion y el @ me permite usar la barra inversa sin escape

string projectName4 = "ACME";
Console.WriteLine($@"View English output:
    c:\exercise\{projectName4}\data.txt");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.Write($"\n {russianMessage}:\n\t" );
Console.WriteLine($"c:\\Exercise\\{projectName4}\\ru-RU\\data.txt");

// operaciones basicas
int firstNumber = 12;
int seconndNumber = 12;
Console.WriteLine(firstNumber + seconndNumber);
string firstName5 = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName5 + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName5 + " sold " + (widgetsSold + 7) + " widgets.");// se suma lo que esta dentro del ()
int sum = 7+4;
int difference = 7-4;
int product = 7*4;
int quotient = 7/4;
Console.WriteLine("sum:" + sum);
Console.WriteLine("difference:" + difference);
Console.WriteLine("product:" + product);
Console.WriteLine("div:" + quotient);
decimal decimalDiv = 7.0m/4;// para obtener resultados en decimal, al menos unos de los datos debe ser decimal
Console.WriteLine($"decimal div: {decimalDiv}");
int first = 4;
int second = 5;
decimal resultado = (decimal) first / (decimal)second;// trabajar con enteros y obtener numeros decimales
Console.WriteLine(resultado);
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");// si un numero es divisible pro otro
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
int value2 =0;
value2 += 10;
Console.WriteLine(value2);
value2 ++;
Console.WriteLine(value2);
value2 --;
Console.WriteLine(value2);
value2 *= 6;
Console.WriteLine(value2);
value2 -= 2;
Console.WriteLine(value2);

value2 ++;
Console.WriteLine(value2);
Console.WriteLine($"{value2++}");
Console.WriteLine(value2);
Console.WriteLine(++value2);
//ejercicio temperatura
int fahrenheit = 94;
decimal decimaldiv =5/9.0m;
Console.WriteLine($"the temperature is {(fahrenheit - 32)*decimaldiv} celisuis");
Console.WriteLine($"the temperature is " +  (fahrenheit - 32)*decimaldiv + " celisuis");
Console.WriteLine(3+1*5/2);
Console.WriteLine(34.40M);
int div = 5/2;
Console.WriteLine(div);

// ejericio de notas
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolaSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahiraSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong4 + jeong3 + jeong5;

decimal sophiaScore = (decimal) sophiaSum/currentAssignments;
decimal nicolasScore = (decimal) nicolaSum/currentAssignments;
decimal zahiraScore = (decimal) zahiraSum/currentAssignments;
decimal jeongScore = (decimal) jeongSum/currentAssignments;

Console.WriteLine("Student\t\tGrade\n");

Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolaSum);
Console.WriteLine("Zahira: " + zahiraSum);
Console.WriteLine("Jeong: " + jeongSum +"\n");

Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahira:\t\t"  + zahiraScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tB");

// ejericio de calculo de notas y creditos
string studentName = "Sophia Jhonson";
string course1tName = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal averageTotal = (decimal) totalGradePoints/totalCreditHours;
int leadingDigit = (int) averageTotal;// recuperar el enter
int firstDigit = (int) (averageTotal * 10) % 10;// recupera el primer digito luego del entero
int secondDigit = (int) (averageTotal * 100 ) % 10;//recupera el segundo digito luego del entero
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");


Console.WriteLine($"{course1tName}\t\t {course1Grade}\t\t {course1Credit}");
Console.WriteLine($"{course2Name}\t\t {course2Grade}\t\t {course1Credit}");
Console.WriteLine($"{course3Name}\t\t {course3Grade}\t\t {course1Credit}");
Console.WriteLine($"{course4Name}\t {course4Grade}\t\t {course1Credit}");
Console.WriteLine($"{course5Name}\t\t {course5Grade}\t\t {course1Credit}\n");
Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");