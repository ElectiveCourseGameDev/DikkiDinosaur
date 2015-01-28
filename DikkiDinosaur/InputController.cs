using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DikkiDinosaur
{
    class InputController
    {
        public static enum ButtonStates
        {
            JustPressed,
            StillPressed
        }

        private bool _ButtonApressed = false;

        List<IInput> _observersOnAButton = new List<IInput>();
        List<IInput> _observersOnBButton = new List<IInput>();

        
        public void update()
        {     
            if (GamePad.GetState(PlayerIndex.One).IsConnected)
            {
                if (GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.A)) Notify(GamePadButtons GamePad.GetState(PlayerIndex.One).Buttons.A)
                
            }


        }

        private void NotifyButtonA(object gamePadButtons)
        {
             ButtonState.
            _ButtonApressed = true
        }
    }
}
