// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE"]/*' />
public partial struct SI_COPYFILE
{
    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.SourceFileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint SourceFileNameLength;

    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.DestinationFileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint DestinationFileNameLength;

    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.FileNameBuffer"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _FileNameBuffer_e__FixedBuffer FileNameBuffer;

    /// <include file='_FileNameBuffer_e__FixedBuffer.xml' path='doc/member[@name="_FileNameBuffer_e__FixedBuffer"]/*' />
    public partial struct _FileNameBuffer_e__FixedBuffer
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
