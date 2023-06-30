var list  = new List<string>(){ "apple", "banana", "orange", "grape", "mango" };
var product = list.OrderByDescending(w=>w.Length).FirstOrDefault();
System.Console.WriteLine(string.Join(",",product));


