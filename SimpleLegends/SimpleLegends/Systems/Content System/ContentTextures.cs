using SimpleLegends.Components.General_Components.SubComponents;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Systems.Content_System
{
    static public class ContentTexture
    {
        public static GameTexture RedBlock
        {
            get;
            set;
        }
        public static GameTexture BlueBlock
        {
            get;
            set;
        }
        public static GameTexture WhiteBlock
        {
            get;
            set;
        }

        public static void GenerateGameTextures ()
        {
            if (ContentImages.SpriteSheet != null)
            {
                RedBlock = new GameTexture (ContentImages.SpriteSheet, new Rectangle (32, 0, 32, 32));
                BlueBlock = new GameTexture (ContentImages.SpriteSheet, new Rectangle (64, 400, 32, 32));
            }
        }
    }
}