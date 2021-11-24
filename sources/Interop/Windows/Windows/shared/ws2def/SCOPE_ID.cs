// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct SCOPE_ID
{
    [NativeTypeName("SCOPE_ID::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ws2def.h:623:5)")]
    public _Anonymous_e__Union Anonymous;

    public uint Zone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.Zone;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Zone = value;
        }
    }

    public uint Level
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.Level;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Level = value;
        }
    }

    public ref uint Value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Value, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("SCOPE_ID::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ws2def.h:624:9)")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint Value;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("ULONG : 28")]
            public uint Zone
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0xFFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFFFFFFu) | (value & 0xFFFFFFFu);
                }
            }

            [NativeTypeName("ULONG : 4")]
            public uint Level
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 28) & 0xFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFu << 28)) | ((value & 0xFu) << 28);
                }
            }
        }
    }
}
