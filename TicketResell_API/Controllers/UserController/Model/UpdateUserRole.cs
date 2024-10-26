﻿using System.ComponentModel.DataAnnotations;

namespace TicketResell_API.Controllers.UserController.Model
{
    public class UpdateUserRole
    {
        [Required]
        public string? email {  get; set; }
        [Required]
        public string? newRole { get; set; }
    }
}
