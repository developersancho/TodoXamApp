using System;
using System.Collections.Generic;
using System.Text;

namespace TodoXamApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsDone { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
