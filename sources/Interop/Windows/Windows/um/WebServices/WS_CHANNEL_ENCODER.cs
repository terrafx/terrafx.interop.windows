// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct WS_CHANNEL_ENCODER
{
    public void* createContext;

    [NativeTypeName("WS_CREATE_ENCODER_CALLBACK")]
    public delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT>, void*, void**, IntPtr, HRESULT> createEncoderCallback;

    [NativeTypeName("WS_ENCODER_GET_CONTENT_TYPE_CALLBACK")]
    public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, HRESULT> encoderGetContentTypeCallback;

    [NativeTypeName("WS_ENCODER_START_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> encoderStartCallback;

    [NativeTypeName("WS_ENCODER_ENCODE_CALLBACK")]
    public delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> encoderEncodeCallback;

    [NativeTypeName("WS_ENCODER_END_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> encoderEndCallback;

    [NativeTypeName("WS_FREE_ENCODER_CALLBACK")]
    public delegate* unmanaged<void*, void> freeEncoderCallback;
}
