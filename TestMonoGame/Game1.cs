using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TestMonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public const int windowWidth = 800;
        public const int windowHeight = 600;

        public Vector2 bgPosition;
        public Texture2D bgTexture;

        public Vector2 characPosition;
        public Texture2D characTexture;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Window size
            graphics.PreferredBackBufferWidth = windowWidth;
            graphics.PreferredBackBufferHeight = windowHeight;
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

            bgPosition = new Vector2(0, 0);
            characPosition = new Vector2(680, 500);

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

            // TODO: use this.Content to load your game content here

            bgTexture = Content.Load<Texture2D>("background1");
            characTexture = Content.Load<Texture2D>("testChar");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            base.Update(gameTime);
            
            // gerer les touches du clavier
            
            KeyboardState kb = Keyboard.GetState();
            int speed = 5;

            if (kb.IsKeyDown(Keys.Left)) { characPosition.X -= speed; }
            if (kb.IsKeyDown(Keys.Right)) { characPosition.X += speed; }
            if (kb.IsKeyDown(Keys.Up)) { characPosition.Y -= speed; }
            if (kb.IsKeyDown(Keys.Down)) { characPosition.Y += speed; }
            if (kb.IsKeyDown(Keys.Escape)) { this.Dispose(); }
            

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

                    
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            spriteBatch.Draw(bgTexture, new Rectangle(0, 0, 800, 600), Color.White); 
            spriteBatch.Draw(characTexture, new Rectangle((int) characPosition.X , (int) characPosition.Y, 100, 75), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        } 
    }
}
