// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_SYMBOL
{
    /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.N"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L19818_C5")]
    public _N_e__Union N;

    /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.Value"]/*' />
    [NativeTypeName("DWORD")]
    public uint Value;

    /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.SectionNumber"]/*' />
    public short SectionNumber;

    /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.Type"]/*' />
    [NativeTypeName("WORD")]
    public ushort Type;

    /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.StorageClass"]/*' />
    public byte StorageClass;

    /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.NumberOfAuxSymbols"]/*' />
    public byte NumberOfAuxSymbols;

    /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public partial struct _N_e__Union
    {
        /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union.ShortName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BYTE[8]")]
        public _ShortName_e__FixedBuffer ShortName;

        /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union.Name"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L19820_C9")]
        public _Name_e__Struct Name;

        /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union.LongName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[2]")]
        public _LongName_e__FixedBuffer LongName;

        /// <include file='_Name_e__Struct.xml' path='doc/member[@name="_Name_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public partial struct _Name_e__Struct
        {
            /// <include file='_Name_e__Struct.xml' path='doc/member[@name="_Name_e__Struct.Short"]/*' />
            [NativeTypeName("DWORD")]
            public uint Short;

            /// <include file='_Name_e__Struct.xml' path='doc/member[@name="_Name_e__Struct.Long"]/*' />
            [NativeTypeName("DWORD")]
            public uint Long;
        }

        /// <include file='_ShortName_e__FixedBuffer.xml' path='doc/member[@name="_ShortName_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(8)]
        public partial struct _ShortName_e__FixedBuffer
        {
            public byte e0;
        }

        /// <include file='_LongName_e__FixedBuffer.xml' path='doc/member[@name="_LongName_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(2)]
        public partial struct _LongName_e__FixedBuffer
        {
            public uint e0;
        }
    }
}
