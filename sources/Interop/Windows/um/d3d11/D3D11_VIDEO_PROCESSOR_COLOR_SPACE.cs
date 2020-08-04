// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE
    {
        public uint _bitfield;

        [NativeTypeName("UINT : 1")]
        public uint Usage
        {
            get
            {
                return _bitfield & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        [NativeTypeName("UINT : 1")]
        public uint RGB_Range
        {
            get
            {
                return (_bitfield >> 1) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
            }
        }

        [NativeTypeName("UINT : 1")]
        public uint YCbCr_Matrix
        {
            get
            {
                return (_bitfield >> 2) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
            }
        }

        [NativeTypeName("UINT : 1")]
        public uint YCbCr_xvYCC
        {
            get
            {
                return (_bitfield >> 3) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
            }
        }

        [NativeTypeName("UINT : 2")]
        public uint Nominal_Range
        {
            get
            {
                return (_bitfield >> 4) & 0x3u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3u << 4)) | ((value & 0x3u) << 4);
            }
        }

        [NativeTypeName("UINT : 26")]
        public uint Reserved
        {
            get
            {
                return (_bitfield >> 6) & 0x3FFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFu << 6)) | ((value & 0x3FFFFFFu) << 6);
            }
        }
    }
}
