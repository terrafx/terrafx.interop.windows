// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CREATE_THREAD_DEBUG_INFO
    {
        [NativeTypeName("HANDLE")]
        public IntPtr hThread;

        [NativeTypeName("LPVOID")]
        public void* lpThreadLocalBase;

        [NativeTypeName("LPTHREAD_START_ROUTINE")]
        public IntPtr* lpStartAddress;
    }
}
