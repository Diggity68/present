using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Present
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();


        private DiscordSocketClient _client;

        private CommandHandler _handler;

        Random rand;
        string[] randomTexts;

        

        public async Task StartAsync()
        {

            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "(Bot Token *From Discord*);

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }

    }
}
