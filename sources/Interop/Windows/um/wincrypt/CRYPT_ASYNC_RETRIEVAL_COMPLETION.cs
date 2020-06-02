// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_ASYNC_RETRIEVAL_COMPLETION
    {
        [NativeTypeName("PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC")]
        public delegate* stdcall<void*, uint, sbyte*, sbyte*, void*, void> pfnCompletion;

        [NativeTypeName("LPVOID")]
        public void* pvCompletion;
    }
}
