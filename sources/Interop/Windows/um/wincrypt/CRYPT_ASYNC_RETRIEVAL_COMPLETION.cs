// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_ASYNC_RETRIEVAL_COMPLETION
    {
        [NativeTypeName("PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, uint, sbyte*, sbyte*, void*, void> pfnCompletion;
#else
        public void* _pfnCompletion;

        public delegate* unmanaged[Stdcall]<void*, uint, sbyte*, sbyte*, void*, void> pfnCompletion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, uint, sbyte*, sbyte*, void*, void>)_pfnCompletion;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnCompletion = value;
            }
        }
#endif

        [NativeTypeName("LPVOID")]
        public void* pvCompletion;
    }
}
