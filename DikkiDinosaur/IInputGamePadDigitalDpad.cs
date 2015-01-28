using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DikkiDinosaur
{
    public interface IInputGamePadDigitalDpad
    {
        void ButtonDpadDownPressed(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonDpadUpPressed(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonDpadLeftPressed(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonDpadRightPressed(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
    }
}
