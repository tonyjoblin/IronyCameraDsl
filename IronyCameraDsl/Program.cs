using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace IronyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var grammar = new CameraControllerGrammar();
            var parser = new Parser(grammar);
            var text = File.ReadAllText("camera.dsl");
            var parseTree = parser.Parse(text);

            Console.WriteLine("has errors? {0}", parseTree.HasErrors());
            Console.WriteLine("status? {0}", parseTree.Status);
            foreach (var parserMessage in parseTree.ParserMessages)
            {
                Console.WriteLine(parserMessage);
            }

            ShowNode(parseTree.Root);
        }

        private static void ShowNode(ParseTreeNode node, string level = "")
        {
            Console.WriteLine("{0} {1}", level, node.ToString());
            foreach (var childNode in node.ChildNodes)
            {
                ShowNode(childNode, level + "  ");
            }
        }
    }
}
