// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct TYPEDESC
    {
        #region Fields
        private _Anonymous_e__Union Anonymous;

        [NativeTypeName("VARTYPE")]
        public ushort vt;
        #endregion

        #region Properties
        public TYPEDESC* lptdesc
        {
            get
            {
                return Anonymous.lptdesc;
            }

            set
            {
                Anonymous.lptdesc = value;
            }
        }

        public ARRAYDESC* lpadesc
        {
            get
            {
                return Anonymous.lpadesc;
            }

            set
            {
                Anonymous.lpadesc = value;
            }
        }

        public uint hreftype
        {
            get
            {
                return Anonymous.hreftype;
            }

            set
            {
                Anonymous.hreftype = value;
            }
        }
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        [Unmanaged]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;

            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;

            [FieldOffset(0)]
            [NativeTypeName("HREFTYPE")]
            public uint hreftype;
            #endregion
        }
        #endregion
    }
}
