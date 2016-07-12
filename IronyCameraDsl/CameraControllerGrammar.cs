using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace IronyExample
{
    class CameraControllerGrammar : Grammar
    {
        public CameraControllerGrammar() : base(false)
        {
            var program = new NonTerminal("program");
            var cameraSize = new NonTerminal("cameraSize");
            var cameraPosition = new NonTerminal("cameraPosition");
            var commandList = new NonTerminal("commandList");
            var command = new NonTerminal("command");
            var direction = new NonTerminal("direction");
            var number = new NumberLiteral("number");

            Root = program;

            program.Rule = cameraSize + cameraPosition + commandList;
            cameraSize.Rule = ToTerm("set") + "camera" + "size" + ":" + number + "by" + number + "pixels" + ".";
            cameraPosition.Rule = ToTerm("set") + "camera" + "position" + ":" + number + "," + number + ".";
            commandList.Rule = MakePlusRule(commandList, null, command);
            command.Rule = ToTerm("move") + number + "pixels" + direction + ".";
            direction.Rule = ToTerm("up") | "down" | "left" | "right";

            //MarkPunctuation(new string[] {"set", "camera", "size", ",", ":", "by", "pixels", "position", "move", "."});
        }
    }
}
