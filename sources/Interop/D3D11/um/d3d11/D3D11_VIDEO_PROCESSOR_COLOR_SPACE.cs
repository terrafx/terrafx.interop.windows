// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE
    {
        internal uint _bitfield;

        [NativeTypeName("UINT")]
        public uint Usage
        {
            get
            {
                return _bitfield & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1);
            }
        }

        [NativeTypeName("UINT")]
        public uint RGB_Range
        {
            get
            {
                return (_bitfield >> 1) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1) << 1);
            }
        }

        [NativeTypeName("UINT")]
        public uint YCbCr_Matrix
        {
            get
            {
                return (_bitfield >> 2) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1) << 2);
            }
        }

        [NativeTypeName("UINT")]
        public uint YCbCr_xvYCC
        {
            get
            {
                return (_bitfield >> 3) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1) << 3);
            }
        }

        [NativeTypeName("UINT")]
        public uint Nominal_Range
        {
            get
            {
                return (_bitfield >> 4) & 0x3;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3u << 4)) | ((value & 0x3) << 4);
            }
        }

        [NativeTypeName("UINT")]
        public uint Reserved
        {
            get
            {
                return (_bitfield >> 6) & 0x3FFFFFF;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFu << 6)) | ((value & 0x3FFFFFF) << 6);
            }
        }
    }
}
