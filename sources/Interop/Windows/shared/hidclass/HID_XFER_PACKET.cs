// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct HID_XFER_PACKET
    {
        [NativeTypeName("PUCHAR")]
        public byte* reportBuffer;

        [NativeTypeName("ULONG")]
        public uint reportBufferLen;

        [NativeTypeName("UCHAR")]
        public byte reportId;
    }
}
