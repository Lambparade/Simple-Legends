using SimpleLegends.Components.General_Components.SubComponents;
using SimpleLegends.Systems.Utility_System.RenderTargetSystems;

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
        public static GameTexture IndivualGrid
        {
            get;
            set;
        }

        public static GameTexture Grid
        {
            get;
            set;
        }

        public static void GenerateGameTextures()
        {
            if (ContentSpriteSheets.SpriteSheet != null)
            {
                RedBlock = new GameTexture(ContentSpriteSheets.SpriteSheet, new Rectangle(32, 0, 32, 32));
                BlueBlock = new GameTexture(ContentSpriteSheets.SpriteSheet, new Rectangle(64, 400, 32, 32));
                IndivualGrid = new GameTexture(ContentSpriteSheets.SpriteSheet, new Rectangle(0, 0, 32, 32));
            }
        }

        public static void GenerateRenderTargetTextures(GraphicsDevice MainGraphicsDevice)
        {
            Grid = new GameTexture(GenerateGridRenderTarget.GenerateGridTexture(MainGraphicsDevice),new Rectangle(0,0,32 * 8,32 * 8));
        }
    }
}