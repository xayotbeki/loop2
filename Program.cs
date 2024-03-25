// Vazifalarni boshqarish uchun dastur yozing. Foydalanuvchi vazifalarni qo'shishi, o'chirishi va bajarilganligini belgilashi kerak.
//  Dastur vazifalar ro'yxatini va ularning holatini saqlashi kerak.
//  For loop, While loop yoki Forech-dan foydalaning, va Array yoki List-dan foydalaning.

List<string> vazifalar = new List<string>();
List<string> bVazifalar = new List<string>();


System.Console.WriteLine("Vazifalar boshqaruviga xush kelibsiz!");
while(true)
{
    System.Console.Write("0.exit\n1.vazifalar\n2.vazifa qo'shish\n3.vazifa o'chirish\n4.bajarilgan vazifalar\ntanlang: ");
    string tanlang = Console.ReadLine();
    if(tanlang == "0")
    {
        System.Console.WriteLine("Sog' bo'ling, salomat bo'ling");
        break;
    }
    else if(tanlang == "1")
    {
        System.Console.WriteLine("vazifalar\n");
        int i = 1;
        int len = vazifalar.Count();
        if(len != 0)
        {
            foreach (string vazifa in vazifalar)
            {
                System.Console.WriteLine($"{i}.{vazifa}");
            }
        }
        else
        {
            System.Console.WriteLine("vazifalar bo'sh");
        }
        System.Console.Write("qaysi vazifani bajardingiz\n0.exit\ntanlang: ");
        int t = Convert.ToInt32(Console.ReadLine());
        if(t != 0)
        {
            t = t - 1;
            bVazifalar.Add(vazifalar[t]);
            vazifalar.Remove(vazifalar[t]);
            System.Console.WriteLine("bajarildi");
        }
        
    }
    else if(tanlang == "2")
    {
        System.Console.Write("qanday vazifa qo'shmoqchisiz\nyozing: ");
        string yozing = Console.ReadLine();
        vazifalar.Add(yozing);
    }
    else if(tanlang == "3")
    {
        System.Console.WriteLine("vazifalar\n");
        
        for(int i = 0; i<vazifalar.Count(); i++)
        {
            System.Console.WriteLine($"{i+1}.{vazifalar[i]}");
        }
        
        System.Console.Write("qaysi vazifani o'chirmoqchisiz\nraqam tanlang: ");
        int raqamTanlang = Convert.ToInt32(Console.ReadLine());
        raqamTanlang = raqamTanlang - 1;
        vazifalar.Remove(vazifalar[raqamTanlang]);
        System.Console.WriteLine("muvoffaqiyatli o'chirildi");
    }
    else if(tanlang == "4")
    {
        System.Console.WriteLine("bajarilgan vazifalar\n");
        int i = 1;
        int len = bVazifalar.Count();
        if(len != 0)
        {
            foreach (string bVazifa in bVazifalar)
            {
                System.Console.WriteLine($"{i}.{bVazifa}");
            }
        }
        else
        {
            System.Console.WriteLine("Bajarilgan vazifalar bo'sh");
        }
        
    }
    else
    {
        System.Console.WriteLine("iltimos to'g'ri raqam tanlang!");
    }
}