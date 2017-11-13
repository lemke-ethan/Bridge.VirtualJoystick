using Bridge.VirtualJoystick;
using Bridge.VirtualJoystick.Models;

namespace Example
{
    /// <summary>
    /// The example application
    /// </summary>
    public class App
    {
        #region Public Static Methods

        /// <summary>
        /// The entry point of the application
        /// </summary>
        public static void Main()
        {
            // Create a new joystick with some options
            var joystick = new VirtualJoystick(
                new VirtualJoystickOptionsModel {
                    StickBaseDisplayRadius = 20,
                    StickDisplayRadius = 10,
                    LimitStickTravel = false,
                    StickRadius = 30
                });
        }
     
        #endregion
    }
}