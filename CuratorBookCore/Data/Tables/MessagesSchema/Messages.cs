using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class Messages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public Users Sender { get; set; }


        public int? ReceiverId { get; set; }

        [ForeignKey("ReceiverId")]
        public Users Receiver { get; set; }


        public int? ReceiverGroupId { get; set; }

        [ForeignKey("ReceiverGroupId")]
        public Groups ReceiverGroup { get; set; }


        public string Text { get; set; }


        public DateTime SentDate { get; set; }


        public bool NotifyViaEmail { get; set; }
    }
}
