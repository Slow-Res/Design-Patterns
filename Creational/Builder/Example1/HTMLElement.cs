using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> childs = new();
        private readonly int IndentSize = 2;

        public HtmlElement()
        {

        }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }

        private string Print(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indent * IndentSize);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrEmpty(Text))
            {
                sb.Append(new string(' ', IndentSize * ( indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var e in childs)
            {
                sb.Append(e.Print(indent + 1));
            }

            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return Print(0);
        }


    }
}