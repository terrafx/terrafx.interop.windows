// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA"]/*' />
public partial struct HW_PROFILE_INFOA
{
    /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.dwDockInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDockInfo;

    /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.szHwProfileGuid"]/*' />
    [NativeTypeName("CHAR[39]")]
    public _szHwProfileGuid_e__FixedBuffer szHwProfileGuid;

    /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.szHwProfileName"]/*' />
    [NativeTypeName("CHAR[80]")]
    public _szHwProfileName_e__FixedBuffer szHwProfileName;

    /// <include file='_szHwProfileGuid_e__FixedBuffer.xml' path='doc/member[@name="_szHwProfileGuid_e__FixedBuffer"]/*' />
    [InlineArray(39)]
    public partial struct _szHwProfileGuid_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szHwProfileName_e__FixedBuffer.xml' path='doc/member[@name="_szHwProfileName_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    public partial struct _szHwProfileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
