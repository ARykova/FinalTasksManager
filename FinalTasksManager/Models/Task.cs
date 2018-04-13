using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTasksManager.Models
{
    public enum Priorites { high, normal, low }
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public Priorites Priority { get; set; } = Priorites.normal;

        public DateTime Deadline { get; set; }

        public List<Task> SubTasks { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}
