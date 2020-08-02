// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct ELEMDESC
    {
        public TYPEDESC tdesc;

        [NativeTypeName("tagELEMDESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:725:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref IDLDESC idldesc => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.idldesc, 1));

        public ref PARAMDESC paramdesc => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.paramdesc, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public IDLDESC idldesc;

            [FieldOffset(0)]
            public PARAMDESC paramdesc;
        }
    }
}
