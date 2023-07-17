using HR;
Console.WriteLine("Before Person object is created....");
//Apply Disposing Technique
using(Person p1=new Person{ FirstName="Raj", LastName="Mane"})
{

    Console.WriteLine(p1);

}

Console.WriteLine("After person work is finished....");
//...........
//...........

//........................

GC.Collect();



