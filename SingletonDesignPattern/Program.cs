using SingletonDesignPattern;

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

Console.WriteLine(object.ReferenceEquals(s1, s2));

Console.ReadKey();
