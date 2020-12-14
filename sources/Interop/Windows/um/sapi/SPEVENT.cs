// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public partial struct SPEVENT
    {
        public int _bitfield;

        [NativeTypeName("SPEVENTENUM : 16")]
        public SPEVENTENUM eEventId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (SPEVENTENUM)(_bitfield & 0xFFFF);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFFF) | ((int)(value) & 0xFFFF);
            }
        }

        [NativeTypeName("SPEVENTLPARAMTYPE : 16")]
        public SPEVENTLPARAMTYPE elParamType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (SPEVENTLPARAMTYPE)((_bitfield >> 16) & 0xFFFF);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFF << 16)) | (((int)(value) & 0xFFFF) << 16);
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
