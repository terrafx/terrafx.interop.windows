// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct VIDEOINFOHEADER2
    {
        public RECT rcSource;

        public RECT rcTarget;

        [NativeTypeName("DWORD")]
        public uint dwBitRate;

        [NativeTypeName("DWORD")]
        public uint dwBitErrorRate;

        [NativeTypeName("REFERENCE_TIME")]
        public long AvgTimePerFrame;

        [NativeTypeName("DWORD")]
        public uint dwInterlaceFlags;

        [NativeTypeName("DWORD")]
        public uint dwCopyProtectFlags;

        [NativeTypeName("DWORD")]
        public uint dwPictAspectRatioX;

        [NativeTypeName("DWORD")]
        public uint dwPictAspectRatioY;

        [NativeTypeName("tagVIDEOINFOHEADER2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dvdmedia.h:317:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint dwControlFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwControlFlags, 1));
            }
        }

        public ref uint dwReserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwReserved1, 1));
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwReserved2;

        public BITMAPINFOHEADER bmiHeader;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwControlFlags;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwReserved1;
        }
    }
}
