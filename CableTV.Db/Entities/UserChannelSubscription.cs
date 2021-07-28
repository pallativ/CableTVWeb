﻿using System;

namespace CableTV.Db
{
    public class UserChannelSubscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ChannelId { get; set; }
        public Channel Channel { get; set; }
        public DateTime SubscribedDate { get; set; }
    }
}
