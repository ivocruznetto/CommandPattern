using SimpleExample;

var commandState = (State)new Receiver().Handler(new Command(1, "Comando 1"));

Console.WriteLine($"{commandState.StatusCode} - {commandState.Message}");