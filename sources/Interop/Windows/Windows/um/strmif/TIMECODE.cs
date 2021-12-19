// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TIMECODE.xml' path='doc/member[@name="TIMECODE"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct TIMECODE
{
    /// <include file='TIMECODE.xml' path='doc/member[@name="TIMECODE.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("_timecode::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/strmif.h:14218:4)")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='TIMECODE.xml' path='doc/member[@name="TIMECODE.qw"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("DWORDLONG")]
    public ulong qw;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameRate"]/*' />
    public ref ushort wFrameRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.wFrameRate, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameFract"]/*' />
    public ref ushort wFrameFract
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.wFrameFract, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.dwFrames"]/*' />
    public ref uint dwFrames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwFrames, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameRate"]/*' />
        [NativeTypeName("WORD")]
        public ushort wFrameRate;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameFract"]/*' />
        [NativeTypeName("WORD")]
        public ushort wFrameFract;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.dwFrames"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFrames;
    }
}
