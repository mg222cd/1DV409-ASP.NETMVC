﻿using NextBirthdayEF.Validators;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NextBirthdayEF.Models
{
    [MetadataType(typeof(Birthday_Metadata))]
    public partial class Birthday
    {
        [ScaffoldColumn(false)]
        public int Age
        {
            get
            {
                return this.NextBirthdayDate.Year - this.Birthdate.Year;
            }
        }

        [ScaffoldColumn(false)]
        public int DaysUntilNextBirthday
        {
            get
            {
                return (this.NextBirthdayDate - DateTime.Today).Days;
            }
        }

        [ScaffoldColumn(false)]
        public DateTime NextBirthdayDate
        {
            get
            {
                var nextBirthday = new DateTime(DateTime.Today.Year,
                    this.Birthdate.Month, this.Birthdate.Day);
                if (nextBirthday < DateTime.Today)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                return nextBirthday;
            }
        }

        public class Birthday_Metadata
        {
            [Required(ErrorMessage = "Födelsedatum måste anges.")]
            [BeforeToday(ErrorMessage = "Ett födelsedatum tidigare än dagens datum måste anges.")]
            [DataType(DataType.Date)]
            [DisplayName("Födelsedatum")]
            public DateTime Birthdate { get; set; }

            [Required(ErrorMessage = "Namn måste anges.")]
            [DisplayName("Namn")]
            public string Name { get; set; }
        }

    }
}