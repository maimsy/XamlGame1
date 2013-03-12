using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlGame1
{
    class Crater
    { 
        public Texture2D PlayerTexture; 
        public bool active;

         
        public Microsoft.Xna.Framework.Vector2 Position;
         
        public void Initialize(Texture2D texture, Microsoft.Xna.Framework.Vector2 position)
        {

            PlayerTexture = texture;  
            Position = position;
            active = true;
        }


 

       public void Update(GameTime gameTime)
        {
           // planet = new Planet(); 
           
           //Microsoft.Xna.Framework.Vector2 spriteSpeed = new Microsoft.Xna.Framework.Vector2(50.0f, 50.0f); 
           //Position += spriteSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;


           //GraphicsDevice graphics = new GraphicsDevice();

           //int MaxX = graphics.GraphicsDevice.Viewport.Width - PlayerTexture.Width;
           //int MinX = 0;
           //int MaxY = graphics.GraphicsDevice.Viewport.Height - PlayerTexture.Height;
           //int MinY = 0;

           //// Check for bounce.
           //if (Position.X > MaxX)
           //{
           //    spriteSpeed.X *= -1;
           //    Position.X = MaxX;
           //}

           //else if (Position.X < MinX)
           //{
           //    spriteSpeed.X *= -1;
           //    Position.X = MinX;
           //}

           //if (Position.Y > MaxY)
           //{
           //    spriteSpeed.Y *= -1;
           //    Position.Y = MaxY;
           //}

           //else if (Position.Y < MinY)
           //{
           //    spriteSpeed.Y *= -1;
           //    Position.Y = MinY;
           //}


       } 


 

       public void Draw(SpriteBatch spriteBatch )  
       {
           //Microsoft.Xna.Framework.Rectangle rectangle = new Microsoft.Xna.Framework.Rectangle(x,y,50,50);
            
           //spriteBatch.Draw(PlayerTexture,rectangle,Microsoft.Xna.Framework.Color.White);
           spriteBatch.Draw(PlayerTexture, Position, null, Microsoft.Xna.Framework.Color.White, 0f, Microsoft.Xna.Framework.Vector2.Zero, 1f,

       SpriteEffects.None, 0f);  
       } 

   
    }
}
