// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CHANNEL_ENCODER
    {
        [NativeTypeName("void *")]
        public void* createContext;

        [NativeTypeName("WS_CREATE_ENCODER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, void**, IntPtr, int> createEncoderCallback;
#else
        public void* _createEncoderCallback;

        public delegate* unmanaged[Stdcall]<void*, delegate* unmanaged[Stdcall]<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, void**, IntPtr, int> createEncoderCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, delegate* unmanaged[Stdcall]<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, void**, IntPtr, int>)_createEncoderCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _createEncoderCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ENCODER_GET_CONTENT_TYPE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, int> encoderGetContentTypeCallback;
#else
        public void* _encoderGetContentTypeCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, int> encoderGetContentTypeCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, int>)_encoderGetContentTypeCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _encoderGetContentTypeCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ENCODER_START_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> encoderStartCallback;
#else
        public void* _encoderStartCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int> encoderStartCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_encoderStartCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _encoderStartCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ENCODER_ENCODE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int> encoderEncodeCallback;
#else
        public void* _encoderEncodeCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int> encoderEncodeCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int>)_encoderEncodeCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _encoderEncodeCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_ENCODER_END_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> encoderEndCallback;
#else
        public void* _encoderEndCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int> encoderEndCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_encoderEndCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _encoderEndCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_FREE_ENCODER_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void> freeEncoderCallback;
#else
        public void* _freeEncoderCallback;

        public delegate* unmanaged[Stdcall]<void*, void> freeEncoderCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void>)_freeEncoderCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _freeEncoderCallback = value;
            }
        }
#endif
    }
}
