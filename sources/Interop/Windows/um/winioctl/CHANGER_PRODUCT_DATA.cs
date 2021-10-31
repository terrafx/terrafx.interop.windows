// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CHANGER_PRODUCT_DATA
    {
        [NativeTypeName("BYTE [8]")]
        public fixed byte VendorId[8];

        [NativeTypeName("BYTE [16]")]
        public fixed byte ProductId[16];

        [NativeTypeName("BYTE [4]")]
        public fixed byte Revision[4];

        [NativeTypeName("BYTE [32]")]
        public fixed byte SerialNumber[32];

        public byte DeviceType;
    }
}
