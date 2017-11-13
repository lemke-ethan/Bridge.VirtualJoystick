namespace Bridge.VirtualJoystick
{
    [External]
    [Namespace("window")]
    [Convention(Target = ConventionTarget.All, Notation = Notation.LowerCase)]
    public class VirtualJoystick
    {
        #region Public Static Methods

        [Template("new window.virtualJoystick.default()")]
        public VirtualJoystick() {}

        #endregion
    }
}
