// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcCompilerArgs = new Guid(0x3e56ae82, 0x224d, 0x470f, 0xa1, 0xa1, 0xfe, 0x30, 0x16, 0xee, 0x9f, 0x9d);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcLibrary = new Guid(0x6245d6af, 0x66e0, 0x48fd, 0x80, 0xb4, 0x4d, 0x27, 0x17, 0x96, 0x74, 0x8c);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcUtils = CLSID_DxcLibrary;

        public static readonly Guid IID_IDxcResult = new Guid(0x58346CDA, 0xDDE7, 0x4497, 0x94, 0x61, 0x6F, 0x87, 0xAF, 0x5E, 0x06, 0x59);

        public static readonly Guid IID_IDxcCompilerArgs = new Guid(0x73EFFE2A, 0x70DC, 0x45F8, 0x96, 0x90, 0xEF, 0xF6, 0x4C, 0x02, 0x42, 0x9D);

        public static readonly Guid IID_IDxcCompiler3 = new Guid(0x228B4687, 0x5A6A, 0x4730, 0x90, 0x0C, 0x97, 0x02, 0xB2, 0x20, 0x3F, 0x54);

        public static readonly Guid IID_IDxcBlobUtf16 = new Guid(0xA3F84EAB, 0x0FAA, 0x497E, 0xA3, 0x9C, 0xEE, 0x6E, 0xD6, 0x0B, 0x2D, 0x84);

        public static readonly Guid IID_IDxcBlobUtf8 = new Guid(0x3DA636C9, 0xBA71, 0x4024, 0xA3, 0x01, 0x30, 0xCB, 0xF1, 0x25, 0x30, 0x5B);

        public static readonly Guid IID_IDxcUtils = new Guid(0x4605C4CB, 0x2019, 0x492A, 0xAD, 0xA4, 0x65, 0xF2, 0x0B, 0xB7, 0xD6, 0x7F);
    }
}
