using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(
        ConfigurationManager.AppSettings["LuisAppId"], 
        ConfigurationManager.AppSettings["LuisAPIKey"], 
        domain: ConfigurationManager.AppSettings["LuisAPIHostName"])))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await this.ShowLuisResult(context, result);
    }

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "Greeting" with the name of your newly created intent in the following handler
    [LuisIntent("Greeting")]
    public async Task GreetingIntent(IDialogContext context, LuisResult result)
    {
        await this.ShowLuisResult(context, result);
    }

    [LuisIntent("choose")]
    public async Task ChooseIntent(IDialogContext context, LuisResult result)
    {
        await this.ShowLuisResult(context, result);
        await context.PostAsync($"And you should really go for a bike, it's always the best way to go");
    }

    [LuisIntent("choosewhen")]
    public async Task ChooseWhenIntent(IDialogContext context, LuisResult result)
    {
        await this.ShowLuisResult(context, result);
        var resolutionValues = (IList<object>)result.Entities[0].Resolution["values"];
        var values = (IDictionary<string, object>)resolutionValues[0];
        await context.PostAsync($"You should take a Car in {values["value"]}");
    }

    private async Task ShowLuisResult(IDialogContext context, LuisResult result) 
    {
        await context.PostAsync($"You have reached {result.Intents[0].Intent}. You said: {result.Query}");
        context.Wait(MessageReceived);
    }
}

