// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1"]/*' />
public unsafe partial struct HTTP_RESPONSE_V1
{
    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.Version"]/*' />
    public HTTP_VERSION Version;

    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.StatusCode"]/*' />
    public ushort StatusCode;

    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.ReasonLength"]/*' />
    public ushort ReasonLength;

    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.pReason"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pReason;

    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.Headers"]/*' />
    public HTTP_RESPONSE_HEADERS Headers;

    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.EntityChunkCount"]/*' />
    public ushort EntityChunkCount;

    /// <include file='HTTP_RESPONSE_V1.xml' path='doc/member[@name="HTTP_RESPONSE_V1.pEntityChunks"]/*' />
    [NativeTypeName("PHTTP_DATA_CHUNK")]
    public HTTP_DATA_CHUNK* pEntityChunks;
}
