using Linspine.Collection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Linspine.Base
{
    public abstract class LSVisual
    {
        public SyntaxKind Kind
        {
            get
            {
                return CurrentNode.Kind();
            }
        }

        public string Language
        {
            get
            {
                return CurrentNode.Language;
            }
        }

        public LSVisualCollection Children
        {
            get
            {
                return LSAnalyzer.Analyze(CurrentNode);
            }
        }

        public SyntaxNode CurrentNode { get; set; }
    }
}
