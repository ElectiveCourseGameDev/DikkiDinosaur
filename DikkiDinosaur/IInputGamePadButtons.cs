using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DikkiDinosaur
{
    public interface IInputGamePadButtons
    {
        void ButtonADown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonBDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonXDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonYDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonLeftShoulderDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonRightShoulderDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonStartDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonBackDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonLeftStickDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonRightStickDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
        void ButtonBigDown(PlayerIndex playerIndex, InputController.ButtonStates buttonStates);
    }
}
