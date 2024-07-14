// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX"]/*' />
public partial struct PROV_ENUMALGS_EX
{
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.aiAlgid"]/*' />
    [NativeTypeName("ALG_ID")]
    public uint aiAlgid;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwDefaultLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDefaultLen;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwMinLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinLen;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwMaxLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxLen;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwProtocols"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProtocols;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwNameLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNameLen;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.szName"]/*' />
    [NativeTypeName("CHAR[20]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwLongNameLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLongNameLen;

    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.szLongName"]/*' />
    [NativeTypeName("CHAR[40]")]
    public _szLongName_e__FixedBuffer szLongName;

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _szName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szLongName_e__FixedBuffer.xml' path='doc/member[@name="_szLongName_e__FixedBuffer"]/*' />
    [InlineArray(40)]
    public partial struct _szLongName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
