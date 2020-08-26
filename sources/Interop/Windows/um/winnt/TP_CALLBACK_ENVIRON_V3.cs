// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct TP_CALLBACK_ENVIRON_V3
    {
        [NativeTypeName("TP_VERSION")]
        public uint Version;

        [NativeTypeName("PTP_POOL")]
        public IntPtr Pool;

        [NativeTypeName("PTP_CLEANUP_GROUP")]
        public IntPtr CleanupGroup;

        [NativeTypeName("PTP_CLEANUP_GROUP_CANCEL_CALLBACK")]
        public delegate* stdcall<void*, void*, void> CleanupGroupCancelCallback;

        [NativeTypeName("PVOID")]
        public void* RaceDll;

        [NativeTypeName("struct _ACTIVATION_CONTEXT *")]
        public IntPtr ActivationContext;

        [NativeTypeName("PTP_SIMPLE_CALLBACK")]
        public delegate* stdcall<IntPtr, void*, void> FinalizationCallback;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:22629:5)")]
        public _u_e__Union u;

        public TP_CALLBACK_PRIORITY CallbackPriority;

        [NativeTypeName("DWORD")]
        public uint Size;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:22631:9)")]
            public _s_e__Struct s;

            public partial struct _s_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint LongFunction
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint Persistent
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("DWORD : 30")]
                public uint Private
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 2) & 0x3FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                    }
                }
            }
        }
    }
}
