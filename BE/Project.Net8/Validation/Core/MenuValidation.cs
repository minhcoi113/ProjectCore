using FluentValidation;
using Project.Net8.Models.Core;
using Project.Net8.Models.Permission;

public class MenuValidation : AbstractValidator<Menu>
{
    public MenuValidation()
    {
        RuleFor(model => model.Name)
            .NotEmpty().WithMessage("Tên không được để trống.")
            .NotNull().WithMessage("Tên không được để null.")
            .OverridePropertyName(x => x.Name);

        RuleFor(model => model.Path)
            .NotEmpty().WithMessage("Đường dẫn không được bỏ trống.")
            .OverridePropertyName(x => x.Path);

        RuleFor(model => model.Icon)
            .NotEmpty().WithMessage("Icon không được để trống.")
            .OverridePropertyName(x => x.Icon);
        

    }
}
