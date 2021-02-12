// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CRL_DIST_POINT_NAME
    {
        [NativeTypeName("DWORD")]
        public uint dwDistPointNameChoice;

        [NativeTypeName("_CRL_DIST_POINT_NAME::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:4429:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref CERT_ALT_NAME_INFO FullName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FullName, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public CERT_ALT_NAME_INFO FullName;
        }
    }
}
