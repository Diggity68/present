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
            await Context.Channel.SendMessageAsync("YOU DID IT!!! I'M ALIIIIIIIIVE!!!!! :grin:");
        }

        [Command("flip")]
        public async Task flip()
        {
            await Context.Channel.SendMessageAsync("WHEEEEEEEEEE!!! :rofl: *FLIPS!!!*");
        }

        [Command("hungry?")]
        public async Task lunch()
        {
            await Context.Channel.SendMessageAsync("I didn't eat that guard, I swear!! *Hides the evidence...*");
        }

        [Command("spoiler")]
        public async Task spoil()
        {
            await Context.Channel.SendMessageAsync("I'm gonna be sealed in Kai in the future!?! :scream::scream::scream:");
        }

        [Command("strongest?")]
        public async Task favorites()
        {
            await Context.Channel.SendMessageAsync("Pfft, come on it's obviously-");
        }

        [Command("odd")]
        public async Task odd()
        {
            await Context.Channel.SendMessageAsync("How did Crimson know Jean was pregnant before me?");
        }

        [Command("angry")]
        public async Task angry()
        {
            await Context.Channel.SendMessageAsync(":anger::rage::anger:");
        }

        [Command("sayhi")]
        public async Task greet(IGuildUser user)
        {
            await Context.Channel.SendMessageAsync("Why hello there " + user.Mention + " :wink:");
        }

        [Command("!RIP")]
        public async Task rip()
        {
            await Context.Channel.SendMessageAsync("RRRRIP!!");
        }
    }
}
