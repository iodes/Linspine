using Linspine.Collections;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Windows.Controls;

namespace Linspine.Cores
{
    public abstract class LSVisual : Grid
    {
        public SyntaxKind Kind
        {
            get
            {
                return CurrentNode.Kind();
            }
        }

        public LSVisualCollection ChildNodes
        {
            get
            {
                return LSAnalyzer.Analyze(CurrentNode);
            }
        }

        public SyntaxNode CurrentNode { get; set; }
    }
}
