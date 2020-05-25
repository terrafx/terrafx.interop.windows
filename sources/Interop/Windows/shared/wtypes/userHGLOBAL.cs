// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct userHGLOBAL
    {
        [NativeTypeName("LONG")]
        public int fContext;

        [NativeTypeName("union __MIDL_IWinTypes_0003")]
        public _u_e__Struct u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Struct
        {
            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int hInproc;

            [FieldOffset(0)]
            [NativeTypeName("FLAGGED_BYTE_BLOB *")]
            public FLAGGED_BYTE_BLOB* hRemote;

            [FieldOffset(0)]
            [NativeTypeName("long long")]
            public long hInproc64;
        }
    }
}
