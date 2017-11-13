using Bridge.VirtualJoystick.Models;
using System;

namespace Bridge.VirtualJoystick
{
    /// <summary>
    /// The virtual joystick.
    /// </summary>
    [External]
    [Namespace("window")]
    [Convention(Target = ConventionTarget.All, Notation = Notation.LowerCase)]
    public class VirtualJoystick
    {
        #region Constructor

        /// <summary>
        /// Create a new joystick.
        /// </summary>
        /// <param name="options">The joystick options.</param>
        [Template("new window.virtualJoystick.default({options})")]
        public VirtualJoystick(VirtualJoystickOptionsModel options = null) {}

        #endregion

        #region Public Methods

        /// <summary>
        /// Listen on the given event with the given listener.
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="eventListener">The event listener</param>
        /// <returns>The joystick.</returns>
        public VirtualJoystick AddEventListener(string eventName, Delegate eventListener)
        {
            return default(VirtualJoystick);
        }

        #endregion
    }
}
