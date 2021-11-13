// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WS_SERVICE_PROPERTY_CLOSE_CALLBACK
    {
        [NativeTypeName("WS_SERVICE_CLOSE_CHANNEL_CALLBACK")]
        public delegate* unmanaged<IntPtr, WS_ASYNC_CONTEXT*, HRESULT> callback;
    }
}
