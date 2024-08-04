using FirstClassExample;
// 2 öğretmen nesnesi oluşturduk
Person teacher = new Person();
Person teacher2  = new Person();
// özellikleri atadık
teacher.FirstName = "Sertan";
teacher.LastName = "Bozkuş";
teacher.BirthOfDate = new DateOnly(1999,1,1);
teacher2.FirstName = "Aleyna";
teacher2.LastName = "Avcı";
teacher2.BirthOfDate = new DateOnly(2000, 1, 1);

// 2 Öğrenci Nesnesi oluşturduk
Person student = new Person();
Person student2 = new Person();
// Özellikleri atadık
student.FirstName = "Melike";
student.LastName = "Demir Göz";
student.BirthOfDate = new DateOnly(1992, 03, 17);
student2.FirstName = "Ahmet";
student2.LastName = "Göz";
student2.BirthOfDate = new DateOnly(1992,09,18);


Console.WriteLine("Öğretmen Bilgilerimiz  \n Ad Soyad: " + teacher.FirstName + " " + teacher.LastName + " \n Ad Soyad: " + teacher2.FirstName + " " + teacher2.LastName);

Console.WriteLine("Öğrenci Bilgilerimiz \n Ad Soyad: "+student.FirstName+" "+student.LastName+"\n Doğum Tarihi: "+ student.BirthOfDate+" \n Ad Soyad: "+ student2.FirstName+" "+student2.LastName+ "\n Doğum Tarihi: "+student2.BirthOfDate );
