using FluentValidation;
using ViewModelDTO.Models.ViewModels;

namespace ViewModelDTO.Validations
{
    public class vehicleFeaturesValidator: AbstractValidator<vehicleFeaturesCreateVM>
    {
        public vehicleFeaturesValidator()
        {
            RuleFor(x => x.type).NotEmpty().NotEmpty().WithMessage("Lütfen araç tipini boş bırakmayınız");
            RuleFor(x => x.height).LessThan(3.15).WithMessage("Lütfen araç yüksekliğini 3.15 metreden az giriniz");
            RuleFor(x => x.width).LessThan(3.7).WithMessage("Lütfen araç genişliğini 3.7 metreden az giriniz");


        }
    }
}
