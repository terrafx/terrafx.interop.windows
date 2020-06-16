// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct wireSAFEARRAY_UNION
    {
        [NativeTypeName("ULONG")]
        public uint sfType;

        [NativeTypeName("union __MIDL_IOleAutomationTypes_0001")]
        public _u_e__Struct u;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u_e__Struct
        {
            [FieldOffset(0)]
            [NativeTypeName("SAFEARR_BSTR")]
            public wireSAFEARR_BSTR BstrStr;

            [FieldOffset(0)]
            [NativeTypeName("SAFEARR_UNKNOWN")]
            public wireSAFEARR_UNKNOWN UnknownStr;

            [FieldOffset(0)]
            [NativeTypeName("SAFEARR_DISPATCH")]
            public wireSAFEARR_DISPATCH DispatchStr;

            [FieldOffset(0)]
            [NativeTypeName("SAFEARR_VARIANT")]
            public wireSAFEARR_VARIANT VariantStr;

            [FieldOffset(0)]
            [NativeTypeName("SAFEARR_BRECORD")]
            public wireSAFEARR_BRECORD RecordStr;

            [FieldOffset(0)]
            [NativeTypeName("SAFEARR_HAVEIID")]
            public wireSAFEARR_HAVEIID HaveIidStr;

            [FieldOffset(0)]
            public BYTE_SIZEDARR ByteStr;

            [FieldOffset(0)]
            [NativeTypeName("WORD_SIZEDARR")]
            public SHORT_SIZEDARR WordStr;

            [FieldOffset(0)]
            [NativeTypeName("DWORD_SIZEDARR")]
            public LONG_SIZEDARR LongStr;

            [FieldOffset(0)]
            public HYPER_SIZEDARR HyperStr;
        }
    }
}
