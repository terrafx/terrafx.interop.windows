// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct VARDESC
    {
        #region Fields
        [NativeTypeName("MEMBERID")]
        public int memid;

        [NativeTypeName("LPOLESTR")]
        public char* lpstrSchema;

        private _Anonymous_e__Union Anonymous;

        public ELEMDESC elemdescVar;

        [NativeTypeName("WORD")]
        public ushort wVarFlags;

        public VARKIND varkind;
        #endregion

        #region Properties
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
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint oInst;

            [FieldOffset(0)]
            public VARIANT* lpvarValue;
            #endregion
        }
        #endregion
    }
}
