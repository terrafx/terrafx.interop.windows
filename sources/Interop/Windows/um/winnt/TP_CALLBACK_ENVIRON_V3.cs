// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
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
        public IntPtr CleanupGroupCancelCallback;

        [NativeTypeName("PVOID")]
        public void* RaceDll;

        [NativeTypeName("struct _ACTIVATION_CONTEXT *")]
        public IntPtr ActivationContext;

        [NativeTypeName("PTP_SIMPLE_CALLBACK")]
        public IntPtr FinalizationCallback;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:22408:5)")]
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
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:22410:9)")]
            public _s_e__Union s;

            public partial struct _s_e__Union
            {
                internal uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint LongFunction
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

                [NativeTypeName("DWORD : 1")]
                public uint Persistent
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

                [NativeTypeName("DWORD : 30")]
                public uint Private
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x3FFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                    }
                }
            }
        }
    }
}
