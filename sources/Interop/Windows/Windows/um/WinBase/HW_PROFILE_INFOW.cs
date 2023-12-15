// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW"]/*' />
public partial struct HW_PROFILE_INFOW
{
    /// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW.dwDockInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDockInfo;

    /// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW.szHwProfileGuid"]/*' />
    [NativeTypeName("WCHAR[39]")]
    public _szHwProfileGuid_e__FixedBuffer szHwProfileGuid;

    /// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW.szHwProfileName"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public _szHwProfileName_e__FixedBuffer szHwProfileName;

    /// <include file='_szHwProfileGuid_e__FixedBuffer.xml' path='doc/member[@name="_szHwProfileGuid_e__FixedBuffer"]/*' />
    [InlineArray(39)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szHwProfileGuid_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szHwProfileName_e__FixedBuffer.xml' path='doc/member[@name="_szHwProfileName_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szHwProfileName_e__FixedBuffer
    {
        public char e0;
    }
}
