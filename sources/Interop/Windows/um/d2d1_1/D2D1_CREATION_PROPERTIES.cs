// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>This specifies the options while simultaneously creating the device, factory, and device context.</summary>
    public struct D2D1_CREATION_PROPERTIES
    {
        #region Fields
        /// <summary>Describes locking behavior of D2D resources</summary>
        public D2D1_THREADING_MODE threadingMode;

        public D2D1_DEBUG_LEVEL debugLevel;

        public D2D1_DEVICE_CONTEXT_OPTIONS options;
        #endregion
    }
}
