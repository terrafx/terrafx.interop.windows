// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct TIMECODE
    {
        [FieldOffset(0)]
        [NativeTypeName("_timecode::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/strmif.h:13483:4)")]
        public _Anonymous_e__Struct Anonymous;

        public ref ushort wFrameRate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.wFrameRate, 1));
            }
        }

        public ref ushort wFrameFract
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.wFrameFract, 1));
            }
        }

        public ref uint dwFrames
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwFrames, 1));
            }
        }

        [FieldOffset(0)]
        [NativeTypeName("DWORDLONG")]
        public ulong qw;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort wFrameRate;

            [NativeTypeName("WORD")]
            public ushort wFrameFract;

            [NativeTypeName("DWORD")]
            public uint dwFrames;
        }
    }
}
