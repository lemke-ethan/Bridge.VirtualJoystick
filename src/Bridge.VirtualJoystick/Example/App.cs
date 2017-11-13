using Bridge.VirtualJoystick;
using Bridge.VirtualJoystick.Models;
using System;

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

            // Add an event listener to the move event
            joystick.AddEventListener(
                "move", 
                new Action<int, int>((x, y) => 
                {
                    Console.WriteLine($"({x}, {y}), delta ({joystick.DeltaX()}, {joystick.DeltaY()})");
                }));

            // Check if the move event has any event listeners
            if (joystick.HasListeners("move"))
                Console.WriteLine("Move has event listeners.");

            // Emit a move event
            joystick.Emit("move", 1, 1);
        }
     
        #endregion
    }
}