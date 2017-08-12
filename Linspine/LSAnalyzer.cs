using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linspine
{
    public class LSAnalyzer
    {
        #region 속성
        public string Source
        {
            get
            {
                return _Source;
            }
            set
            {
                _Source = value;
                Analyze();
            }
        }
        private string _Source;
        #endregion

        #region 객체
        private SyntaxTree tree;
        #endregion

        #region 생성자
        public LSAnalyzer()
        {

        }

        public LSAnalyzer(string source)
        {
            Source = source;
        }
        #endregion

        #region 내부 함수
        private void Analyze()
        {
            if (Source?.Length > 0)
            {
                tree = CSharpSyntaxTree.ParseText(Source);
                AnalyzeNode(tree.GetRoot());
            }
        }

        private void AnalyzeNode(SyntaxNode node)
        {
            foreach (var child in node.ChildNodes())
            {
                if (child is UsingDirectiveSyntax)
                {
                    Console.WriteLine((child as UsingDirectiveSyntax).Name);
                }

                if (child is NamespaceDeclarationSyntax)
                {
                    Console.WriteLine(" NS " + (child as NamespaceDeclarationSyntax).Name);
                }

                if (child is ClassDeclarationSyntax)
                {
                    Console.WriteLine(" CL " + (child as ClassDeclarationSyntax).Identifier.ValueText);
                }

                if (child is MethodDeclarationSyntax)
                {
                    Console.WriteLine(" ME " + (child as MethodDeclarationSyntax).Identifier.ValueText);
                }

                AnalyzeNode(child);
            }
        }
        #endregion
    }
}
