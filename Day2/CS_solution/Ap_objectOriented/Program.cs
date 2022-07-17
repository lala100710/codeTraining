 using Ap_objectOriented;
person p1 = new person("c001","john");
p1.Display();
Cube cube = new Cube(6, 6, 6);
Cube cube1 = new Cube(12,5,10);

Console.WriteLine("c1 area {0} c1 volume:{1}",cube.Area(),cube.Volume());
Console.WriteLine("c2 area {0} c2 volume:{1}", cube1.Area(), cube1.Volume());

Bmi bmi = new Bmi(155, 50);
Console.WriteLine(bmi.status());

