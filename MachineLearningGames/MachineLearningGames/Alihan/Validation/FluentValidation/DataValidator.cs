using System.Data;
using FluentValidation;
using MachineLearningGames.Alihan.Entity;

namespace MachineLearningGames.Alihan.Validation.FluentValidation
{
    public class DataValidator : AbstractValidator<Customer>
    {
        public DataValidator()
        {
            RuleFor(x => x.Age).NotEmpty().GreaterThan(0).WithMessage("Lütfen yaş bilgisi kısmını kontrol ediniz!");
            RuleFor(x => x.Embarked).NotEmpty().WithMessage("Lütfen gidilecek yeri seçiniz!");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Lütfen cinsiyet bilgisini seçiniz");
            RuleFor(x => x.ParentOrChildren).NotEmpty().GreaterThan(-1).WithMessage("Lütfen ebeveyn ya da çocuk sayısını giriniz");
            RuleFor(x => x.SiblingsOrSpouse).NotEmpty().GreaterThan(-1)
                .WithMessage("Lütfen kardeş ya da eş sayısı giriniz!");
            RuleFor(x => x.TicketClass).NotEmpty().WithMessage("Lütfen bilet sınıfı bilgisini seçiniz!");
            RuleFor(x => x.TicketFare).NotEmpty().GreaterThan(-1)
                .WithMessage("Lütfen bilet ücreti bilgisini kontrol ediniz");

        }
    }
}
