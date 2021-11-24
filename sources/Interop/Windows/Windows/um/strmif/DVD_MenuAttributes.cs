// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct DVD_MenuAttributes
{
    [NativeTypeName("BOOL [8]")]
    public _fCompatibleRegion_e__FixedBuffer fCompatibleRegion;

    public DVD_VideoAttributes VideoAttributes;

    public BOOL fAudioPresent;

    public DVD_AudioAttributes AudioAttributes;

    public BOOL fSubpicturePresent;

    public DVD_SubpictureAttributes SubpictureAttributes;

    public partial struct _fCompatibleRegion_e__FixedBuffer
    {
        public BOOL e0;
        public BOOL e1;
        public BOOL e2;
        public BOOL e3;
        public BOOL e4;
        public BOOL e5;
        public BOOL e6;
        public BOOL e7;

        public ref BOOL this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<BOOL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}
