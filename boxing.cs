using System;
class boxing{
public static void Main(){
int a=10,b;
object o;
o=a;
Console.WriteLine("Boxing of the value "+o);
b=(int)o;
Console.WriteLine("Unboxing "+ b);
}
}