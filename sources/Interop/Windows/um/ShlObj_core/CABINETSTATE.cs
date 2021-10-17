// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct CABINETSTATE
    {
        [NativeTypeName("WORD")]
        public ushort cLength;

        [NativeTypeName("WORD")]
        public ushort nVersion;

        public int _bitfield;

        [NativeTypeName("BOOL : 1")]
        public int fFullPathTitle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1) | (value & 0x1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fSaveLocalView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fNotShell
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 2) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 2)) | ((value & 0x1) << 2);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fSimpleDefault
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 3) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 3)) | ((value & 0x1) << 3);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fDontShowDescBar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 4) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 4)) | ((value & 0x1) << 4);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fNewWindowMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 5) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 5)) | ((value & 0x1) << 5);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowCompColor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 6) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 6)) | ((value & 0x1) << 6);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fDontPrettyNames
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 7) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 7)) | ((value & 0x1) << 7);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fAdminsCreateCommonGroups
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 8) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 8)) | ((value & 0x1) << 8);
            }
        }

        [NativeTypeName("UINT : 7")]
        public uint fUnusedFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (uint)((_bitfield >> 9) & 0x7F);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7F << 9)) | (int)((value & 0x7Fu) << 9);
            }
        }

        [NativeTypeName("UINT")]
        public uint fMenuEnumFilter;
    }
}
