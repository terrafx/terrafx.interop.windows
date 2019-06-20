// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgicommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct DXGI_SAMPLE_DESC
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint Count;

        [NativeTypeName("UINT")]
        public uint Quality;
        #endregion
    }
}
