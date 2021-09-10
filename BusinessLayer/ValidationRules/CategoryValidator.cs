using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            //kural oluşturuluyor.
            RuleFor(x => x.CategotyName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategotyDescription).NotEmpty().WithMessage("Açıklama alanını boş geçemezsiniz.");
            RuleFor(x => x.CategotyName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın.");
            RuleFor(x => x.CategotyName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girin.");
        }
    }
}
