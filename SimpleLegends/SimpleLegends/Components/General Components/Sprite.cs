using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using SimpleLegends.Components.General_Components.SubComponents;

namespace SimpleLegends.Components
{
    public class Sprite : Component
    {
        public Texture2D SpriteTexture;

        public Rectangle Source;

        public float Scale;

        public Position Position;

        public Color GraphicColor;

        public Sprite (GameTexture Texture,Position SpritePosition,float SpriteScale)
        {
            SpriteTexture = Texture.ContentTexture;
        
            Source = Texture.ContentSource;
            
            Scale = SpriteScale;

            Position = SpritePosition;

            GraphicColor = Color.White;
        }
    }
}