// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NEWCPLINFOA
{
    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.dwHelpContext"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHelpContext;

    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.lData"]/*' />
    [NativeTypeName("LONG_PTR")]
    public nint lData;

    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.szName"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.szInfo"]/*' />
    [NativeTypeName("CHAR[64]")]
    public _szInfo_e__FixedBuffer szInfo;

    /// <include file='NEWCPLINFOA.xml' path='doc/member[@name="NEWCPLINFOA.szHelpFile"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _szHelpFile_e__FixedBuffer szHelpFile;

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szInfo_e__FixedBuffer.xml' path='doc/member[@name="_szInfo_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szInfo_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szHelpFile_e__FixedBuffer.xml' path='doc/member[@name="_szHelpFile_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(128)]
    public partial struct _szHelpFile_e__FixedBuffer
    {
        public sbyte e0;
    }
}
