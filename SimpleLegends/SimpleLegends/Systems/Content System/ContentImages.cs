using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using SimpleLegends;

namespace SimpleLegends.Systems.Content_System
{
    public static class ContentSpriteSheets
    {
        public static Texture2D SpriteSheet { get; set; }

        public static void Load(Game1 CurrentGame)
        {
            SpriteSheet = CurrentGame.Content.Load<Texture2D>("TestSpriteSheet");

            ContentTexture.GenerateGameTextures();
            ContentTexture.GenerateRenderTargetTextures(CurrentGame.GraphicsDevice);
        }
    }
}