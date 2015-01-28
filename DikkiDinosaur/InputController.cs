using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DikkiDinosaur
{
    public class InputController : IUpdateable
    {
        //private int _numberOfControllers = 0;
        private float _digitalStickDeadZone;

        // used to remember last state of the buttons
        private bool _buttonADown = false;
        private bool _buttonBDown = false;
        private bool _bButtonXDown = false;
        private bool _buttonYDown = false;
        private bool _buttonLeftShoulderDown = false;
        private bool _buttonRightShoulderDown = false;
        private bool _buttonStartDown = false;
        private bool _buttonBackDown = false;
        private bool _buttonLeftStickDown = false;
        private bool _buttonRightStickDown = false;
        private bool _buttonBigDown = false;
        private bool _buttonDpadDown = false;
        private bool _buttonDpadUp = false;
        private bool _buttonDpadLeft = false;
        private bool _buttonDpadRight = false;
        private List<IInputGamePadLeftStick> _inputGamePadLeftStickListeners;
        private List<IInputGamePadRightStick> _inputGamePadRightStickListeners;
        private List<IInputGamePadButtons> _inputGamePadButtonListeners;
        private List<IInputGamePadDigitalDpad> _inputGamePadDigitalDpadListeners;
        private List<IInputGamePadDigitalTriggers> _inputGamePadDigitalTriggerListeners;


        public float DigitalStickDeadZone
        {
            get { return _digitalStickDeadZone; }
            set { _digitalStickDeadZone = value; }
        }

        // The two states your pressed button can have;
        public enum ButtonStates
        {
            JustPressed,
            StillPressed
        }

        public enum Controller
        {
            One,
            Two,
            Three,
            Four
        }

        public List<IInputGamePadLeftStick> InputGamePadLeftStickListeners
        {
            get { return _inputGamePadLeftStickListeners; }
            set { _inputGamePadLeftStickListeners = value; }
        }

        public List<IInputGamePadRightStick> InputGamePadRightStickListeners
        {
            get { return _inputGamePadRightStickListeners; }
            set { _inputGamePadRightStickListeners = value; }
        }
        
        public List<IInputGamePadButtons> InputGamePadButtonListeners
        {
            get { return _inputGamePadButtonListeners; }
            set { _inputGamePadButtonListeners = value; }
        }

        public List<IInputGamePadDigitalDpad> InputGamePadDigitalDpadListeners
        {
            get { return _inputGamePadDigitalDpadListeners; }
            set { _inputGamePadDigitalDpadListeners = value; }
        }

        public List<IInputGamePadDigitalTriggers> InputGamePadDigitalTriggerListeners
        {
            get { return _inputGamePadDigitalTriggerListeners; }
            set { _inputGamePadDigitalTriggerListeners = value; }
        }


        //used inside the update method
        private void CheckDpad(GamePadState gamePadState, PlayerIndex playerIndex)
        {
            if (gamePadState.DPad.Down == ButtonState.Pressed) DpadDown(playerIndex, ButtonStates.JustPressed);
            //if (gamePadState.IsButtonDown(Buttons.DPadDown) && _buttonDpadDown) {DpadDown(playerIndex, ButtonStates.StillPressed);}
            //else if (gamePadState.IsButtonDown(Buttons.DPadDown))
            //{
            //    DpadDown(playerIndex, ButtonStates.JustPressed);
            //    _buttonDpadDown = true;
            //}
            //else _buttonDpadDown = false;

            //if (gamePadState.IsButtonDown(Buttons.DPadUp) && _buttonDpadUp) DpadUp(playerIndex, ButtonStates.StillPressed);
            //else if (gamePadState.IsButtonDown(Buttons.DPadUp)) DpadUp(playerIndex, ButtonStates.JustPressed);
            //else _buttonDpadDown = false;

            //if (gamePadState.IsButtonDown(Buttons.DPadLeft) && _buttonDpadLeft) DpadLeft(playerIndex, ButtonStates.StillPressed);
            //else if (gamePadState.IsButtonDown(Buttons.DPadLeft)) DpadLeft(playerIndex, ButtonStates.JustPressed);
            //else _buttonDpadDown = false;

            //if (gamePadState.IsButtonDown(Buttons.DPadRight) && _buttonDpadDown) DpadRight(playerIndex, ButtonStates.StillPressed);
            //else if (gamePadState.IsButtonDown(Buttons.DPadRight)) DpadRight(playerIndex, ButtonStates.JustPressed);
            //else _buttonDpadDown = false;
        }

        private void DpadRight(PlayerIndex playerIndex, ButtonStates buttonStates)
        {
            foreach (var inputGamePadDigitalDpadListener in InputGamePadDigitalDpadListeners)
            {
                inputGamePadDigitalDpadListener. ButtonDpadRightPressed(playerIndex, buttonStates);
            }
        }

        private void DpadDown(PlayerIndex playerIndex, ButtonStates buttonStates)
        {
            foreach (var inputGamePadDigitalDpadListener in InputGamePadDigitalDpadListeners)
            {
                inputGamePadDigitalDpadListener.ButtonDpadDownPressed(playerIndex, buttonStates);
            }
        }

        private void DpadLeft(PlayerIndex playerIndex, ButtonStates buttonStates)
        {
            foreach (var inputGamePadDigitalDpadListener in InputGamePadDigitalDpadListeners)
            {
                inputGamePadDigitalDpadListener.ButtonDpadLeftPressed(playerIndex, buttonStates);
            }
        }

        private void DpadUp(PlayerIndex playerIndex, ButtonStates buttonStates)
        {
            foreach (var inputGamePadDigitalDpadListener in InputGamePadDigitalDpadListeners)
            {
                inputGamePadDigitalDpadListener.ButtonDpadUpPressed(playerIndex, buttonStates);
            }
        }


        //Constructor - check for number of gamepads
        public InputController()
        {
            _inputGamePadButtonListeners = new List<IInputGamePadButtons>();
            _inputGamePadDigitalDpadListeners = new List<IInputGamePadDigitalDpad>();
            _inputGamePadDigitalTriggerListeners = new List<IInputGamePadDigitalTriggers>();
            _inputGamePadLeftStickListeners = new List<IInputGamePadLeftStick>();
            _inputGamePadRightStickListeners = new List<IInputGamePadRightStick>();
        }

        // implemented by Iupdateable
        public void Update(GameTime gameTime)
        {
            if (InputGamePadDigitalDpadListeners.Count < 0)
            {
                for (PlayerIndex i = 0; i < (PlayerIndex) 4; i++)
                {
                    if (GamePad.GetState((PlayerIndex.One)).IsConnected)
                    {
                        CheckDpad(GamePad.GetState(i), i);
                    }
                }
            }
        }

        public bool Enabled { get; private set; }
        public int UpdateOrder { get; private set; }
        public event EventHandler<EventArgs> EnabledChanged;
        public event EventHandler<EventArgs> UpdateOrderChanged;
    }
}
