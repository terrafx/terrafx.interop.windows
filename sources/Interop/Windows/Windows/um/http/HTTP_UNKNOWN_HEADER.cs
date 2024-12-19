// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_UNKNOWN_HEADER.xml' path='doc/member[@name="HTTP_UNKNOWN_HEADER"]/*' />
public unsafe partial struct HTTP_UNKNOWN_HEADER
{
    /// <include file='HTTP_UNKNOWN_HEADER.xml' path='doc/member[@name="HTTP_UNKNOWN_HEADER.NameLength"]/*' />
    public ushort NameLength;

    /// <include file='HTTP_UNKNOWN_HEADER.xml' path='doc/member[@name="HTTP_UNKNOWN_HEADER.RawValueLength"]/*' />
    public ushort RawValueLength;

    /// <include file='HTTP_UNKNOWN_HEADER.xml' path='doc/member[@name="HTTP_UNKNOWN_HEADER.pName"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pName;

    /// <include file='HTTP_UNKNOWN_HEADER.xml' path='doc/member[@name="HTTP_UNKNOWN_HEADER.pRawValue"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pRawValue;
}
