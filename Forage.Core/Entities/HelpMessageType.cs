using Forage.Core.Entities.BaseEntities;

namespace Forage.Core.Entities
{
    public class HelpMessageType:BaseEntitiy
    {
        public string Title { get; set; }
        public List<HelpMessage>? HelpMessages { get; set; }
    }
}
