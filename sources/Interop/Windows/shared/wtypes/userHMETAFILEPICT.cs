// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct userHMETAFILEPICT
    {
        [NativeTypeName("LONG")]
        public int fContext;

        [NativeTypeName("union __MIDL_IWinTypes_0005")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int hInproc;

            [FieldOffset(0)]
            [NativeTypeName("remoteMETAFILEPICT *")]
            public remoteMETAFILEPICT* hRemote;

            [FieldOffset(0)]
            [NativeTypeName("long long")]
            public long hInproc64;
        }
    }
}
