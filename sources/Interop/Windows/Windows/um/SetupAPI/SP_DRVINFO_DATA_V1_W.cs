// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DRVINFO_DATA_V1_W.xml' path='doc/member[@name="SP_DRVINFO_DATA_V1_W"]/*' />
public partial struct SP_DRVINFO_DATA_V1_W
{
    /// <include file='SP_DRVINFO_DATA_V1_W.xml' path='doc/member[@name="SP_DRVINFO_DATA_V1_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DRVINFO_DATA_V1_W.xml' path='doc/member[@name="SP_DRVINFO_DATA_V1_W.DriverType"]/*' />
    [NativeTypeName("DWORD")]
    public uint DriverType;

    /// <include file='SP_DRVINFO_DATA_V1_W.xml' path='doc/member[@name="SP_DRVINFO_DATA_V1_W.Reserved"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;

    /// <include file='SP_DRVINFO_DATA_V1_W.xml' path='doc/member[@name="SP_DRVINFO_DATA_V1_W.Description"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='SP_DRVINFO_DATA_V1_W.xml' path='doc/member[@name="SP_DRVINFO_DATA_V1_W.MfgName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _MfgName_e__FixedBuffer MfgName;

    /// <include file='SP_DRVINFO_DATA_V1_W.xml' path='doc/member[@name="SP_DRVINFO_DATA_V1_W.ProviderName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _ProviderName_e__FixedBuffer ProviderName;

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _Description_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_MfgName_e__FixedBuffer.xml' path='doc/member[@name="_MfgName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _MfgName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_ProviderName_e__FixedBuffer.xml' path='doc/member[@name="_ProviderName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _ProviderName_e__FixedBuffer
    {
        public char e0;
    }
}
