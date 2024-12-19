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
    public class Verify_splitting_of_a_string_with_mixed_characters : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {

            // Code Generation:
            // Enter 'Hello123 World!' as input string. It is expected to: Output should be 'Hello123' and 'World!'
            string input = "Hello123 World!";
            var parts = input.Split(' ');

            string part1 = parts[0];
            string part2 = parts[1];

            // Output the results
            Console.WriteLine(part1);
            Console.WriteLine(part2);
        }
    }
}