using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using SimpleLegends;
using SimpleLegends.Components;
using SimpleLegends.Components.General_Components.SubComponents;

using static SimpleLegends.Systems.Content_System.ContentTexture;

namespace SimpleLegends.Systems.Utility_System.RenderTargetSystems
{
    public static class GenerateGridRenderTarget
    {
        static Sprite[,] GridTextures = new Sprite[8, 8];

        public static Texture2D GenerateGridTexture(GraphicsDevice MainGraphicsDevice)
        {
            PopulateGridTextures();

            Texture2D GeneratedTexture = IndivualGrid.ContentTexture;

            RenderTarget2D EditGridRenderTarget = new RenderTarget2D(MainGraphicsDevice, GridTextures.GetLength(0) * 32, GridTextures.GetLength(1) * 32);

            MainGraphicsDevice.SetRenderTarget(EditGridRenderTarget);
            MainGraphicsDevice.Clear(Color.Black);

            SpriteBatch spriteBatch = new SpriteBatch(MainGraphicsDevice);
            spriteBatch.Begin();

            for (int x = 0; x < GridTextures.GetLength(0); x++)
            {
                for (int y = 0; y < GridTextures.GetLength(1); y++)
                {
                    spriteBatch.Draw(GridTextures[x,y].SpriteTexture, new Vector2((int)GridTextures[x,y].Position.Location.X, (int)GridTextures[x,y].Position.Location.Y), GridTextures[x,5].Source, GridTextures[x,5].GraphicColor, 0, Vector2.Zero,
                             1, SpriteEffects.None, 0);
                }
            }

            spriteBatch.End();

            MainGraphicsDevice.SetRenderTarget(null);

            return EditGridRenderTarget as Texture2D;
        }

        private static void PopulateGridTextures()
        {
            for (int x = 0; x <=GridTextures.GetLength(0) - 1; x++)
            {
                for (int y = 0; y <=GridTextures.GetLength(1) - 1; y++)
                {
                    GridTextures[x, y] = new Sprite(IndivualGrid, new Position(32 * x, 32 * y), 1);
                }
            }
        }
    }
}