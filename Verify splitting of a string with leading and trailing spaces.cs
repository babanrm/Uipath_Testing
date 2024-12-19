using GitHub1.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace GitHub1
{
    public class Verify_splitting_of_a_string_with_leading_and_trailing_spaces : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {

            // Code Generation:
            // Enter '  Hello World  ' as input string. It is expected to: Output should be 'Hello' and 'World'
            var inputString = "  Hello World  ";
            var trimmedString = inputString.Trim();
            var words = trimmedString.Split(' ');
            var firstWord = words[0];
            var secondWord = words[1];
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);
        }
    }
}