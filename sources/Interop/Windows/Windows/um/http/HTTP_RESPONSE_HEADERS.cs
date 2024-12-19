// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_RESPONSE_HEADERS.xml' path='doc/member[@name="HTTP_RESPONSE_HEADERS"]/*' />
public unsafe partial struct HTTP_RESPONSE_HEADERS
{
    /// <include file='HTTP_RESPONSE_HEADERS.xml' path='doc/member[@name="HTTP_RESPONSE_HEADERS.UnknownHeaderCount"]/*' />
    public ushort UnknownHeaderCount;

    /// <include file='HTTP_RESPONSE_HEADERS.xml' path='doc/member[@name="HTTP_RESPONSE_HEADERS.pUnknownHeaders"]/*' />
    [NativeTypeName("PHTTP_UNKNOWN_HEADER")]
    public HTTP_UNKNOWN_HEADER* pUnknownHeaders;

    /// <include file='HTTP_RESPONSE_HEADERS.xml' path='doc/member[@name="HTTP_RESPONSE_HEADERS.TrailerCount"]/*' />
    public ushort TrailerCount;

    /// <include file='HTTP_RESPONSE_HEADERS.xml' path='doc/member[@name="HTTP_RESPONSE_HEADERS.pTrailers"]/*' />
    [NativeTypeName("PHTTP_UNKNOWN_HEADER")]
    public HTTP_UNKNOWN_HEADER* pTrailers;

    /// <include file='HTTP_RESPONSE_HEADERS.xml' path='doc/member[@name="HTTP_RESPONSE_HEADERS.KnownHeaders"]/*' />
    [NativeTypeName("HTTP_KNOWN_HEADER[30]")]
    public _KnownHeaders_e__FixedBuffer KnownHeaders;

    /// <include file='_KnownHeaders_e__FixedBuffer.xml' path='doc/member[@name="_KnownHeaders_e__FixedBuffer"]/*' />
    [InlineArray(30)]
    public partial struct _KnownHeaders_e__FixedBuffer
    {
        public HTTP_KNOWN_HEADER e0;
    }
}
