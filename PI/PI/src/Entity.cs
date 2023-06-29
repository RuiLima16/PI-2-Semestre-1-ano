using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;


namespace PI.src
{
    public abstract class Entity
    {
        Texture2D sprite;
        Vector2 position;

        public abstract void Update();

        public abstract void Draw();
    }
}
