using HotChocolate.Subscriptions;
using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars
{
    public class Subscription
    {
        public Review OnReview(Episode episode, IEventMessage message)
        {
            return (Review)message.Payload;
        }
    }
}
