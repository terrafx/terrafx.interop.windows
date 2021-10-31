// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct XSTATE_CONTEXT_X86
    {
        [NativeTypeName("DWORD64")]
        public ulong Mask;

        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("DWORD")]
        public uint Reserved1;

        [NativeTypeName("PXSAVE_AREA")]
        public XSAVE_AREA* Area;

        [NativeTypeName("DWORD")]
        public uint Reserved2;

        [NativeTypeName("PVOID")]
        public void* Buffer;

        [NativeTypeName("DWORD")]
        public uint Reserved3;
    }
}
