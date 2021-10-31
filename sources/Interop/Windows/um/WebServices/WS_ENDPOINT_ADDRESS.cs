// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_ENDPOINT_ADDRESS
    {
        public WS_STRING url;

        public IntPtr headers;

        public IntPtr extensions;

        public WS_ENDPOINT_IDENTITY* identity;
    }
}
