using Bridge.VirtualJoystick.Models;
using System;

namespace Bridge.VirtualJoystick
{
    /// <summary>
    /// The virtual joystick.
    /// </summary>
    [External]
    [Namespace("window")]
    [Convention(Target = ConventionTarget.All, Notation = Notation.LowerCamelCase)]
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
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <returns>The joystick.</returns>
        public VirtualJoystick AddEventListener(string eventName, Delegate eventListener)
        {
            return default(VirtualJoystick);
        }

        /// <summary>
        /// Gets the delta X coordinate of the joystick.
        /// </summary>
        /// <returns>The delta X coordinate.</returns>
        public int DeltaX()
        {
            return default(int);
        }

        /// <summary>
        /// Gets the delta Y coordinate of the joystick.
        /// </summary>
        /// <returns>The delta Y coordinate.</returns>
        public int DeltaY()
        {
            return default(int);
        }

        /// <summary>
        /// Clean up the joystick.
        /// </summary>
        public void Destroy() {}

        /// <summary>
        /// Emits the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="arguments">The event's arguments.</param>
        /// <returns></returns>
        public VirtualJoystick Emit(string eventName, params object[] arguments)
        {
            return default(VirtualJoystick);
        }

        /// <summary>
        /// Check if the joystick has any event listeners.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <returns>true if the event has listeners, otherwise false.</returns>
        public bool HasListeners(string eventName)
        {
            return default(bool);
        }

        /// <summary>
        /// Get the array of event listeners for the event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <returns>The array of registered event listeners.</returns>
        public Delegate[] Listeners(string eventName)
        {
            return default(Delegate[]);
        }

        /// <summary>
        /// Removes all of the event listeners for all of the events.
        /// </summary>
        /// <returns>The joystick.</returns>
        public VirtualJoystick Off()
        {
            return default(VirtualJoystick);
        }

        /// <summary>
        /// Add a listener to the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <returns>The joystick.</returns>
        public VirtualJoystick On(string eventName, Delegate eventListener)
        {
            return default(VirtualJoystick);
        }

        /// <summary>
        /// Adds an event listener that will be invoked a single
        /// time then automatically removed.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <returns>The joystick.</returns>
        public VirtualJoystick Once(string eventName, Delegate eventListener)
        {
            return default(VirtualJoystick);
        }

        /// <summary>
        /// Removes all of the event listeners of the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <returns>The joystick.</returns>
        public VirtualJoystick RemoveAllListeners(string eventName)
        {
            return default(VirtualJoystick);
        }

        /// <summary>
        /// Removes the specified event listener from the event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <returns>The joystick.</returns>
        public VirtualJoystick RemoveEventListener(string eventName, Delegate eventListener)
        {
            return default(VirtualJoystick);
        }

        /// <summary>
        /// Removes the specified event listener from all events.
        /// </summary>
        /// <param name="eventListener">The event listener.</param>
        /// <returns>The joystick.</returns>
        public VirtualJoystick RemoveListener(Delegate eventListener)
        {
            return default(VirtualJoystick);
        }

        #endregion
    }
}
