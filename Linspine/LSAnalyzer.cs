using Linspine.Base;
using Linspine.Collection;
using Linspine.Visual;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Linspine
{
    public static class LSAnalyzer
    {
        public static LSVisualCollection Analyze(string text)
        {
            return Analyze(CSharpSyntaxTree.ParseText(text).GetRoot());
        }

        public static LSVisualCollection Analyze(SyntaxNode node)
        {
            var result = new LSVisualCollection();

            foreach (var child in node.ChildNodes())
            {
                var nodeType = Determine(child);
                if (nodeType != null)
                {
                    result.Add(nodeType);
                }
            }

            return result;
        }

        public static LSVisual Determine(SyntaxNode node)
        {
            LSVisual result = null;

            if (node is CompilationUnitSyntax)
            {
                result = new LSCompilationUnit
                {
                    CurrentNode = node
                };
            }

            if (node is UsingDirectiveSyntax)
            {
                result = new LSUsingDirective
                {
                    CurrentNode = node
                };
            }

            if (node is NamespaceDeclarationSyntax)
            {
                result = new LSNamespaceDeclaration
                {
                    CurrentNode = node
                };
            }

            if (node is ClassDeclarationSyntax)
            {
                result = new LSClassDeclaration
                {
                    CurrentNode = node
                };
            }

            if (node is MethodDeclarationSyntax)
            {
                result = new LSMethodDeclaration
                {
                    CurrentNode = node
                };
            }

            return result;
        }
    }
}
