// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12CommandQueueDownlevel = new Guid(0x38a8c5ef, 0x7ccb, 0x4e81, 0x91, 0x4f, 0xa6, 0xe9, 0xd0, 0x72, 0xc4, 0x94);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DeviceDownlevel = new Guid(0x74eaee3f, 0x2f4b, 0x476d, 0x82, 0xba, 0x2b, 0x85, 0xcb, 0x49, 0xe3, 0x10);
    }
}
