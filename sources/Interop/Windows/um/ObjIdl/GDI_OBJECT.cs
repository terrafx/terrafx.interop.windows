// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct GDI_OBJECT
    {
        [NativeTypeName("DWORD")]
        public uint ObjectType;

        [NativeTypeName("union __MIDL_IAdviseSink_0002")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("wireHBITMAP")]
            public userHBITMAP* hBitmap;

            [FieldOffset(0)]
            [NativeTypeName("wireHPALETTE")]
            public userHPALETTE* hPalette;

            [FieldOffset(0)]
            [NativeTypeName("wireHGLOBAL")]
            public userHGLOBAL* hGeneric;
        }
    }
}
