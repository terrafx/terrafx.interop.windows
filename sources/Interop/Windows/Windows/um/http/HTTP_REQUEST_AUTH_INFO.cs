// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO"]/*' />
public unsafe partial struct HTTP_REQUEST_AUTH_INFO
{
    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.AuthStatus"]/*' />
    public HTTP_AUTH_STATUS AuthStatus;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.SecStatus"]/*' />
    [NativeTypeName("SECURITY_STATUS")]
    public int SecStatus;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.AuthType"]/*' />
    public HTTP_REQUEST_AUTH_TYPE AuthType;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.AccessToken"]/*' />
    public HANDLE AccessToken;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.ContextAttributes"]/*' />
    [NativeTypeName("ULONG")]
    public uint ContextAttributes;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.PackedContextLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint PackedContextLength;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.PackedContextType"]/*' />
    [NativeTypeName("ULONG")]
    public uint PackedContextType;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.PackedContext"]/*' />
    [NativeTypeName("PVOID")]
    public void* PackedContext;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.MutualAuthDataLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint MutualAuthDataLength;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.pMutualAuthData"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* pMutualAuthData;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.PackageNameLength"]/*' />
    public ushort PackageNameLength;

    /// <include file='HTTP_REQUEST_AUTH_INFO.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_INFO.pPackageName"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pPackageName;
}
