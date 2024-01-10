using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Timers;
using Microsoft.AspNetCore.Components;
using Timer = System.Threading.Timer;

namespace WriterEvent.Pages
{
    public class IndexModel : PageModel
    {
        public readonly Timer timer;
        public int days, hours, minutes, seconds;
        private DateTime signUpDate;

        private readonly ILogger<IndexModel> _logger;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            signUpDate = new DateTime(2024, 02, 01);
            Countdown();
            
            
        }

        private void Countdown()
        {
            var distance = signUpDate - DateTime.Now;
            days = distance.Days;
            hours = distance.Hours;
            minutes = distance.Minutes;
            seconds = distance.Seconds;
        }
    }
}
