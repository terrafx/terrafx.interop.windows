// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA
    {
        [NativeTypeName("DWORD")]
        public uint TaskIndex;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort ClassName[260];

        [NativeTypeName("LONG")]
        public int BasePriority;
    }
}
