
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace TodoApi.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
        public bool Done { get; set; }
    }
}
    
