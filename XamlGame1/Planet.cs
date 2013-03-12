using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlGame1
{
    class Planet
    {

        public Texture2D PlayerTexture;


        public Microsoft.Xna.Framework.Vector2 Position;

        public void Initialize(Texture2D texture, Microsoft.Xna.Framework.Vector2 position)
        {

            PlayerTexture = texture;
             
            Position = position;

        }




        public void Update(GameTime gameTime)
        {
            
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PlayerTexture,
                Position, 
                null,
                Microsoft.Xna.Framework.Color.White, 
                0f, 
                Microsoft.Xna.Framework.Vector2.Zero, 
                1f,
                SpriteEffects.None,
                0f); 

        } 

   
    }
}
