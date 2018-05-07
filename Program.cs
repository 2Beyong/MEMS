using System;

namespace MEMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node anode = new Node("name","protocol1",1);
            Inv  bnode = new Inv("GoodeWe","prot2",2);
            Load  cnode = new Load("load","protocol3",3);
            Console.WriteLine($"|{"Name",-10}|{"Port",10}|{"commProtocol",20}|");
            Console.WriteLine($"|{anode.name,-10}|{anode.port,10}|{anode.commProtocol,20}|");
            Console.WriteLine($"|{bnode.name,-10}|{bnode.port,10}|{bnode.commProtocol,20}|");
            Console.WriteLine(cnode.Get()+cnode.name+cnode.port);
        }

        
    }
}
