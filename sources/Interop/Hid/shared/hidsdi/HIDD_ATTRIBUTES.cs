// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct HIDD_ATTRIBUTES
    {
        [NativeTypeName("ULONG")]
        public uint Size;

        [NativeTypeName("USHORT")]
        public ushort VendorID;

        [NativeTypeName("USHORT")]
        public ushort ProductID;

        [NativeTypeName("USHORT")]
        public ushort VersionNumber;
    }
}
