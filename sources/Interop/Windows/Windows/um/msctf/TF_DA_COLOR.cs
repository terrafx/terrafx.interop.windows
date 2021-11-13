// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct TF_DA_COLOR
    {
        public TF_DA_COLORTYPE type;

        [NativeTypeName("TF_DA_COLOR::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/msctf.h:10802:36)")]
        public _Anonymous_e__Union Anonymous;

        public ref int nIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.nIndex, 1));
            }
        }

        public ref COLORREF cr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cr, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public int nIndex;

            [FieldOffset(0)]
            public COLORREF cr;
        }
    }
}
