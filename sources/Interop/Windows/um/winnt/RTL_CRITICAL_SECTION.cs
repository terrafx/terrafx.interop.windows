// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RTL_CRITICAL_SECTION
    {
        [NativeTypeName("PRTL_CRITICAL_SECTION_DEBUG")]
        public RTL_CRITICAL_SECTION_DEBUG* DebugInfo;

        [NativeTypeName("LONG")]
        public int LockCount;

        [NativeTypeName("LONG")]
        public int RecursionCount;

        [NativeTypeName("HANDLE")]
        public IntPtr OwningThread;

        [NativeTypeName("HANDLE")]
        public IntPtr LockSemaphore;

        [NativeTypeName("ULONG_PTR")]
        public nuint SpinCount;
    }
}
