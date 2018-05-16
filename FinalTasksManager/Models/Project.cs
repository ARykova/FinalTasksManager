using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FinalTasksManager.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public List<Task> Tasks { get; set; }

        public bool IsCompleted
        {
            get
            {
                return Tasks.All(task => task.IsCompleted);
            }
        }

        public ProjectLock Lock { get; set; }
    }
}
