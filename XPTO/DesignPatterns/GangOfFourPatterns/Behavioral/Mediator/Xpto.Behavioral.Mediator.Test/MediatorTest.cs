using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xpto.Behavioral.Mediator.CSharpThreeDesignPatternsBook;
using Xpto.Behavioral.Mediator.Own;
using Xpto.Behavioral.Mediator.Own.Sample;
using Xpto.Behavioral.Mediator.Own.Sample.Repositories;
using Xpto.Behavioral.Mediator.Own.Sample.Request;

namespace Xpto.Behavioral.Mediator.Test
{
    class MediatorTest
    {
        private CSharpThreeDesignPatternsBook.Mediator _mediator;
        private Colleague _head1;
        private Colleague _branch;
        private Colleague _head2;

        [SetUp]
        public void Setup()
        {
            _mediator = new CSharpThreeDesignPatternsBook.Mediator();// Two from head office and one from a branch office 
            _head1 = new Colleague(_mediator, "John");
            _branch = new Colleague(_mediator, "David");
            _head2 = new Colleague(_mediator, "Lucy");
        }

        [Test]
        public void Should_John_Send_Meeting_Message()
        {
            _head1.Send("Meeting on Tuesday, please all ack");

            _head1.ReceivedMessage.Should().BeEmpty();
            _branch.ReceivedMessage.Should().Be("David received from John: Meeting on Tuesday, please all ack");
            _head2.ReceivedMessage.Should().Be("Lucy received from John: Meeting on Tuesday, please all ack");
        }

        [Test]
        public void Should_David_Send_Ack_Message()
        {
            _branch.Send("Ack");

            _branch.ReceivedMessage.Should().BeEmpty();
            _head1.ReceivedMessage.Should().Be("John received from David: Ack");
            _head2.ReceivedMessage.Should().Be("Lucy received from David: Ack");
        }

        [Test]
        public void Should_Block_Temporarily_David_Gets_Messages()
        {
            _mediator.Block(_branch.Receive); // temporarily gets no messages 
            _head1.Send("Still awaiting some Acks");
            _head1.ReceivedMessage.Should().BeEmpty();
            _branch.ReceivedMessage.Should().BeNull();
            _head2.ReceivedMessage.Should().Be("Lucy received from John: Still awaiting some Acks");

        }

        [Test]
        public void Should_Unblock_David_Gets_Messages()
        {
            _mediator.Block(_branch.Receive); // temporarily gets no messages 
            _head1.Send("Still awaiting some Acks");

            _mediator.Unblock(_branch.Receive); // open again 
            _head1.Send("Thanks all");

            _head1.ReceivedMessage.Should().BeEmpty();
            _branch.ReceivedMessage.Should().Be("David received from John: Thanks all");
            _head2.ReceivedMessage.Should().Be("Lucy received from John: Thanks all");
        }


        [Test]
        public void Should_Send_Event_To_Handlers()
        {
            var @event = new WhateverNotification("Ack");
            var mediator = new Own.Mediator();
            mediator.Publish(@event);

            WhateverNotificationHandler.ReceivedMessage.Should().Be("Ack");
            OtherNotificationHandler.ReceivedMessage.Should().Be("Ack");
        }



        [Test]
        public void Should_Buy_Product()
        {
            var product = new Product("Product A", 10, 5.0);
            var productRepository = new ProductRepository();
            productRepository.Insert(product);

            var request = new ProductBuyerRequest(product.Id, 2);
            var mediator = new Own.Mediator();

            mediator.Send(request);

            product = productRepository.Get(p => p.Id == product.Id).FirstOrDefault();

            product.Quantity.Should().Be(8);
        }
    }
}
