using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Example3
{
    public class Calculator
    {
        protected string caseColor;
        protected string buttonColor;
        protected bool isTrig;
        protected bool isProgrammable;
        protected List<string> buttonList = [];
        public class Builder
        {
            protected string caseColor = "Blue";
            protected string buttonColor = "Yellow";

            protected bool isTrig = false;
            protected bool isProgrammable = false;
            protected List<string> buttonList = [];

            public Builder WithCaseColor(string color)
            {
                this.caseColor = color;
                return this;
            }

            public Builder WithTrigFnctions()
            {
                this.isTrig = true;
                return this;
            }

            public Calculator Build()
            {
                return new Calculator(caseColor, buttonColor, isTrig, isProgrammable);
            }
        }

        public Calculator()
        {

        }
        private Calculator(string caseColor, string buttonColor, bool isTrig, bool isProgrammable)
        {
            this.caseColor = caseColor;
            this.buttonColor = buttonColor;
            this.isTrig = isTrig;
            this.isProgrammable = isProgrammable;
        }

        public override string ToString()
        {
            return $"{nameof(caseColor)}: {this.caseColor}, {nameof(buttonColor)}: {this.buttonColor}";
        }
    }
}