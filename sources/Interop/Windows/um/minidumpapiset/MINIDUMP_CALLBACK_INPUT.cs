// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_CALLBACK_INPUT
    {
        [NativeTypeName("ULONG")]
        public uint ProcessId;

        public HANDLE ProcessHandle;

        [NativeTypeName("ULONG")]
        public uint CallbackType;

        [NativeTypeName("_MINIDUMP_CALLBACK_INPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:1140:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref HRESULT Status
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Status, 1));
            }
        }

        public ref MINIDUMP_THREAD_CALLBACK Thread
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Thread, 1));
            }
        }

        public ref MINIDUMP_THREAD_EX_CALLBACK ThreadEx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ThreadEx, 1));
            }
        }

        public ref MINIDUMP_MODULE_CALLBACK Module
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Module, 1));
            }
        }

        public ref MINIDUMP_INCLUDE_THREAD_CALLBACK IncludeThread
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.IncludeThread, 1));
            }
        }

        public ref MINIDUMP_INCLUDE_MODULE_CALLBACK IncludeModule
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.IncludeModule, 1));
            }
        }

        public ref MINIDUMP_IO_CALLBACK Io
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Io, 1));
            }
        }

        public ref MINIDUMP_READ_MEMORY_FAILURE_CALLBACK ReadMemoryFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ReadMemoryFailure, 1));
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

        public ref MINIDUMP_VM_QUERY_CALLBACK VmQuery
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.VmQuery, 1));
            }
        }

        public ref MINIDUMP_VM_PRE_READ_CALLBACK VmPreRead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.VmPreRead, 1));
            }
        }

        public ref MINIDUMP_VM_POST_READ_CALLBACK VmPostRead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.VmPostRead, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public HRESULT Status;

            [FieldOffset(0)]
            public MINIDUMP_THREAD_CALLBACK Thread;

            [FieldOffset(0)]
            public MINIDUMP_THREAD_EX_CALLBACK ThreadEx;

            [FieldOffset(0)]
            public MINIDUMP_MODULE_CALLBACK Module;

            [FieldOffset(0)]
            public MINIDUMP_INCLUDE_THREAD_CALLBACK IncludeThread;

            [FieldOffset(0)]
            public MINIDUMP_INCLUDE_MODULE_CALLBACK IncludeModule;

            [FieldOffset(0)]
            public MINIDUMP_IO_CALLBACK Io;

            [FieldOffset(0)]
            public MINIDUMP_READ_MEMORY_FAILURE_CALLBACK ReadMemoryFailure;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint SecondaryFlags;

            [FieldOffset(0)]
            public MINIDUMP_VM_QUERY_CALLBACK VmQuery;

            [FieldOffset(0)]
            public MINIDUMP_VM_PRE_READ_CALLBACK VmPreRead;

            [FieldOffset(0)]
            public MINIDUMP_VM_POST_READ_CALLBACK VmPostRead;
        }
    }
}
