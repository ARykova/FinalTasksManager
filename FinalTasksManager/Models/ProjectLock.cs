using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalTasksManager.Models
{
    public class ProjectLock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int UserId { get; set; }

        public DateTime LockDateTime { get; set; }
    }
}
