using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models {
    public class Scripture {
        public int ID { get; set; }

        //----------------------------------
        [StringLength(10, MinimumLength = 4), Required]
        public string Book { get; set; }

        //----------------------------------
        [Required]
        [Range(1,70)]
        public int Chapter { get; set; }

        //----------------------------------
        [Required]
        [Range(1, 90)]
        public string Verse { get; set; }

        //----------------------------------
        public string Notes { get; set; }

        //----------------------------------
        [Display(Name = "Today's Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TodayDate { get; set; }
    }
}
