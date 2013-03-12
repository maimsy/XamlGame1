using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Windows;

namespace XamlGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    /// 

    
    public class Game1 : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        List<Crater> craters; 
        Planet planet;

        TimeSpan craterSpawnTime;
        TimeSpan previousSpawnTime;

        Random random;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content"; 
        }

        
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            craters = new List<Crater>();
            previousSpawnTime = TimeSpan.Zero;
            craterSpawnTime = TimeSpan.FromSeconds(1.0f);
            random = new Random();
           
        }

         
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
           
            planet = new Planet();
         
            Vector2 planetPosition = new Vector2(450,200);
            planet.Initialize(Content.Load<Texture2D>("Graphics\\spritePlanet"), planetPosition);
              
        }

         
        protected override void UnloadContent()
        {
             
        }

         
        protected override void Update(GameTime gameTime)
        {
           
            base.Update(gameTime);


            updateCraters(gameTime);
        }

       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); 

            _spriteBatch.Begin();  
           planet.Draw(_spriteBatch);

           for (int i = 0; i < craters.Count; i++)
           {
               craters[i].Draw(_spriteBatch); 


           }
             
            _spriteBatch.End(); 
             
            base.Draw(gameTime);
        }

        private void addCrater()
        {
            Crater crater = new Crater();
            int x, y;
            Random random = new Random();
            int rand = random.Next(1, 3);
            if (rand == 1) {   x = -50; }
            else {  x = 600; }
            y = random.Next(0, 800); 
           

            Vector2 playerPosition = new Vector2(x, y);

            //new Vector2(GraphicsDevice.Viewport.Width + 100 / 2, random.Next(100, GraphicsDevice.Viewport.Height - 100));
            crater.Initialize(Content.Load<Texture2D>("Graphics\\spriteRock"), playerPosition);
          
            craters.Add(crater);
          
        }


        private void updateCraters(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - previousSpawnTime > craterSpawnTime)
            {
                previousSpawnTime = gameTime.TotalGameTime;
                 
                addCrater();
            }

            // Update the Enemies
            for (int i = craters.Count - 1; i >= 0; i--)
            {
                float x, y;

                if (craters[i].Position.X < (planet.Position.X + planet.PlayerTexture.Width / 2) && craters[i].Position.Y <(planet.Position.Y + planet.PlayerTexture.Height / 2)) { x = 20; y = 20; }

                else if (craters[i].Position.X < (planet.Position.X + planet.PlayerTexture.Width / 2) && craters[i].Position.Y > (planet.Position.Y + planet.PlayerTexture.Height / 2)) { x = 20; y = -20; }

                else if (craters[i].Position.X > (planet.Position.X + planet.PlayerTexture.Width / 2) && craters[i].Position.Y < (planet.Position.Y + planet.PlayerTexture.Height / 2)) { x = -20; y = 20; }

                else if (craters[i].Position.X > (planet.Position.X + planet.PlayerTexture.Width / 2) && craters[i].Position.Y > (planet.Position.Y + planet.PlayerTexture.Height / 2)) { x = -20; y = -20; }

                else { x = 20; y = 20; }
                //float x = craters[i].Position.X - (planet.Position.X + planet.PlayerTexture.Width / 2); if (x < 0) { x = -x; }
                //float y = craters[i].Position.Y - (planet.Position.Y + planet.PlayerTexture.Height / 2); if (y < 0) { y = -y; }

                Microsoft.Xna.Framework.Vector2 spriteSpeed = new Microsoft.Xna.Framework.Vector2(x, y);  
                
                craters[i].Position   += spriteSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds  ;

                if (craters[i].Position.X >= planet.Position.X && craters[i].Position.Y >= planet.Position.Y)
                { craters.RemoveAt(i); }

                
                //craters[i].Update(gameTime);
 
            }

        }

    }
}
