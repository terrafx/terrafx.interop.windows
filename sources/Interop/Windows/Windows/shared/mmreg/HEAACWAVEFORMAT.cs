// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='HEAACWAVEFORMAT.xml' path='doc/member[@name="HEAACWAVEFORMAT"]/*' />
public partial struct HEAACWAVEFORMAT
{
    /// <include file='HEAACWAVEFORMAT.xml' path='doc/member[@name="HEAACWAVEFORMAT.wfInfo"]/*' />
    public HEAACWAVEINFO wfInfo;

    /// <include file='HEAACWAVEFORMAT.xml' path='doc/member[@name="HEAACWAVEFORMAT.pbAudioSpecificConfig"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _pbAudioSpecificConfig_e__FixedBuffer pbAudioSpecificConfig;

    /// <include file='_pbAudioSpecificConfig_e__FixedBuffer.xml' path='doc/member[@name="_pbAudioSpecificConfig_e__FixedBuffer"]/*' />
    public partial struct _pbAudioSpecificConfig_e__FixedBuffer
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
