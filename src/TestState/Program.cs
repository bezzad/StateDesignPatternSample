using Servicialsoy.Core.Domain.Entities;
using Servicialsoy.Core.Services;

Console.WriteLine("Welcome Test Contract States \n");

Console.WriteLine("\n---------------------------------------------");
Console.WriteLine(" Draft --> Waiting --> Accepted --> InProgress --> Completed \n");
var c1 = new ContractContext(new Contract() { StartTime = DateTime.UtcNow.AddDays(-1) });
c1.Accept(1); // Draft   --> Waiting
c1.Accept(2); // Waiting --> Accepted
c1.Accept(2); // Accepted --> InProgress
c1.Complete(2); // InProgress --> Completed


Console.WriteLine("\n---------------------------------------------");
Console.WriteLine(" Draft --> Waiting --> Rejected \n");
var c2 = new ContractContext(new Contract());
c2.Accept(1); // Draft   --> Waiting
c2.Cancel(2); // Waiting --> Rejected


Console.WriteLine("\n---------------------------------------------");
Console.WriteLine(" Draft --> Waiting --> Accepted --> InProgress --> Aborted (No-Show) \n");
var c3 = new ContractContext(new Contract() { StartTime = DateTime.UtcNow });
c3.Accept(1); // Draft   --> Waiting
c3.Accept(2); // Waiting --> Accepted
c3.Accept(2); // Accepted --> InProgress
c3.Cancel(2); // InProgress --> Aborted


Console.WriteLine("\n---------------------------------------------");
Console.WriteLine(" Draft --> Waiting --> Accepted --> Cancelled \n");
var c4 = new ContractContext(new Contract() { StartTime = DateTime.UtcNow });
c4.Accept(1); // Draft   --> Waiting
c4.Accept(2); // Waiting --> Accepted
c4.Cancel(2); // Accepted --> Cancelled


Console.WriteLine("\n---------------------------------------------");
Console.WriteLine(" Draft --> Waiting --> Accept After Expiration --> Throw Exception X \n");
var c5 = new ContractContext(new Contract() { StartTime = DateTime.UtcNow.AddDays(-3)});
c5.Accept(1); // Draft   --> Waiting
c5.Accept(2); // Waiting --> Expired
try
{
    c5.Accept(2); // Expired --> × Throw exception
}
catch (Exception exp){
    Console.Error.WriteLine(exp.Message);
}

Console.ReadLine();