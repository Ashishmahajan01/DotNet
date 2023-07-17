using HR;
using System.Collections.Generic;
using ICC;
int [] marks={45,65,67,67,34};
Array.Sort(marks);
Array.Reverse(marks);
string [] names={"ravi", "Shiv", "Reena"};
Person [] people={
    new Person{ FirstName="Shaan", LastName="Varma"},
    new Person{ FirstName="Shanti", LastName="Rege"},
    new Person{ FirstName="Rajiv", LastName="Manohar"},
} ;


Person p1=people[1];
foreach( Person p in people){
    Console.WriteLine(p);
}

//Rectangular Array:

int [,] matrix= new int[2,3]{
                            {34,56,87},
                            {87,45,67}
                    };
for(int i=0;i<=2; i++){
    for(int j=0;j<=3;j++){
        Console.WriteLine(matrix[i,j]);
    }
}

//Jagged Array
//Array of Array
int [][] dacMarks=new int[3][];
dacMarks[0]=new int[4]{34,65,45,34};
dacMarks[1]=new int[3]{76,45,34};
dacMarks[2]=new int[]{76,89,76,45,34,34,56};



List<Person> students=new List<Person>();
students.Add( new Person{ FirstName="Ramesh", LastName="Patil"});
students.Add( new Person{ FirstName="Chirag", LastName="Pande"});

Dictionary<string,Person> pgDacStudents=new Dictionary<string, Person>();
pgDacStudents.Add("ceo",new Person{ FirstName="Rajan", LastName="Shelar"});
pgDacStudents.Add("cto",new Person{ FirstName="Meena", LastName="Nene"});

Person pceo=pgDacStudents["ceo"];


Stack<string> callerStudents=new Stack<string>();
callerStudents.Push("Chaitanya");
callerStudents.Push("Minal");
callerStudents.Push("Raj");

string theStudent=callerStudents.Pop();

//It there is a need  where 
//reference of object behave like an array

Team teamIndia=new Team();
Player thePlayer=teamIndia[1];
//thePlayer.Name="Manish";
teamIndia[1]=new Player{Name="VVS Laxman",Score=89890};
Player thePlayer1=teamIndia[1];


//Type casting

Player pp=new Player{Name="Mitali Sharma",Score=8989};
object o=pp; //Implicit Typecasting

Player gg=(Player)o; //explicit Typecasting

Player kk=o as Player;

if(kk is Player){

}
else{
    
}




