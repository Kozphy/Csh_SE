﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mvc_api.Models
{
    public partial class User
    {
        public User()
        {
            Articles = new HashSet<Article>();
        }

        public Guid id { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}