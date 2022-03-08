using Session_05;

MessageLogger messageLogger = new MessageLogger(10);
ActionResolver actionResolver = new ActionResolver(messageLogger);


ActionRequest request1 = new ActionRequest("35.17", ActionType.Convert);
ActionResponse response1 = actionResolver.Execute(request1);
messageLogger.ReadAll();
Console.WriteLine($"Request1: {request1.ID}, {request1.Input}, {request1.Action}");
Console.WriteLine($"Response1: {response1.ID}, {response1.RequestID}, {response1.Output}");

ActionRequest request2 = new ActionRequest("this a fucking test   lol.", ActionType.Uppercase);
ActionResponse response2 = actionResolver.Execute(request2);
messageLogger.ReadAll();
Console.WriteLine($"Request1: {request2.ID}, {request2.Input}, {request2.Action}");
Console.WriteLine($"Response1: {response2.ID}, {response2.RequestID}, {response2.Output}");

messageLogger.Clear();
Console.WriteLine();

ActionRequest request3 = new ActionRequest("Fotis lmaoOoOO  !!!", ActionType.Reverse);
ActionResponse response3 = actionResolver.Execute(request3);
Console.WriteLine($"Request3: {request3.ID}, {request3.Input}, {request3.Action}");
Console.WriteLine($"Response3: {response3.ID}, {response3.RequestID}, {response3.Output}");

ActionRequest request4 = new ActionRequest("this", ActionType.Uppercase);
ActionResponse response4 = actionResolver.Execute(request4);
Console.WriteLine($"Request4: {request4.ID}, {request4.Input}, {request4.Action}");
Console.WriteLine($"Response4: {response4.ID}, {response4.RequestID}, {response4.Output}");

ActionRequest request5 = new ActionRequest("this", ActionType.Convert);
ActionResponse response5 = actionResolver.Execute(request5);
Console.WriteLine($"Request5: {request5.ID}, {request5.Input}, {request5.Action}");
Console.WriteLine($"Response5: {response5.ID}, {response5.RequestID}, {response5.Output}");

messageLogger.ReadAll();