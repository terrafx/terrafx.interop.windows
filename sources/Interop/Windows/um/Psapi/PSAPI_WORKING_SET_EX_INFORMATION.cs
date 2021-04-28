// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PSAPI_WORKING_SET_EX_INFORMATION
    {
        [NativeTypeName("PVOID")]
        public void* VirtualAddress;

        public PSAPI_WORKING_SET_EX_BLOCK VirtualAttributes;
    }
}
