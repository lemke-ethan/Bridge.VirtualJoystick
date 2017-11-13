using Bridge.Html5;
using System;

namespace Bridge.VirtualJoystick.Models
{
    /// <summary>
    /// Virtual Joystick options.
    /// </summary>
    /// <remarks>
    /// All are optional.
    /// </remarks>
    [External]
    [ObjectLiteral]
    [Namespace(false)]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public class VirtualJoystickOptionsModel
    {
        #region Public Properties

        /// <summary>
        /// Function that checks if the coordinate is valid.
        /// </summary>
        /// <remarks>
        /// Defaults to a function that returns true.
        /// </remarks>
        public Func<int, int, bool> CheckValid { get; set; }

        /// <summary>
        /// The DOM element on which we display the joystick.
        /// </summary>
        /// <remarks>
        /// Defaults to the <see cref="Document.Body"/>.
        /// </remarks>
        public HTMLElement Container { get; set; }

        /// <summary>
        /// The stroke style of the joystick.
        /// </summary>
        /// <remarks>
        /// Defaults to the color cyan.
        /// </remarks>
        public Union<string, CanvasGradient, CanvasPattern> StrokeStyle { get; set; }

        /// <summary>
        /// Hides the joystick base.
        /// </summary>
        /// <remarks>
        /// Defaults to false.
        /// </remarks>
        public bool StickBaseHidden { get; set; }

        /// <summary>
        /// The radius of the joystick stick.
        /// </summary>
        /// <remarks>
        /// Defaults to 40.
        /// </remarks>
        public int StickDisplayRadius { get; set; }

        /// <summary>
        /// The radius of the joystick base.
        /// </summary>
        /// <remarks>
        /// Defaults to 60.
        /// </remarks>
        public int StickBaseDisplayRadius { get; set; }

        /// <summary>
        /// The element to use for the joystick stick.
        /// </summary>
        /// <remarks>
        /// Defaults to an <see cref="HTMLCanvasElement"/>.
        /// </remarks>
        public HTMLElement StickElement { get; set; }

        /// <summary>
        /// The element to use for the joystick base.
        /// </summary>
        /// <remarks>
        /// Defaults to an <see cref="HTMLCanvasElement"/>.
        /// </remarks>
        public HTMLElement BaseElement { get; set; }

        /// <summary>
        /// Indicates if the joystick base should be stationary.
        /// </summary>
        /// <remarks>
        /// Defaults to false.
        /// </remarks>
        public bool StationaryBase { get; set; }

        /// <summary>
        /// The joystick base X coordinate.
        /// </summary>
        /// <remarks>
        /// Defaults to 0.
        /// </remarks>
        public int BaseX { get; set; }

        /// <summary>
        /// The joystick base Y coordinate.
        /// </summary>
        /// <remarks>
        /// Defaults to 0.
        /// </remarks>
        public int BaseY { get; set; }

        /// <summary>
        /// Limit the joystick's travel.
        /// </summary>
        /// <remarks>
        /// Defaults to false.
        /// </remarks>
        public bool LimitStickTravel { get; set; }

        /// <summary>
        /// The max distance the joystick stick can travel from the center of the joystick.
        /// This is used by <see cref="LimitStickTravel"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to 100.
        /// </remarks>
        public int StickRadius { get; set; }

        #endregion
    }
}
