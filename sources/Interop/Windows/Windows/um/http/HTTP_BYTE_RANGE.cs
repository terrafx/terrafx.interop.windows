// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_BYTE_RANGE.xml' path='doc/member[@name="HTTP_BYTE_RANGE"]/*' />
public partial struct HTTP_BYTE_RANGE
{
    /// <include file='HTTP_BYTE_RANGE.xml' path='doc/member[@name="HTTP_BYTE_RANGE.StartingOffset"]/*' />
    public ULARGE_INTEGER StartingOffset;

    /// <include file='HTTP_BYTE_RANGE.xml' path='doc/member[@name="HTTP_BYTE_RANGE.Length"]/*' />
    public ULARGE_INTEGER Length;
}
