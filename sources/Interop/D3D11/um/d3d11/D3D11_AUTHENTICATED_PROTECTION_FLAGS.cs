// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct D3D11_AUTHENTICATED_PROTECTION_FLAGS
    {
        [FieldOffset(0)]
        [NativeTypeName("D3D11_AUTHENTICATED_PROTECTION_FLAGS::(anonymous struct at um/d3d11.h:10816:5)")]
        public _Flags_e__Struct Flags;

        [FieldOffset(0)]
        [NativeTypeName("UINT")]
        public uint Value;

        public partial struct _Flags_e__Struct
        {
            [NativeTypeName("UINT")]
            public uint ProtectionEnabled;

            [NativeTypeName("UINT")]
            public uint OverlayOrFullscreenRequired;

            [NativeTypeName("UINT")]
            public uint Reserved;
        }
    }
}
