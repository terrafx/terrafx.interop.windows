// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe struct VARDESC
    {
        [NativeTypeName("MEMBERID")]
        public int memid;

        [NativeTypeName("LPOLESTR")]
        public ushort* lpstrSchema;

        private _Anonymous_e__Union Anonymous;

        public ELEMDESC elemdescVar;

        [NativeTypeName("WORD")]
        public ushort wVarFlags;

        public VARKIND varkind;

        public uint oInst
        {
            get
            {
                return Anonymous.oInst;
            }

            set
            {
                Anonymous.oInst = value;
            }
        }

        public VARIANT* lpvarValue
        {
            get
            {
                return Anonymous.lpvarValue;
            }

            set
            {
                Anonymous.lpvarValue = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint oInst;

            [FieldOffset(0)]
            public VARIANT* lpvarValue;
        }
    }
}
