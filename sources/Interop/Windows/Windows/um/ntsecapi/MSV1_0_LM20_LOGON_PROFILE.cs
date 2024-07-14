// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE"]/*' />
public partial struct MSV1_0_LM20_LOGON_PROFILE
{
    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.MessageType"]/*' />
    public MSV1_0_PROFILE_BUFFER_TYPE MessageType;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.KickOffTime"]/*' />
    public LARGE_INTEGER KickOffTime;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LogoffTime"]/*' />
    public LARGE_INTEGER LogoffTime;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.UserFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint UserFlags;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.UserSessionKey"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public _UserSessionKey_e__FixedBuffer UserSessionKey;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LogonDomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonDomainName;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LanmanSessionKey"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public _LanmanSessionKey_e__FixedBuffer LanmanSessionKey;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LogonServer"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonServer;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.UserParameters"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserParameters;

    /// <include file='_UserSessionKey_e__FixedBuffer.xml' path='doc/member[@name="_UserSessionKey_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _UserSessionKey_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_LanmanSessionKey_e__FixedBuffer.xml' path='doc/member[@name="_LanmanSessionKey_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _LanmanSessionKey_e__FixedBuffer
    {
        public byte e0;
    }
}
