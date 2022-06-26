using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface ISystemKeyPad  : ISystemInputMethod
    {
        KeyPad Type { get; }
        void ClickOkButton();
        void ClickCancelButton();
        bool IsKeyPadActive();
    }
}
