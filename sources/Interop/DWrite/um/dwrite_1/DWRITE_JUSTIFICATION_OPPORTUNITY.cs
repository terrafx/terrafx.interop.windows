// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
    {
        [NativeTypeName("FLOAT")]
        public float expansionMinimum;

        [NativeTypeName("FLOAT")]
        public float expansionMaximum;

        [NativeTypeName("FLOAT")]
        public float compressionMaximum;

        internal uint _bitfield;

        [NativeTypeName("UINT32 : 8")]
        public uint expansionPriority
        {
            get
            {
                return _bitfield & 0xFF;
            }

            set
            {
                _bitfield = (_bitfield & ~0xFFu) | (value & 0xFF);
            }
        }

        [NativeTypeName("UINT32 : 8")]
        public uint compressionPriority
        {
            get
            {
                return (_bitfield >> 8) & 0xFF;
            }

            set
            {
                _bitfield = (_bitfield & ~(0xFFu << 8)) | ((value & 0xFF) << 8);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint allowResidualExpansion
        {
            get
            {
                return (_bitfield >> 16) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1) << 16);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint allowResidualCompression
        {
            get
            {
                return (_bitfield >> 17) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1) << 17);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint applyToLeadingEdge
        {
            get
            {
                return (_bitfield >> 18) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1) << 18);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint applyToTrailingEdge
        {
            get
            {
                return (_bitfield >> 19) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1) << 19);
            }
        }

        [NativeTypeName("UINT32 : 12")]
        public uint reserved
        {
            get
            {
                return (_bitfield >> 20) & 0xFFF;
            }

            set
            {
                _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFF) << 20);
            }
        }
    }
}
