Console.WriteLine("Введите имя пользоателя:");
string username = Console.ReadLine();
 
 if(username.ToLower() =="тоня")
 {
    Console.WriteLine("Ура,это же ТОНЯ!");
 }
 else
 {
    Console.Write("Привет, ");
    Console.WriteLine(username);

 }