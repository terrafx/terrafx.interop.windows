// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeUpdateImageIDList
{
    /// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList.cb"]/*' />
    public ushort cb;

    /// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList.iIconIndex"]/*' />
    public int iIconIndex;

    /// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList.iCurIndex"]/*' />
    public int iCurIndex;

    /// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList.uFlags"]/*' />
    public uint uFlags;

    /// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList.dwProcessID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProcessID;

    /// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList.szName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='SHChangeUpdateImageIDList.xml' path='doc/member[@name="SHChangeUpdateImageIDList.cbZero"]/*' />
    public ushort cbZero;

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szName_e__FixedBuffer
    {
        public char e0;
    }
}
