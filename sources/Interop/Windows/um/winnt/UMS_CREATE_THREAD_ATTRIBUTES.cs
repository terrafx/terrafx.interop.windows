// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct UMS_CREATE_THREAD_ATTRIBUTES
    {
        [NativeTypeName("DWORD")]
        public uint UmsVersion;

        [NativeTypeName("PVOID")]
        public void* UmsContext;

        [NativeTypeName("PVOID")]
        public void* UmsCompletionList;
    }
}
