﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC.BL.Domain
{
  public class Ticket
  {
    public int TicketNumber { get; set; }
    public int AccountId { get; set; }
    [Required]
    [MaxLength(100, ErrorMessage="Er zijn maximaal 100 tekens toegestaan")]
    public string Text { get; set; }
    public DateTime DateOpened { get; set; }
    public TicketState State { get; set; }

    public ICollection<TicketResponse> Responses { get; set; }
  }
}
