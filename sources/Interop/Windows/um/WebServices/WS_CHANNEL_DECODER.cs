// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CHANNEL_DECODER
    {
        [NativeTypeName("void *")]
        public void* createContext;

        [NativeTypeName("WS_CREATE_DECODER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, void**, IntPtr, int> createDecoderCallback;
#else
        public void* _createDecoderCallback;

        public delegate* unmanaged[Stdcall]<void*, delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, void**, IntPtr, int> createDecoderCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, void**, IntPtr, int>)_createDecoderCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _createDecoderCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_DECODER_GET_CONTENT_TYPE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, int> decoderGetContentTypeCallback;
#else
        public void* _decoderGetContentTypeCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, int> decoderGetContentTypeCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, int>)_decoderGetContentTypeCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _decoderGetContentTypeCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_DECODER_START_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> decoderStartCallback;
#else
        public void* _decoderStartCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int> decoderStartCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_decoderStartCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _decoderStartCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_DECODER_DECODE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int> decoderDecodeCallback;
#else
        public void* _decoderDecodeCallback;

        public delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int> decoderDecodeCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int>)_decoderDecodeCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _decoderDecodeCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_DECODER_END_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> decoderEndCallback;
#else
        public void* _decoderEndCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int> decoderEndCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_decoderEndCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _decoderEndCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_FREE_DECODER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void> freeDecoderCallback;
#else
        public void* _freeDecoderCallback;

        public delegate* unmanaged[Stdcall]<void*, void> freeDecoderCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void>)_freeDecoderCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _freeDecoderCallback = value;
            }
        }
#endif
    }
}
