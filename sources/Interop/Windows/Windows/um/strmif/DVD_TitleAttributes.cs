// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes"]/*' />
public partial struct DVD_TitleAttributes
{
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_strmif_L22382_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.VideoAttributes"]/*' />
    public DVD_VideoAttributes VideoAttributes;

    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.ulNumberOfAudioStreams"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulNumberOfAudioStreams;

    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.AudioAttributes"]/*' />
    [NativeTypeName("DVD_AudioAttributes[8]")]
    public _AudioAttributes_e__FixedBuffer AudioAttributes;

    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.MultichannelAudioAttributes"]/*' />
    [NativeTypeName("DVD_MultichannelAudioAttributes[8]")]
    public _MultichannelAudioAttributes_e__FixedBuffer MultichannelAudioAttributes;

    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.ulNumberOfSubpictureStreams"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulNumberOfSubpictureStreams;

    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.SubpictureAttributes"]/*' />
    [NativeTypeName("DVD_SubpictureAttributes[32]")]
    public _SubpictureAttributes_e__FixedBuffer SubpictureAttributes;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AppMode"]/*' />
    [UnscopedRef]
    public ref DVD_TITLE_APPMODE AppMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.AppMode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TitleLength"]/*' />
    [UnscopedRef]
    public ref DVD_HMSF_TIMECODE TitleLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TitleLength;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AppMode"]/*' />
        [FieldOffset(0)]
        public DVD_TITLE_APPMODE AppMode;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TitleLength"]/*' />
        [FieldOffset(0)]
        public DVD_HMSF_TIMECODE TitleLength;
    }

    /// <include file='_AudioAttributes_e__FixedBuffer.xml' path='doc/member[@name="_AudioAttributes_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _AudioAttributes_e__FixedBuffer
    {
        public DVD_AudioAttributes e0;
    }

    /// <include file='_MultichannelAudioAttributes_e__FixedBuffer.xml' path='doc/member[@name="_MultichannelAudioAttributes_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _MultichannelAudioAttributes_e__FixedBuffer
    {
        public DVD_MultichannelAudioAttributes e0;
    }

    /// <include file='_SubpictureAttributes_e__FixedBuffer.xml' path='doc/member[@name="_SubpictureAttributes_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _SubpictureAttributes_e__FixedBuffer
    {
        public DVD_SubpictureAttributes e0;
    }
}
