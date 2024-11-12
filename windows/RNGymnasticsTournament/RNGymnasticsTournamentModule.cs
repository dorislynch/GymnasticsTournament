using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Gymnastics.Tournament.RNGymnasticsTournament
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNGymnasticsTournamentModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNGymnasticsTournamentModule"/>.
        /// </summary>
        internal RNGymnasticsTournamentModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNGymnasticsTournament";
            }
        }
    }
}
