using System.ComponentModel.DataAnnotations;

namespace TaskManager.Core.ViewModels
{
    public class FilterTasks
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }

        [Display(Name ="Tylko zrealizowane")]
        public bool IsExecuted { get; set; }
    }
}