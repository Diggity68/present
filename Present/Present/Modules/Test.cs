using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace Present.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task something()
        {
            await Context.Channel.SendMessageAsync("YOU DID IT!!! I'M ALIIIIIIIIVE!!!!!");
        }

        [Command("flip")]
        public async Task flip()
        {
            await Context.Channel.SendMessageAsync("WHEEEEEEEEEE!!! *Flips*");
        }

        [Command("sayhi")]
        public async Task greet(IGuildUser user)
        {
            await Context.Channel.SendMessageAsync("Hi!");
        }
    }
}
