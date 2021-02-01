using UnityEngine;
using Zenject;

namespace ExtenjectExtension.CompositeInstaller.Tests.Installers.CompositeMonoInstallers
{
    public class Foo
    {
    }

    public class FooInstaller : MonoInstaller<FooInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}