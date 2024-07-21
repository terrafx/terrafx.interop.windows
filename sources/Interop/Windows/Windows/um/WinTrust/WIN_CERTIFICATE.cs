// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE"]/*' />
public partial struct WIN_CERTIFICATE
{
    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.dwLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLength;

    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.wRevision"]/*' />
    [NativeTypeName("WORD")]
    public ushort wRevision;

    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.wCertificateType"]/*' />
    [NativeTypeName("WORD")]
    public ushort wCertificateType;

    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.bCertificate"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _bCertificate_e__FixedBuffer bCertificate;

    /// <include file='_bCertificate_e__FixedBuffer.xml' path='doc/member[@name="_bCertificate_e__FixedBuffer"]/*' />
    public partial struct _bCertificate_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
