using NoobCoder;

//используйте эти массивы строк для инициализации объектов мухи и паука
var s1 = Console.ReadLine().Split(' ');
var s2 = Console.ReadLine().Split(' ');

//муха
CoorPoint whizz = new CoorPoint(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]), Convert.ToDouble(s1[2]));

//паук
CoorPoint spider = new CoorPoint(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]), Convert.ToDouble(s2[2]));

//Вывод ответа
if(whizz.Z == 0)
{
    Console.WriteLine("Расстояние: " + Math.Round(CoorPoint.GetLine(spider, whizz), 5));
    double h = spider.Z;
    spider.Z = 0;
    Console.WriteLine("Путь: " + Math.Round((CoorPoint.GetLine(spider, whizz) + h), 5));
}
else Console.WriteLine("Муха должна быть на полу!");