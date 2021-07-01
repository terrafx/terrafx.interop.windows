// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SEND_GENERIC_TLS_EXTENSION
    {
        [NativeTypeName("WORD")]
        public ushort ExtensionType;

        [NativeTypeName("WORD")]
        public ushort HandshakeType;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("WORD")]
        public ushort BufferSize;

        [NativeTypeName("UCHAR [1]")]
        public fixed byte Buffer[1];
    }
}
