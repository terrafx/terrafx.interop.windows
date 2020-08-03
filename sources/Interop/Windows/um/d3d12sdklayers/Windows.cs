// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid DXGI_DEBUG_D3D12 = new Guid(0xcf59a98c, 0xa950, 0x4326, 0x91, 0xef, 0x9b, 0xba, 0xa1, 0x7b, 0xfd, 0x95);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12Debug = new Guid(0x344488b7, 0x6846, 0x474b, 0xb9, 0x89, 0xf0, 0x27, 0x44, 0x82, 0x45, 0xe0);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12Debug1 = new Guid(0xaffaa4ca, 0x63fe, 0x4d8e, 0xb8, 0xad, 0x15, 0x90, 0x00, 0xaf, 0x43, 0x04);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12Debug2 = new Guid(0x93a665c4, 0xa3b2, 0x4e5d, 0xb6, 0x92, 0xa2, 0x6a, 0xe1, 0x4e, 0x33, 0x74);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12Debug3 = new Guid(0x5cf4e58f, 0xf671, 0x4ff1, 0xa5, 0x42, 0x36, 0x86, 0xe3, 0xd1, 0x53, 0xd1);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DebugDevice1 = new Guid(0xa9b71770, 0xd099, 0x4a65, 0xa6, 0x98, 0x3d, 0xee, 0x10, 0x02, 0x0f, 0x88);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DebugDevice = new Guid(0x3febd6dd, 0x4973, 0x4787, 0x81, 0x94, 0xe4, 0x5f, 0x9e, 0x28, 0x92, 0x3e);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DebugDevice2 = new Guid(0x60eccbc1, 0x378d, 0x4df1, 0x89, 0x4c, 0xf8, 0xac, 0x5c, 0xe4, 0xd7, 0xdd);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DebugCommandQueue = new Guid(0x09e0bf36, 0x54ac, 0x484f, 0x88, 0x47, 0x4b, 0xae, 0xea, 0xb6, 0x05, 0x3a);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DebugCommandList1 = new Guid(0x102ca951, 0x311b, 0x4b01, 0xb1, 0x1f, 0xec, 0xb8, 0x3e, 0x06, 0x1b, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DebugCommandList = new Guid(0x09e0bf36, 0x54ac, 0x484f, 0x88, 0x47, 0x4b, 0xae, 0xea, 0xb6, 0x05, 0x3f);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12DebugCommandList2 = new Guid(0xaeb575cf, 0x4e06, 0x48be, 0xba, 0x3b, 0xc4, 0x50, 0xfc, 0x96, 0x65, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12SharingContract = new Guid(0x0adf7d52, 0x929c, 0x4e61, 0xad, 0xdb, 0xff, 0xed, 0x30, 0xde, 0x66, 0xef);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12InfoQueue = new Guid(0x0742a90b, 0xc387, 0x483f, 0xb9, 0x46, 0x30, 0xa7, 0xe4, 0xe6, 0x14, 0x58);

        [NativeTypeName("#define D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
        public const int D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
    }
}
