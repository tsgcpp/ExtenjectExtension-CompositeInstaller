using UnityEngine;
using Zenject;

namespace ExtenjectExtension.CompositeInstaller.Tests.Installers.CompositeScriptableObjectInstallers
{
    // [CreateAssetMenu(fileName = "FooInjecteeInstaller", menuName = "Installers/FooInjecteeInstaller")]
    public class FooInjecteeInstaller : ScriptableObjectInstaller<FooInjecteeInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<FooInjectee>()
                .AsSingle()
                .NonLazy();
        }
    }
}