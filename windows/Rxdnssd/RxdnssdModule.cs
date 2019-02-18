using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Rxdnssd.Rxdnssd
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RxdnssdModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RxdnssdModule"/>.
        /// </summary>
        internal RxdnssdModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "Rxdnssd";
            }
        }
    }
}
