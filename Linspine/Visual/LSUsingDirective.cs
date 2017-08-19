using Linspine.Base;
using Linspine.Control;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

namespace Linspine.Visual
{
    public class LSUsingDirective : LSVisual
    {
        public LSUsingDirective()
        {
            Loaded += LSUsingDirective_Loaded;
        }

        private void LSUsingDirective_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var block = new BaseBlock
            {
                BlockBackground = Brushes.DarkCyan
            };

            block.BlockContent.Children.Add(new TextBlock
            {
                Text = CurrentNode.ChildNodes().First().ToFullString()
            });

            Children.Add(block);
        }
    }
}
