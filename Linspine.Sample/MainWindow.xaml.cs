using Linspine.Collection;
using System;
using System.Windows;

namespace Linspine.Sample
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var source =
@"using System;
using System.Collections;
using System.Linq;
using System.Text;
 
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(""Hello, World!"");
        }
    }
}";

            var result = LSAnalyzer.Analyze(source);
            PrintNode(result);
        }

        private void PrintNode(LSVisualCollection visual, int depth = 0)
        {
            foreach (var child in visual)
            {
                for (int i = 0; i < depth; i++)
                {
                    Console.Write("    ");
                }

                Console.WriteLine(child.Kind.ToString());

                PrintNode(child.Children, depth + 1);
            }
        }
    }
}
