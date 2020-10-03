// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CHANNEL_ENCODER
    {
        [NativeTypeName("void *")]
        public void* createContext;

        [NativeTypeName("WS_CREATE_ENCODER_CALLBACK")]
        public delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, void**, IntPtr, int> createEncoderCallback;

        [NativeTypeName("WS_ENCODER_GET_CONTENT_TYPE_CALLBACK")]
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, int> encoderGetContentTypeCallback;

        [NativeTypeName("WS_ENCODER_START_CALLBACK")]
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> encoderStartCallback;

        [NativeTypeName("WS_ENCODER_ENCODE_CALLBACK")]
        public delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int> encoderEncodeCallback;

        [NativeTypeName("WS_ENCODER_END_CALLBACK")]
        public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, int> encoderEndCallback;

        [NativeTypeName("WS_FREE_ENCODER_CALLBACK")]
        public delegate* unmanaged<void*, void> freeEncoderCallback;
    }
}
