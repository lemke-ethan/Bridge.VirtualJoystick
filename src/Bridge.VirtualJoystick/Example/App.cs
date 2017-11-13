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

            // Setup event name
            var moveEventName = "move";

            // Add an event listener to the move event
            var movementHandler = new Action<int, int>((x, y) =>
            {
                Console.WriteLine($"({x}, {y}), delta ({joystick.DeltaX()}, {joystick.DeltaY()})");
            });
            joystick.AddEventListener(
                moveEventName, 
                movementHandler);

            // Check if the move event has any event listeners
            if (joystick.HasListeners(moveEventName))
                Console.WriteLine("Move has event listeners. HasListeners check.");

            // Emit a move event
            joystick.Emit(moveEventName, 1, 1);

            // Check if the move event has some event listeners
            if (joystick.Listeners(moveEventName).Length > 0)
                Console.WriteLine("Move has event listeners. Listeners.Length check.");

            // Give the user 5 seconds to play with the joystick
            Bridge.Html5.Window.SetTimeout(
                () => 
                {
                    // Remove the move event listener
                    joystick.RemoveEventListener(moveEventName, movementHandler);
                    Console.WriteLine("Removed the move event listener.");
                    
                    // Give the user 5 seconds to play with the joystick
                    Bridge.Html5.Window.SetTimeout(
                        () =>
                        {
                            // Turn off all events
                            joystick.Off();
                            Console.WriteLine("Removed all event listeners.");

                            // Check if the move event has any event listeners
                            if (!joystick.HasListeners(moveEventName))
                                Console.WriteLine("Move event does not have any listeners.");

                            // Destroy the joystick
                            joystick.Destroy();
                            Console.WriteLine("No more joystick...");
                        },
                        5000);
                }, 
                5000);
        }

        #endregion
    }
}