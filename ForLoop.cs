using System;
class ForLoop{
public static void Main(){
Console.WriteLine("Enter the Number");
int n=int.Parse(Console.ReadLine());
for(int i=1;i<11;i++){
Console.WriteLine(n + " x " + i + " = " + n*i);
}
}
}
