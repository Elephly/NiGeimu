using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace ニゲーム
{
    class Animation
    {
        Texture2D texture;
        int cellWidth;
        int cellHeight;

        public Animation(Texture2D tex, int[] animations)
        {
            texture = tex;
            cellWidth = texture.Width / animations[0];
            cellHeight = texture.Height / (animations.Length - 1);
        }

        public void Draw(SpriteBatch batch)
        {
            
        }
    }
}
