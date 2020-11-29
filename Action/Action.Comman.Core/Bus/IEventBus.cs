using Action.Comman.Core.Commands;
using Action.Comman.Core.Events;
using System.Threading.Tasks;

namespace Action.Comman.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;
        void Subcribe<T, TH>() where T : Event
                               where TH : IEventHandler<T>;
    }
}
