using System.Collections.Generic;
using Zenject;

namespace ExtenjectExtension.CompositeInstaller
{
    public interface ICompositeInstaller<out T> : IInstaller where T : IInstaller
    {
        IReadOnlyList<T> LeafInstallers { get; }
    }
}