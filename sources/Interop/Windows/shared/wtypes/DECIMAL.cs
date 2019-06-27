// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\WTypesbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public struct DECIMAL
    {
        #region Fields
        public ushort wReserved;

        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("ULONG")]
        public uint Hi32;

        public _Anonymous2_e__Union Anonymous2;
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous1_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("USHORT")]
            public ushort signscale;
            #endregion

            #region Structs
            public struct _Anonymous_e__Struct
            {
                #region Fields
                [NativeTypeName("BYTE")]
                public byte scale;

                [NativeTypeName("BYTE")]
                public byte sign;
                #endregion
            }
            #endregion
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous2_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Lo64;
            #endregion

            #region Structs
            public struct _Anonymous_e__Struct
            {
                #region Fields
                [NativeTypeName("ULONG")]
                public uint Lo32;

                [NativeTypeName("ULONG")]
                public uint Mid32;
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
