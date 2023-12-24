// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH"]/*' />
public partial struct CSV_QUERY_MDS_PATH
{
    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.MdsNodeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint MdsNodeId;

    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.DsNodeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DsNodeId;

    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.PathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint PathLength;

    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.Path"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _Path_e__FixedBuffer Path;

    /// <include file='_Path_e__FixedBuffer.xml' path='doc/member[@name="_Path_e__FixedBuffer"]/*' />
    public partial struct _Path_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
