﻿namespace MultiShop.Message.Dtos
{
    public class ResultSendBoxMessageDto
    {
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public bool IsRead { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
