using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Microsoft.Bot.Sample.LuisBot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(ConfigurationManager.AppSettings["LuisAppId"], ConfigurationManager.AppSettings["LuisAPIKey"])))
        {
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the Greeting intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }   

        [LuisIntent("Services")]
        public async Task Services(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the Services intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("Locations")]
        public async Task Locations(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the Locations intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("Transport")]
        public async Task Transport(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the Transport intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }
    }
}