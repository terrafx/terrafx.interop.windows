// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_CLUSTER_METRICS
    {
        [NativeTypeName("FLOAT")]
        public float width;

        [NativeTypeName("UINT16")]
        public ushort length;

        internal ushort _bitfield;

        [NativeTypeName("UINT16 : 1")]
        public ushort canWrapLineAfter
        {
            get
            {
                return (ushort)((uint)_bitfield & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~0x1u) | ((uint)value & 0x1));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isWhitespace
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 1) & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | (((uint)value & 0x1) << 1));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isNewline
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 2) & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 2)) | (((uint)value & 0x1) << 2));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isSoftHyphen
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 3) & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 3)) | (((uint)value & 0x1) << 3));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isRightToLeft
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 4) & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 4)) | (((uint)value & 0x1) << 4));
            }
        }

        [NativeTypeName("UINT16 : 11")]
        public ushort padding
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 5) & 0x7FF);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x7FFu << 5)) | (((uint)value & 0x7FF) << 5));
            }
        }
    }
}
