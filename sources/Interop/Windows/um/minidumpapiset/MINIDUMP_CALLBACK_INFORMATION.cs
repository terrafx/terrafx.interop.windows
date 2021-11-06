// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe partial struct MINIDUMP_CALLBACK_INFORMATION
    {
        [NativeTypeName("MINIDUMP_CALLBACK_ROUTINE")]
        public delegate* unmanaged<void*, MINIDUMP_CALLBACK_INPUT*, MINIDUMP_CALLBACK_OUTPUT*, BOOL> CallbackRoutine;

        [NativeTypeName("PVOID")]
        public void* CallbackParam;
    }
}
