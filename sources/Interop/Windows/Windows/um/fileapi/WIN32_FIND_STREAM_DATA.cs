// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIN32_FIND_STREAM_DATA.xml' path='doc/member[@name="WIN32_FIND_STREAM_DATA"]/*' />
public partial struct WIN32_FIND_STREAM_DATA
{
    /// <include file='WIN32_FIND_STREAM_DATA.xml' path='doc/member[@name="WIN32_FIND_STREAM_DATA.StreamSize"]/*' />
    public LARGE_INTEGER StreamSize;

    /// <include file='WIN32_FIND_STREAM_DATA.xml' path='doc/member[@name="WIN32_FIND_STREAM_DATA.cStreamName"]/*' />
    [NativeTypeName("WCHAR[296]")]
    public _cStreamName_e__FixedBuffer cStreamName;

    /// <include file='_cStreamName_e__FixedBuffer.xml' path='doc/member[@name="_cStreamName_e__FixedBuffer"]/*' />
    [InlineArray(296)]
    public partial struct _cStreamName_e__FixedBuffer
    {
        public char e0;
    }
}
