using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaDock
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}