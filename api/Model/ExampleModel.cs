using FluentValidation;

namespace api
{
    public enum ExampleEnum
    {
        Test = 1
    }

    public class ExampleCommand
    {
        public ExampleEnum Type { get; set; }
    }

    public class ExampleModelValidator : AbstractValidator<ExampleCommand>
    {
        public ExampleModelValidator()
        {
            RuleFor(x => x.Type)
                .IsInEnum();
        }
    }
}
