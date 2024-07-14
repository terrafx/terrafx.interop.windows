// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1"]/*' />
public partial struct MIBICMPSTATS_EX_XPSP1
{
    /// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1.dwMsgs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMsgs;

    /// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1.dwErrors"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwErrors;

    /// <include file='MIBICMPSTATS_EX_XPSP1.xml' path='doc/member[@name="MIBICMPSTATS_EX_XPSP1.rgdwTypeCount"]/*' />
    [NativeTypeName("DWORD[256]")]
    public _rgdwTypeCount_e__FixedBuffer rgdwTypeCount;

    /// <include file='_rgdwTypeCount_e__FixedBuffer.xml' path='doc/member[@name="_rgdwTypeCount_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _rgdwTypeCount_e__FixedBuffer
    {
        public uint e0;
    }
}
