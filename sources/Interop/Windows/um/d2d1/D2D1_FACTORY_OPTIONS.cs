// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Allows additional parameters for factory creation.</summary>
    [Unmanaged]
    public struct D2D1_FACTORY_OPTIONS
    {
        #region Fields
        /// <summary>Requests a certain level of debugging information from the debug layer. This parameter is ignored if the debug layer DLL is not present.</summary>
        public D2D1_DEBUG_LEVEL debugLevel;
        #endregion
    }
}
