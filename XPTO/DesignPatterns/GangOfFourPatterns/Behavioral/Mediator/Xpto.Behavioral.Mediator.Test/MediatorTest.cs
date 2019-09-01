using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xpto.Behavioral.Mediator.CSharpThreeDesignPatternsBook;
namespace Xpto.Behavioral.Mediator.Test
{
    class MediatorTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Should_Send_Message()
        {
            CSharpThreeDesignPatternsBook.Mediator m = new CSharpThreeDesignPatternsBook.Mediator();// Two from head office and one from a branch office 
            Colleague head1 = new Colleague(m, "John");
            Colleague branch1 = new Colleague(m, "David");
            Colleague head2 = new Colleague(m, "Lucy");

            head1.Send("Meeting on Tuesday, please all ack");
            branch1.Send("Ack"); // by design does not get a copy 
           
        }

        [Test]
        public void Should_Block_Messages()
        {
            CSharpThreeDesignPatternsBook.Mediator m = new CSharpThreeDesignPatternsBook.Mediator();// Two from head office and one from a branch office 
            Colleague head1 = new Colleague(m, "John");
            Colleague branch1 = new Colleague(m, "David");
            Colleague head2 = new Colleague(m, "Lucy");

            head1.Send("Meeting on Tuesday, please all ack");
            branch1.Send("Ack"); // by design does not get a copy 
            m.Block(branch1.Receive); // temporarily gets no messages 
            head1.Send("Still awaiting some Acks");           
        }
    }
}
