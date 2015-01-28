using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using OpenTK.Graphics.ES20;

namespace DikkiDinosaur
{
    class Sprite
    {
        public Sprite()
        {
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {       
                //if (SourceRect.IsEmpty)
                //  {
                //    spriteBatch.Draw(SpriteTexture, Position, null, SpriteColor, GL.Angle, Origin, Scale, SpriteEffects.None, LayerDepth);
                //}
                //else
                //{
                //    spriteBatch.Draw(SpriteTexture, Position, SourceRect, SpriteColor, GL.Angle, Origin, Scale, SpriteEffects.None, LayerDepth);
                //}
        }   
    }
}
