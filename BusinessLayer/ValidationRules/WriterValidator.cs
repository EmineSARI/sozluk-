using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    
        public class WriterValidator : AbstractValidator<Writer>
        {
            public WriterValidator()
            {
                //kural oluşturuluyor.
                RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
                RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını  boş geçemezsiniz.");
                RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda alanını boş geçemezsiniz");
                RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girin.");
            }
        }
}
