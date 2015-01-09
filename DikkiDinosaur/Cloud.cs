using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DikkiDinosaur
{
    class Cloud : Sprite
    {
        public Cloud(Texture2D spriteTexture2D, Vector2 position, float speed) : base (spriteTexture2D, position)
        {
            this.Speed = speed;
        }

        public float Speed { get; set; }

        public override void Update(GameTime gameTime)
        {
            PositionX -= Speed;
            if (PositionX <= -300) PositionX = 900;
        }
    }
}
