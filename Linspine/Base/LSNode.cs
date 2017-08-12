using Linspine.Collection;
using Microsoft.CodeAnalysis;

namespace Linspine.Base
{
    public abstract class LSNode
    {
        public LSAnalyzer Analyzer { get; protected set; }

        public SyntaxNode CurrentNode { get; protected set; }

        public LSVisualCollection Children { get; private set; } = new LSVisualCollection();
    }
}
