# StudentManagementSystem

```
using StudentManagementSystem;


int count = 0;
while (true)
{
	Menu();
	string enter = GetChoose().ToUpper();
	switch (enter)
	{
		case "1":
		case "E":
			AddStudent();
			break;
		case "2":
		case "L":
			ListStudent(StudentContext.Students);
			break;
		case "3":
		case "S":
			DeleteStudent();
			break;
		case "4":
		case "X":
			Exit();
			break;
		default:
			Console.WriteLine("Hatalı Seçim Yaptınız. Tekrar Seçin Yapınız");
			count++;

			break;
	}
	if (count == 5)
	{
		Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
		Environment.Exit(0);
	}
}



static void Menu()
{
	Console.WriteLine();
	Console.WriteLine("Öğrenci Yönetim Uygulaması");
	Console.WriteLine("1- Öğrenci Ekle (E)");
	Console.WriteLine("2- Öğrenci Listele (L)");
	Console.WriteLine("3- Öğrenci Sil (S)");
	Console.WriteLine("4- Çıkış (X)");
	Console.WriteLine();
}

static string GetChoose()
{
	Console.WriteLine();
	Console.Write("Seciminiz : ");
	string choose = Console.ReadLine();
	return choose;
}


static void AddStudent()
{
	Console.WriteLine("1- Öğrenci Ekle ----------");
	for (int i = StudentContext.Students.Count; i < StudentContext.Students.Count + 1; i++)
	{
		Console.WriteLine(i + 1 + ". Öğrencinin");
	}

	Console.Write("No:");
	int studentId = int.Parse(Console.ReadLine());
	Console.Write("Adı:");
	string studentName = Console.ReadLine();
	Console.Write("Soyadı:");
	string studentSurname = Console.ReadLine();
	Console.Write("Şubesi:");
	string branchName = Console.ReadLine();

	if (studentId == 0 || string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(studentSurname) || string.IsNullOrWhiteSpace(branchName))
	{
		Console.WriteLine("Eksik bilgi girdiniz. Tekrar bilgileri giriniz.");
		AddStudent();
	}

	Student newStudent = new Student();
	newStudent.Id = studentId;
	newStudent.Name = BigFirstLetter(studentName);
	newStudent.Surname = BigFirstLetter(studentSurname);
	newStudent.Branch = BigFirstLetter(branchName);

	Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz (E/H) : ");
	Console.WriteLine();
	string enter = GetChoose().ToUpper();
	if (enter == "E")
	{
		StudentContext.Students.Add(newStudent);
		Console.WriteLine("Öğrenci Eklendi.");
	}
	else
		Console.WriteLine("Öğrenci Eklenemedi");
}

static void ListStudent(List<Student> students)
{
	Console.WriteLine();
	Console.WriteLine("2- Öğrenci Listele-----------");
	AlignList(students);
	if (students.Count == 0) Console.WriteLine("Listede Öğrenci Bulunmamaktadır.");
}

static void DeleteStudent()
{
	Console.WriteLine("3- Öğrenci Sil ----------");
	Console.WriteLine("Silmek istediğiniz öğrencinin");
	Console.WriteLine("No: ");
	int id = int.Parse(Console.ReadLine());

	if (StudentContext.Students.Count == 0) Console.WriteLine("Listede silinecek öğrenci bulunamadı");

	Student student = null;

	foreach (var item in StudentContext.Students)
	{
		if (item.Id == id) student = item;
	}

	if (student != null)
	{
		Console.WriteLine("Adı: " + student.Name);
		Console.WriteLine("Soyadı:" + student.Surname);
		Console.WriteLine("Şubesi:" + student.Branch);
		Console.WriteLine();
		Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E / H) :  ");
		string enter = Console.ReadLine();
		if (enter.ToUpper() == "E")
		{
			StudentContext.Students.Remove(student);
			Console.WriteLine("Ogrenci Silindi");
		}
		else
			Console.WriteLine("Ogrenci Silinmedi");
	}
	else
	Console.WriteLine("Bu numaraya tanımlı öğrenci bulunamadı.");
	StudentContext.Students.Remove(student);
}

static string BigFirstLetter(string text)
{
	string bigFirstLetter = text.Substring(0, 1).ToUpper() + text.Substring(1);
	return bigFirstLetter;
}

static void AlignList(List<Student> students)
{
	if (students.Count > 0)
	{
		Console.WriteLine("Şube    No    Ad Soyad");
		Console.WriteLine("---------------------------------- ");
		foreach (var item in students)
		{
			Console.WriteLine(item.Branch + " " + item.Id.ToString().PadLeft(7, ' ') + " " + item.Name.PadLeft(item.Name.Length + 3, ' ') + " " + item.Surname.PadLeft(item.Surname.Length, ' '));
		}
		Console.WriteLine();
	}
}

static void Exit()
{
	Console.WriteLine("Cikmak istediginizden emin misiniz ? E/H ");
	string exit = Console.ReadLine();
	if (exit.ToUpper() == "E")
	{
		Console.WriteLine("Programdan Çıkılıyor.");
		Environment.Exit(0);
	}
}
```
