// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO"]/*' />
public partial struct NAMED_PROFILE_INFO
{
    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.dwCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCount;

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.dwCountDevCoordinates"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCountDevCoordinates;

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.szPrefix"]/*' />
    [NativeTypeName("COLOR_NAME")]
    public _szPrefix_e__FixedBuffer szPrefix;

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.szSuffix"]/*' />
    [NativeTypeName("COLOR_NAME")]
    public _szSuffix_e__FixedBuffer szSuffix;

    /// <include file='_szPrefix_e__FixedBuffer.xml' path='doc/member[@name="_szPrefix_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _szPrefix_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szSuffix_e__FixedBuffer.xml' path='doc/member[@name="_szSuffix_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _szSuffix_e__FixedBuffer
    {
        public sbyte e0;
    }
}
