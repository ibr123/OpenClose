using Core.Models;

namespace Core.Interfaces
{
    public interface IDuckImplementation
    {
        DuckTemplate CreateTemplate(IDuck duck);
    }
}
