using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class VLC : Page
    {
        public VLC()
        {
            this.InitializeComponent();
        }

        private void vlc_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            FullscreenToggle();
        }
        public bool IsFullscreen { get; set; } = false;
        
        private void FullscreenToggle()
        {
            this.IsFullscreen = !this.IsFullscreen;

            if (this.IsFullscreen)
            {
                vlc.Width = Window.Current.Bounds.Width;
                vlc.Height = Window.Current.Bounds.Height;                
            }
            else
            {
                vlc.Width = 640;
                vlc.Height = 480;
            }
        }
    }
    
}
