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

namespace bouncingball
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D mbl;
        Rectangle mbr ;


        Vector2 os;

        Random mran = new Random();

        int screenWidth;
        int screenHeight;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {


            base.Initialize();
        }


        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);

            mbl = Content.Load<Texture2D>("ball");
            mbr = new Rectangle(300,300,32,32);

            os.X = 3f;
            os.Y = 3f;

            screenWidth = GraphicsDevice.Viewport.Width;
            screenHeight = GraphicsDevice.Viewport.Height;


        }


        protected override void UnloadContent()
        {
        }


        protected override void Update(GameTime gameTime)
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();
            mbr.X = mbr.X + (int) os.X;
            mbr.Y = mbr.Y + (int)os.Y;

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                Randomload();
            }

            if (mbr.X <= 0)
               os.X = -os.X;

            if (mbr.X + mbl.Width >= screenWidth)
                os.X = -os.X;

            if (mbr.Y <= 0)
                os.Y = -os.Y;

            if (mbr.Y + mbl.Height >= screenHeight)
                os.Y = -os.Y;
            

            base.Update(gameTime);
        }

        void Randomload()

        {
         int Random = mran.Next(0, 4);

            
            if (Random == 0)
            {
                os.X = 3f;
                os .Y = 3f;
            }
                       
            if (Random == 1)

            {
                os.X = 3f;
                os .Y = 3f;
            }           
            if (Random == 2)

            {
                os.X = 3f;
                os .Y = 3f;
            }            
            if (Random == 3)

            {
                os.X = 3f;
                os .Y = 3f;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(mbl, mbr, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
