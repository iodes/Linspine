using Linspine.Collections;
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
            DrawNode(result);
        }

        //TODO 하위 노드는 비주얼 객체에서 처리하도록 수정
        private void DrawNode(LSVisualCollection visual, int depth = 0)
        {
            foreach (var child in visual)
            {
                for (int i = 0; i < depth; i++)
                {
                    Console.Write("    ");
                }

                blockCanvas.Children.Add(child);
                Console.WriteLine(child.Kind.ToString());

                DrawNode(child.ChildNodes, depth + 1);
            }
        }
    }
}
