﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Core.Models.Domains
{
    public class Category
    {
        public Category()
        {
                Tasks = new Collection<Task>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
