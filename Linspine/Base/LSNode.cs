using Linspine.Collection;
using Microsoft.CodeAnalysis;

namespace Linspine.Base
{
    public abstract class LSNode
    {
        public LSAnalyzer Analyzer { get; protected set; }

        public SyntaxNode CurrentNode { get; protected set; }

        public LSNodeCollection Children { get; private set; } = new LSNodeCollection();
    }
}
