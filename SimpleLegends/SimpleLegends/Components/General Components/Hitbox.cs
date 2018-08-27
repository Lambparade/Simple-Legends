using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Components
{
    public class Hitbox : Component
    {
        public Rectangle Bounds;
        public Hitbox(Rectangle DesiredBounds)
        {
            Bounds = DesiredBounds;
        }
    }
}