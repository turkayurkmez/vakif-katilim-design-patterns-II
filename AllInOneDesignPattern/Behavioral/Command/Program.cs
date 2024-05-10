using Command;

// See https://aka.ms/new-console-template for more information
DbCommandReceiver sqlCommandReceiver = new DbCommandReceiver();
CreateOrderCommand createOrderCommand = new CreateOrderCommand(sqlCommandReceiver, "Türkay");
UpdateStockCommand updateStockCommand = new UpdateStockCommand(sqlCommandReceiver, "Birkaç ürün");

CommandInvoker commandInvoker = new CommandInvoker();
commandInvoker.Add(createOrderCommand);
commandInvoker.Add(updateStockCommand);

commandInvoker.ExecuteCommands();


