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
            graphics.PreferredBackBufferHeight = 288;
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

            ContentImages.Load(this);

            Debugger.StartDebugger(debugfont);

            LoadEntities.LoadPlayer();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            CameraSystem.Move(-1, 0);

            EntityUpdater.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            ActiveEntityDrawManager.SendToRenderSystem();

            RenderSprites.Draw(spriteBatch, GraphicsDevice);

            base.Draw(gameTime);
        }
    }
}
