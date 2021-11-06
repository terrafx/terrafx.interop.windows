// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_CALLBACK_OUTPUT
    {
        [NativeTypeName("_MINIDUMP_CALLBACK_OUTPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:1157:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint ModuleWriteFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ModuleWriteFlags, 1));
            }
        }

        public ref uint ThreadWriteFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ThreadWriteFlags, 1));
            }
        }

        public ref uint SecondaryFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SecondaryFlags, 1));
            }
        }

        public ref ulong MemoryBase
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.MemoryBase, 1));
            }
        }

        public ref uint MemorySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.MemorySize, 1));
            }
        }

        public ref BOOL CheckCancel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2.CheckCancel, 1));
            }
        }

        public ref BOOL Cancel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2.Cancel, 1));
            }
        }

        public ref HANDLE Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Handle;
            }
        }

        public ref MINIDUMP_MEMORY_INFO VmRegion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous3.VmRegion, 1));
            }
        }

        public ref BOOL Continue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous3.Continue, 1));
            }
        }

        public ref HRESULT VmQueryStatus
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous4.VmQueryStatus, 1));
            }
        }

        public ref MINIDUMP_MEMORY_INFO VmQueryResult
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous4.VmQueryResult, 1));
            }
        }

        public ref HRESULT VmReadStatus
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous5.VmReadStatus, 1));
            }
        }

        public ref uint VmReadBytesCompleted
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous5.VmReadBytesCompleted, 1));
            }
        }

        public ref HRESULT Status
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Status, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit, Pack = 4)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ModuleWriteFlags;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ThreadWriteFlags;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint SecondaryFlags;

            [FieldOffset(0)]
            [NativeTypeName("_MINIDUMP_CALLBACK_OUTPUT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:1161:9)")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("_MINIDUMP_CALLBACK_OUTPUT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:1165:9)")]
            public _Anonymous2_e__Struct Anonymous2;

            [FieldOffset(0)]
            public HANDLE Handle;

            [FieldOffset(0)]
            [NativeTypeName("_MINIDUMP_CALLBACK_OUTPUT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:1170:9)")]
            public _Anonymous3_e__Struct Anonymous3;

            [FieldOffset(0)]
            [NativeTypeName("_MINIDUMP_CALLBACK_OUTPUT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:1174:9)")]
            public _Anonymous4_e__Struct Anonymous4;

            [FieldOffset(0)]
            [NativeTypeName("_MINIDUMP_CALLBACK_OUTPUT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:1178:9)")]
            public _Anonymous5_e__Struct Anonymous5;

            [FieldOffset(0)]
            public HRESULT Status;

            [StructLayout(LayoutKind.Sequential, Pack = 4)]
            public partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("ULONG64")]
                public ulong MemoryBase;

                [NativeTypeName("ULONG")]
                public uint MemorySize;
            }

            public partial struct _Anonymous2_e__Struct
            {
                public BOOL CheckCancel;

                public BOOL Cancel;
            }

            public partial struct _Anonymous3_e__Struct
            {
                public MINIDUMP_MEMORY_INFO VmRegion;

                public BOOL Continue;
            }

            public partial struct _Anonymous4_e__Struct
            {
                public HRESULT VmQueryStatus;

                public MINIDUMP_MEMORY_INFO VmQueryResult;
            }

            public partial struct _Anonymous5_e__Struct
            {
                public HRESULT VmReadStatus;

                [NativeTypeName("ULONG")]
                public uint VmReadBytesCompleted;
            }
        }
    }
}
