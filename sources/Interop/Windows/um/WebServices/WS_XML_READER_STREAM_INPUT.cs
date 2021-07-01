// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_READER_STREAM_INPUT
    {
        public WS_XML_READER_INPUT input;

        [NativeTypeName("WS_READ_CALLBACK")]
        public delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int> readCallback;

        public void* readCallbackState;
    }
}
