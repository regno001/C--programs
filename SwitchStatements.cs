using System;
class SwitchMethod{
public static void Main(){
char ch='A';
switch(ch)
{
case 'A':
case 'E':
case 'I':
case 'O':
case 'U':
Console.WriteLine("Vovels");
break;
default:
Console.WriteLine("Consonents");
break;
}
}
}
