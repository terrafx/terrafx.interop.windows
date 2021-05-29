// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SERVICE_CONTRACT
    {
        [NativeTypeName("const WS_CONTRACT_DESCRIPTION *")]
        public WS_CONTRACT_DESCRIPTION* contractDescription;

        [NativeTypeName("WS_SERVICE_MESSAGE_RECEIVE_CALLBACK")]
        public delegate* unmanaged<IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> defaultMessageHandlerCallback;

        [NativeTypeName("const void *")]
        public void* methodTable;
    }
}
