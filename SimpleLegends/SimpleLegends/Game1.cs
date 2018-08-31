using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using SimpleLegends.Systems.Content_System;
using SimpleLegends.Systems.Render_System;
using SimpleLegends.Systems.Entity_System;

using SimpleLegends.Managers.Graphics_Managers;

namespace SimpleLegends
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;

        SpriteBatch spriteBatch;

        SpriteFont debugfont;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = 512;
            graphics.PreferredBackBufferWidth = 512;
            IsMouseVisible = true;

            Window.IsBorderless = true;
        }

        protected override void Initialize()
        {
            CameraSystem.StartCamera2d(graphics);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            debugfont = Content.Load<SpriteFont>("debugfont");

            ContentSpriteSheets.Load(this);

            Debugger.StartDebugger(debugfont);

            LoadEntities.LoadPlayer();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

                CameraSystem.Move(-1,0);

            EntityUpdater.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            ///MOVE RENDERTARGET TO DIFFERNET CLASS
            GraphicsDevice.Clear(Color.Black);

            InActiveEntityDrawManager.SendToRenderSystem();
            ActiveEntityDrawManager.SendToRenderSystem();

            RenderTarget2D GameRenderTarget = new RenderTarget2D(GraphicsDevice, 512, 512);

            GraphicsDevice.SetRenderTarget(GameRenderTarget);

            GraphicsDevice.Clear(Color.Black);

            SpriteBatch RenderspriteBatch = new SpriteBatch(GraphicsDevice);

            RenderSprites.Draw(RenderspriteBatch, GraphicsDevice);

            GraphicsDevice.SetRenderTarget(null);

            spriteBatch.Begin();

            spriteBatch.Draw(GameRenderTarget,new Vector2(0,0),Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
