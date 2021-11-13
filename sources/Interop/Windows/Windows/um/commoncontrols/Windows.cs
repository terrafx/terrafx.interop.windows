// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("comctl32", ExactSpelling = true)]
        public static extern HRESULT ImageList_CoCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IUnknown *")] IUnknown* punkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [NativeTypeName("#define ILIF_ALPHA 0x00000001")]
        public const int ILIF_ALPHA = 0x00000001;

        [NativeTypeName("#define ILIF_LOWQUALITY 0x00000002")]
        public const int ILIF_LOWQUALITY = 0x00000002;

        [NativeTypeName("#define ILDRF_IMAGELOWQUALITY 0x00000001")]
        public const int ILDRF_IMAGELOWQUALITY = 0x00000001;

        [NativeTypeName("#define ILDRF_OVERLAYLOWQUALITY 0x00000010")]
        public const int ILDRF_OVERLAYLOWQUALITY = 0x00000010;

        [NativeTypeName("#define ILR_DEFAULT 0x0000")]
        public const int ILR_DEFAULT = 0x0000;

        [NativeTypeName("#define ILR_HORIZONTAL_LEFT 0x0000")]
        public const int ILR_HORIZONTAL_LEFT = 0x0000;

        [NativeTypeName("#define ILR_HORIZONTAL_CENTER 0x0001")]
        public const int ILR_HORIZONTAL_CENTER = 0x0001;

        [NativeTypeName("#define ILR_HORIZONTAL_RIGHT 0x0002")]
        public const int ILR_HORIZONTAL_RIGHT = 0x0002;

        [NativeTypeName("#define ILR_VERTICAL_TOP 0x0000")]
        public const int ILR_VERTICAL_TOP = 0x0000;

        [NativeTypeName("#define ILR_VERTICAL_CENTER 0x0010")]
        public const int ILR_VERTICAL_CENTER = 0x0010;

        [NativeTypeName("#define ILR_VERTICAL_BOTTOM 0x0020")]
        public const int ILR_VERTICAL_BOTTOM = 0x0020;

        [NativeTypeName("#define ILR_SCALE_CLIP 0x0000")]
        public const int ILR_SCALE_CLIP = 0x0000;

        [NativeTypeName("#define ILR_SCALE_ASPECTRATIO 0x0100")]
        public const int ILR_SCALE_ASPECTRATIO = 0x0100;

        [NativeTypeName("#define ILGOS_ALWAYS 0x00000000")]
        public const int ILGOS_ALWAYS = 0x00000000;

        [NativeTypeName("#define ILGOS_FROMSTANDBY 0x00000001")]
        public const int ILGOS_FROMSTANDBY = 0x00000001;

        [NativeTypeName("#define ILFIP_ALWAYS 0x00000000")]
        public const int ILFIP_ALWAYS = 0x00000000;

        [NativeTypeName("#define ILFIP_FROMSTANDBY 0x00000001")]
        public const int ILFIP_FROMSTANDBY = 0x00000001;

        [NativeTypeName("#define ILDI_PURGE 0x00000001")]
        public const int ILDI_PURGE = 0x00000001;

        [NativeTypeName("#define ILDI_STANDBY 0x00000002")]
        public const int ILDI_STANDBY = 0x00000002;

        [NativeTypeName("#define ILDI_RESETACCESS 0x00000004")]
        public const int ILDI_RESETACCESS = 0x00000004;

        [NativeTypeName("#define ILDI_QUERYACCESS 0x00000008")]
        public const int ILDI_QUERYACCESS = 0x00000008;

        public static ref readonly Guid IID_IImageList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x59, 0xEB, 0x46,
                    0x2E, 0x58,
                    0x17, 0x40,
                    0x9F,
                    0xDF,
                    0xE8,
                    0x99,
                    0x8D,
                    0xAA,
                    0x09,
                    0x50
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IImageList2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x9D, 0x2B, 0x19,
                    0xFC, 0x50,
                    0x7B, 0x45,
                    0x90,
                    0xA0,
                    0x2B,
                    0x82,
                    0xA8,
                    0xB5,
                    0xDA,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ImageList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x6B, 0x47, 0x7C,
                    0xB1, 0x02,
                    0xF4, 0x48,
                    0x80,
                    0x48,
                    0xB2,
                    0x46,
                    0x19,
                    0xDD,
                    0xC0,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
