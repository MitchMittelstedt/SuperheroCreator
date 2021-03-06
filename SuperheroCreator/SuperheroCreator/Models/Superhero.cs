﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroCreator.Models
{
    public class Superhero
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgoName { get; set; }
        public string PrimarySuperheroAbility { get; set; }
        public string SecondSuperheroAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}