// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PSS_ALLOCATOR
    {
        [NativeTypeName("void *")]
        public void* Context;

        [NativeTypeName("void *(*)(void *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<void*, uint, void*> AllocRoutine;

        [NativeTypeName("void (*)(void *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<void*, void*, void> FreeRoutine;
    }
}
