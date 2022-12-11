using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.Models
{
    
    public class Calendar : ChangeModel
    {
        public DateTime Date { get; set; }

        private bool _IsCurrentDate;
        public bool IsCurrentDate
        {
            get => _IsCurrentDate;
            set => SetProperty(ref _IsCurrentDate, value);
        }
    }
}
