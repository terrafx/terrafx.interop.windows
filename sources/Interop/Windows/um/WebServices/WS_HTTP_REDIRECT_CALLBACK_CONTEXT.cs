// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_HTTP_REDIRECT_CALLBACK_CONTEXT
    {
        [NativeTypeName("WS_HTTP_REDIRECT_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, int> callback;
#else
        public void* _callback;

        public delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, int> callback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, int>)_callback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _callback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* state;
    }
}
