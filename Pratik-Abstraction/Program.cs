using Pratik_Abstraction;

Employee developer = new SoftwareDeveloper("Ahmet", "Yılmaz", "Yazılım");
Employee manager = new ProjectManager("Hasan", "Çıldıran", "Proje Yöneticisi");
Employee sales = new SalesRepresentative("Merve", "Tunç", "Satış");

developer.Gorev();
manager.Gorev();
sales.Gorev();

Console.ReadLine();

