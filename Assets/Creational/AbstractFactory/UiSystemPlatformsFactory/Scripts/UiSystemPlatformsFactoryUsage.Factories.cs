using UnityEngine;

namespace AbstractFactory
{
    public partial class UiSystemPlatformsFactoryUsage
    {
        #region Factory

        /// <summary>
        ///     The factory interface with the necessary types and methods.
        /// </summary>
        /// <typeparam name="TPs4"></typeparam>
        /// <typeparam name="TXbox"></typeparam>
        /// <typeparam name="TBase"></typeparam>
        public interface IPs4XboxBaseFactory<TPs4, TXbox, TBase>
        {
            TPs4 CreatePs4();
            TXbox CreateXbox();
            TBase CreateSystem(RuntimePlatform platform);
        }

        #endregion

        #region Concrete Factory Base

        public class Ps4XboxBaseFactory<TPs4, TXbox, TBase> : IPs4XboxBaseFactory<TPs4, TXbox, TBase>
            where TPs4 : TBase, new()
            where TXbox : TBase, new()
        {
            public TPs4 CreatePs4() => new TPs4();

            public TXbox CreateXbox() => new TXbox();

            public TBase CreateSystem(RuntimePlatform platform)
            {
                if (platform != RuntimePlatform.PS4 && platform != RuntimePlatform.XboxOne)
                    Debug.LogError("Platform not supported: " + platform);

                if (platform == RuntimePlatform.PS4)
                    return CreatePs4();

                return CreateXbox();
            }
        }

        #endregion
    }
}