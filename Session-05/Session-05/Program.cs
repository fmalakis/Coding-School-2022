using Session_05;

ActionRequest[] actionRequests =
{
    new ActionRequest("587985", ActionType.Convert),
    new ActionRequest("This is the biggest   word...", ActionType.Uppercase),
    new ActionRequest("Wingadrium Reversioza!", ActionType.Reverse),
    new ActionRequest("lmao", ActionType.Convert),
    new ActionRequest("lmao", ActionType.Uppercase)
};

ActionResponse[] actionResponses = new ActionResponse[actionRequests.Length];


MessageLogger messageLogger = new MessageLogger(actionRequests.Length);
ActionResolver actionResolver = new ActionResolver(messageLogger);

for (int i = 0; i < actionRequests.Length; i++)
{
    actionResponses[i] = actionResolver.Execute(actionRequests[i]);
}

for (int i = 0; i < actionResponses.Length; i++)
{
    Console.WriteLine("--------------------");
    Console.WriteLine($"Request #{i+1}: [ID: {actionRequests[i].ID}], [Input: {actionRequests[i].Input}, [Action: {actionRequests[i].Action}]");
    Console.WriteLine($"Response #{i + 1}: [ID: {actionResponses[i].ID}], [RequestID: {actionResponses[i].RequestID}, [Output: {actionResponses[i].Output}]\n");
}

messageLogger.ReadAll();

messageLogger.Clear();

messageLogger.ReadAll();
