﻿using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı 3 karekterden az olamaz");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adı 50 karekterden uzun olamaz");
        }
    }
}
