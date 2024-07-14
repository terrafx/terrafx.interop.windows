// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CSV_QUERY_FILE_REVISION.xml' path='doc/member[@name="CSV_QUERY_FILE_REVISION"]/*' />
public partial struct CSV_QUERY_FILE_REVISION
{
    /// <include file='CSV_QUERY_FILE_REVISION.xml' path='doc/member[@name="CSV_QUERY_FILE_REVISION.FileId"]/*' />
    [NativeTypeName("LONGLONG")]
    public long FileId;

    /// <include file='CSV_QUERY_FILE_REVISION.xml' path='doc/member[@name="CSV_QUERY_FILE_REVISION.FileRevision"]/*' />
    [NativeTypeName("LONGLONG[3]")]
    public _FileRevision_e__FixedBuffer FileRevision;

    /// <include file='_FileRevision_e__FixedBuffer.xml' path='doc/member[@name="_FileRevision_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _FileRevision_e__FixedBuffer
    {
        public long e0;
    }
}
