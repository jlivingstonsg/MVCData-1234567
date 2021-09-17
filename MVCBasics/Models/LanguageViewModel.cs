﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Models
{
    public class LanguageViewModel
    {
        public List<Language> Languages = new List<Language>();
        public string SearchPhrase { get; set; }
        public CreateLanguageViewModel CreateLanguage { get; set; }
    }
}
