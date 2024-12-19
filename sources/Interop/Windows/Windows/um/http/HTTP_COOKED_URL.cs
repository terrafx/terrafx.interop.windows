// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL"]/*' />
public unsafe partial struct HTTP_COOKED_URL
{
    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.FullUrlLength"]/*' />
    public ushort FullUrlLength;

    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.HostLength"]/*' />
    public ushort HostLength;

    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.AbsPathLength"]/*' />
    public ushort AbsPathLength;

    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.QueryStringLength"]/*' />
    public ushort QueryStringLength;

    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.pFullUrl"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pFullUrl;

    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.pHost"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pHost;

    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.pAbsPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pAbsPath;

    /// <include file='HTTP_COOKED_URL.xml' path='doc/member[@name="HTTP_COOKED_URL.pQueryString"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pQueryString;
}
