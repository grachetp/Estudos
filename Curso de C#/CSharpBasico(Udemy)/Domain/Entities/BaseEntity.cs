﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime? _createdAt;
        public DateTime? CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = (value == null ? DateTime.Now : value); }
        }

        public DateTime? UpdateAt { get; set; }

    }
}
