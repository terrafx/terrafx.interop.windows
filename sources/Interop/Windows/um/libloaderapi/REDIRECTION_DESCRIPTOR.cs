// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct REDIRECTION_DESCRIPTOR
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("ULONG")]
        public uint FunctionCount;

        [NativeTypeName("PCREDIRECTION_FUNCTION_DESCRIPTOR")]
        public REDIRECTION_FUNCTION_DESCRIPTOR* Redirections;
    }
}
