
string xy = Console.ReadLine()??"0 0";

int x = Convert.ToInt32(xy.Split(" ")[0]);
int y = Convert.ToInt32(xy.Split(" ")[1]);



int result = (x * y) / 2;


Console.WriteLine(result);