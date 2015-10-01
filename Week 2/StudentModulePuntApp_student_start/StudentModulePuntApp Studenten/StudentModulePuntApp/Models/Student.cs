﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace StudentModulePuntApp.Models
{
    public class Student
    {
        public String Email { get; set; }
        public String Voornaam
        {
            get
            {
                return Email.Split(new char[] { '.' })[0].Trim();
            }
        }
        public String Familienaam
        {
            get
            {
                string[] EmailArray = Email.Split(new char[] { '.' });
                string achternaam = "";

                if(EmailArray.Length == 4) achternaam = EmailArray[1].Split(new char[] { '@' })[0].Trim();
                else if (EmailArray.Length > 4) achternaam = (EmailArray[1] + ' ' + EmailArray[2]).Split(new char[] { '@' })[0].Trim();

                return achternaam;
            }
        }
        public String GeboortePlaats { get; set; }

        public override bool Equals(object obj)
        {
            //twee studente zijn gelijk indien hun email EN hun geboorteplaats gelijk is
            Student ander = obj as Student;
            if (ander == null) return false;

            return this.Email.Equals(ander.Email) &&
                this.GeboortePlaats.Equals(ander.GeboortePlaats);


        }

        public override int GetHashCode()
        {
            return this.Email.GetHashCode() + this.GeboortePlaats.GetHashCode();
        }
    }
}
