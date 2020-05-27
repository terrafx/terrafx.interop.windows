// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TYPEDESC
    {
        [NativeTypeName("tagTYPEDESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:645:36)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("VARTYPE")]
        public ushort vt;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct tagTYPEDESC *")]
            public TYPEDESC* lptdesc;

            [FieldOffset(0)]
            [NativeTypeName("struct tagARRAYDESC *")]
            public ARRAYDESC* lpadesc;

            [FieldOffset(0)]
            [NativeTypeName("HREFTYPE")]
            public uint hreftype;
        }
    }
}
