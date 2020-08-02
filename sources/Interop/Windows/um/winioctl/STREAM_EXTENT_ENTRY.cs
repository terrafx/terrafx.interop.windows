// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STREAM_EXTENT_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:14692:5)")]
        public _ExtentInformation_e__Union ExtentInformation;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _ExtentInformation_e__Union
        {
            [FieldOffset(0)]
            public RETRIEVAL_POINTERS_BUFFER RetrievalPointers;
        }
    }
}
