using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MonoGame.Framework;
using XamlGame1;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XamlGame1
{
    /// <summary>
    /// The root page used to display the game.
    /// </summary>
    public sealed partial class GamePage : SwapChainBackgroundPanel
    {
        readonly Game1 _game;
        Crater crater;

        public GamePage(string launchArguments)
        {
            this.InitializeComponent(); 
            // Create the game.
            _game = XamlGame<Game1>.Create(launchArguments, Window.Current.CoreWindow, this);
        
         
        }
    }
}
