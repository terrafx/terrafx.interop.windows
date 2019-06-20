// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct DXGI_HDR_METADATA_HDR10
    {
        #region Fields
        [NativeTypeName("UINT16[2]")]
        public fixed ushort RedPrimary[2];

        [NativeTypeName("UINT16[2]")]
        public fixed ushort GreenPrimary[2];

        [NativeTypeName("UINT16[2]")]
        public fixed ushort BluePrimary[2];

        [NativeTypeName("UINT16[2]")]
        public fixed ushort WhitePoint[2];

        [NativeTypeName("UINT")]
        public uint MaxMasteringLuminance;

        [NativeTypeName("UINT")]
        public uint MinMasteringLuminance;

        [NativeTypeName("UINT16")]
        public ushort MaxContentLightLevel;

        [NativeTypeName("UINT16")]
        public ushort MaxFrameAverageLightLevel;
        #endregion
    }
}
