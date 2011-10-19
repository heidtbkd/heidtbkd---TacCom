using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Background textures for the various screens in the game
        Texture2D mControllerDetectScreenBackground;
        Texture2D mTitleScreenBackground;

        //Screen State variables
        bool mIsControllerDetectScreenShown;
        bool mIsTitleScreenShown;

        PlayerIndex mPlayerOne;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.graphics.PreferredBackBufferHeight = 800;
            this.graphics.PreferredBackBufferWidth = 600;
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

            //Load screen
            mControllerDetectScreenBackground = Content.Load<Texture2D>("ControllerDetectScreen");
            mTitleScreenBackground = Content.Load<Texture2D>("TitleScreen");

            //Initialize screen state vars
            mIsTitleScreenShown = false;
            mIsControllerDetectScreenShown = true;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // Based on the screen state variables, call the
            // Update method associated with the current screen

            if (mIsControllerDetectScreenShown)
            {
                UpdateControllerDetectScreen();
            }
            else if (mIsTitleScreenShown)
            {
                UpdateTitleScreen();
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// UpdateControllerDetectScreen
        /// determines which controller is in use at the current time
        /// </summary>
        private void UpdateControllerDetectScreen()
        {
            //Poll all the gamepads (and the keyboards) to check to see
            //which controller will be the player one controller

            for (int aPlayer = 0; aPlayer < 4; aPlayer++)
            {
                if (GamePad.GetState((PlayerIndex)aPlayer).Buttons.A == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.A) == true)
                {
                    mPlayerOne = (PlayerIndex)aPlayer;
                    mIsTitleScreenShown = true;
                    mIsControllerDetectScreenShown = false;
                    return;
                }
            }
        }

        private void UpdateTitleScreen()
        {
            //Move back to the Controller detect screen if the player moves
            //back (using B) from the Title screen (if this is typically game behavior
            //and is used to switch to a new player one controller)
            if (GamePad.GetState(mPlayerOne).Buttons.B == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.B) == true)
            {
                mIsTitleScreenShown = false;
                mIsControllerDetectScreenShown = true;
                return;
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            // Based on the screen state variables, call thee
            //Draw method associated with the current screen
            if (mIsControllerDetectScreenShown)
            {
                DrawControllerDetectScreen();
            }
            else if (mIsTitleScreenShown)
            {
                DrawTitleScreen();
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// DrawControllerDetectScreen
        /// This method draws elements apart of the detect screen
        /// </summary>
        private void DrawControllerDetectScreen()
        {
            spriteBatch.Draw(mControllerDetectScreenBackground, Vector2.Zero, Color.White);
        }

        /// <summary>
        /// DrawTitleScreen
        /// This method draws the title screen for the game
        /// </summary>
        private void DrawTitleScreen()
        {
            spriteBatch.Draw(mTitleScreenBackground, Vector2.Zero, Color.White);
        }
    }
}
