using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class HtmlBuilder
    {
        public HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            root.Name = rootName; 
        }

        public void Clear()
        {
            root = new HtmlElement { Name = this.root.Name };
        }

        public HtmlBuilder AddChild(string name, string text)
        {
            var e = new HtmlElement(name, text);
            root.childs.Add(e);
            return this;
        }

        public void AddChild(HtmlElement child)
        {
            root.childs.Add(child);
            
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
}
