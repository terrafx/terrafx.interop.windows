// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_MULTIPLE_KNOWN_HEADERS.xml' path='doc/member[@name="HTTP_MULTIPLE_KNOWN_HEADERS"]/*' />
public unsafe partial struct HTTP_MULTIPLE_KNOWN_HEADERS
{
    /// <include file='HTTP_MULTIPLE_KNOWN_HEADERS.xml' path='doc/member[@name="HTTP_MULTIPLE_KNOWN_HEADERS.HeaderId"]/*' />
    public HTTP_HEADER_ID HeaderId;

    /// <include file='HTTP_MULTIPLE_KNOWN_HEADERS.xml' path='doc/member[@name="HTTP_MULTIPLE_KNOWN_HEADERS.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='HTTP_MULTIPLE_KNOWN_HEADERS.xml' path='doc/member[@name="HTTP_MULTIPLE_KNOWN_HEADERS.KnownHeaderCount"]/*' />
    public ushort KnownHeaderCount;

    /// <include file='HTTP_MULTIPLE_KNOWN_HEADERS.xml' path='doc/member[@name="HTTP_MULTIPLE_KNOWN_HEADERS.KnownHeaders"]/*' />
    [NativeTypeName("PHTTP_KNOWN_HEADER")]
    public HTTP_KNOWN_HEADER* KnownHeaders;
}
