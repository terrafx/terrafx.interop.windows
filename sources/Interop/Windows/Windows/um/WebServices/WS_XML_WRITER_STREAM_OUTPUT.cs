// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct WS_XML_WRITER_STREAM_OUTPUT
{
    public WS_XML_WRITER_OUTPUT output;

    [NativeTypeName("WS_WRITE_CALLBACK")]
    public delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback;

    public void* writeCallbackState;
}
