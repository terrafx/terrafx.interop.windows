// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA"]/*' />
public partial struct AUDIO_VOLUME_NOTIFICATION_DATA
{
    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.guidEventContext"]/*' />
    public Guid guidEventContext;

    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.bMuted"]/*' />
    public BOOL bMuted;

    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.fMasterVolume"]/*' />
    public float fMasterVolume;

    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.nChannels"]/*' />
    public uint nChannels;

    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.afChannelVolumes"]/*' />
    [NativeTypeName("float[1]")]
    public _afChannelVolumes_e__FixedBuffer afChannelVolumes;

    /// <include file='_afChannelVolumes_e__FixedBuffer.xml' path='doc/member[@name="_afChannelVolumes_e__FixedBuffer"]/*' />
    public partial struct _afChannelVolumes_e__FixedBuffer
    {
        public float e0;

        [UnscopedRef]
        public ref float this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<float> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
