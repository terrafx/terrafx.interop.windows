// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SPEVENT
    {
        internal int _bitfield;

        [NativeTypeName("SPEVENTENUM : 16")]
        public SPEVENTENUM eEventId
        {
            get
            {
                return (SPEVENTENUM)(_bitfield & 0xFFFF);
            }

            set
            {
                _bitfield = (_bitfield & ~0xFFFF) | ((int)value & 0xFFFF);
            }
        }

        [NativeTypeName("SPEVENTLPARAMTYPE : 16")]
        public SPEVENTLPARAMTYPE elParamType
        {
            get
            {
                return (SPEVENTLPARAMTYPE)((_bitfield >> 16) & 0xFFFF);
            }

            set
            {
                _bitfield = (_bitfield & ~(0xFFFF << 16)) | (((int)value & 0xFFFF) << 16);
            }
        }

        [NativeTypeName("ULONG")]
        public uint ulStreamNum;

        [NativeTypeName("ULONGLONG")]
        public ulong ullAudioStreamOffset;

        [NativeTypeName("WPARAM")]
        public nuint wParam;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
