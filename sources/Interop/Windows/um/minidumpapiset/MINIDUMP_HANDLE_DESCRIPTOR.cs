// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_HANDLE_DESCRIPTOR
    {
        [NativeTypeName("ULONG64")]
        public ulong Handle;

        [NativeTypeName("RVA")]
        public uint TypeNameRva;

        [NativeTypeName("RVA")]
        public uint ObjectNameRva;

        [NativeTypeName("ULONG32")]
        public uint Attributes;

        [NativeTypeName("ULONG32")]
        public uint GrantedAccess;

        [NativeTypeName("ULONG32")]
        public uint HandleCount;

        [NativeTypeName("ULONG32")]
        public uint PointerCount;
    }
}
