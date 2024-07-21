// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION"]/*' />
public unsafe partial struct TOKEN_LOGGING_INFORMATION
{
    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.TokenType"]/*' />
    public TOKEN_TYPE TokenType;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.TokenElevation"]/*' />
    public TOKEN_ELEVATION TokenElevation;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.TokenElevationType"]/*' />
    public TOKEN_ELEVATION_TYPE TokenElevationType;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.ImpersonationLevel"]/*' />
    public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.IntegrityLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint IntegrityLevel;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.User"]/*' />
    public SID_AND_ATTRIBUTES User;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.TrustLevelSid"]/*' />
    [NativeTypeName("PSID")]
    public void* TrustLevelSid;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.SessionId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SessionId;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.AppContainerNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint AppContainerNumber;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.AuthenticationId"]/*' />
    public LUID AuthenticationId;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.GroupCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint GroupCount;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.GroupsLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint GroupsLength;

    /// <include file='TOKEN_LOGGING_INFORMATION.xml' path='doc/member[@name="TOKEN_LOGGING_INFORMATION.Groups"]/*' />
    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* Groups;
}
