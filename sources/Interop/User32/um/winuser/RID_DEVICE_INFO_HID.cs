// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RID_DEVICE_INFO_HID
    {
        [NativeTypeName("DWORD")]
        public uint dwVendorId;

        [NativeTypeName("DWORD")]
        public uint dwProductId;

        [NativeTypeName("DWORD")]
        public uint dwVersionNumber;

        [NativeTypeName("USHORT")]
        public ushort usUsagePage;

        [NativeTypeName("USHORT")]
        public ushort usUsage;
    }
}
