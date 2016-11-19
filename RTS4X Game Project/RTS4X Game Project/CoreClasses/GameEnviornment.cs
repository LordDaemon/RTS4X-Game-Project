using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RTS4X_Game_Project.CoreClasses
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameEnviornment : Game
    {
        Texture2D background;
        public static SpriteFont debugFont;

        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;
        protected Point windowSize;

        protected static Point schreen;
        protected static GameStateManager gameStateManager;
        protected static Random random;
        //protected static ContentManager contentManager;
        //protected static SettingsManager settingsManager;

        public GameEnviornment()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            //contentManager = new ContentManager("Content");
            //settingsManager = new SettingsManager();

            gameStateManager = new GameStateManager();
            random = new Random();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            background = Content.Load<Texture2D>("backgroundImage.jpg");
            debugFont = Content.Load<SpriteFont>("DebugFont");


            //Goto fullschreen 
            
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges(); 
            

            // Load blueprint files
            // Load user data
            // Index maps / scenario's
            // 

            gameStateManager.AddGameState(new GameStates.SimGo("SimGo"));
            gameStateManager.SwitchTo("SimGo");


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here

            // Release handles to files loaded in LoadContent()
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime GT)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            gameStateManager.Update(GT);

            // TODO: Add your update logic here

            base.Update(GT);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime GT)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            spriteBatch.Draw(background, destinationRectangle: new Rectangle(0,0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height));
            // TODO: Add your drawing code here
            gameStateManager.Draw(GT, spriteBatch);

            spriteBatch.End();
            base.Draw(GT);
        }
    }
}
