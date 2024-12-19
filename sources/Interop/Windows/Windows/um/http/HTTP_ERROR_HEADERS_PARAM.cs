// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_ERROR_HEADERS_PARAM.xml' path='doc/member[@name="HTTP_ERROR_HEADERS_PARAM"]/*' />
public unsafe partial struct HTTP_ERROR_HEADERS_PARAM
{
    /// <include file='HTTP_ERROR_HEADERS_PARAM.xml' path='doc/member[@name="HTTP_ERROR_HEADERS_PARAM.StatusCode"]/*' />
    public ushort StatusCode;

    /// <include file='HTTP_ERROR_HEADERS_PARAM.xml' path='doc/member[@name="HTTP_ERROR_HEADERS_PARAM.HeaderCount"]/*' />
    public ushort HeaderCount;

    /// <include file='HTTP_ERROR_HEADERS_PARAM.xml' path='doc/member[@name="HTTP_ERROR_HEADERS_PARAM.Headers"]/*' />
    [NativeTypeName("PHTTP_UNKNOWN_HEADER")]
    public HTTP_UNKNOWN_HEADER* Headers;
}
