// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_CALLBACK_INPUT.xml' path='doc/member[@name="MINIDUMP_CALLBACK_INPUT"]/*' />
public partial struct MINIDUMP_CALLBACK_INPUT
{
    /// <include file='MINIDUMP_CALLBACK_INPUT.xml' path='doc/member[@name="MINIDUMP_CALLBACK_INPUT.ProcessId"]/*' />
    [NativeTypeName("ULONG")]
    public uint ProcessId;

    /// <include file='MINIDUMP_CALLBACK_INPUT.xml' path='doc/member[@name="MINIDUMP_CALLBACK_INPUT.ProcessHandle"]/*' />
    public HANDLE ProcessHandle;

    /// <include file='MINIDUMP_CALLBACK_INPUT.xml' path='doc/member[@name="MINIDUMP_CALLBACK_INPUT.CallbackType"]/*' />
    [NativeTypeName("ULONG")]
    public uint CallbackType;

    /// <include file='MINIDUMP_CALLBACK_INPUT.xml' path='doc/member[@name="MINIDUMP_CALLBACK_INPUT.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_minidumpapiset_L1241_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Status"]/*' />
    [UnscopedRef]
    public ref HRESULT Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Status;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Thread"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_THREAD_CALLBACK Thread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Thread;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ThreadEx"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_THREAD_EX_CALLBACK ThreadEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ThreadEx;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Module"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_MODULE_CALLBACK Module
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Module;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IncludeThread"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_INCLUDE_THREAD_CALLBACK IncludeThread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.IncludeThread;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IncludeModule"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_INCLUDE_MODULE_CALLBACK IncludeModule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.IncludeModule;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Io"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_IO_CALLBACK Io
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Io;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ReadMemoryFailure"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_READ_MEMORY_FAILURE_CALLBACK ReadMemoryFailure
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ReadMemoryFailure;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SecondaryFlags"]/*' />
    [UnscopedRef]
    public ref uint SecondaryFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SecondaryFlags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VmQuery"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_VM_QUERY_CALLBACK VmQuery
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.VmQuery;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VmPreRead"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_VM_PRE_READ_CALLBACK VmPreRead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.VmPreRead;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VmPostRead"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_VM_POST_READ_CALLBACK VmPostRead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.VmPostRead;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Status"]/*' />
        [FieldOffset(0)]
        public HRESULT Status;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Thread"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_THREAD_CALLBACK Thread;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ThreadEx"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_THREAD_EX_CALLBACK ThreadEx;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Module"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_MODULE_CALLBACK Module;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IncludeThread"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_INCLUDE_THREAD_CALLBACK IncludeThread;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IncludeModule"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_INCLUDE_MODULE_CALLBACK IncludeModule;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Io"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_IO_CALLBACK Io;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ReadMemoryFailure"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_READ_MEMORY_FAILURE_CALLBACK ReadMemoryFailure;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SecondaryFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint SecondaryFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VmQuery"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_VM_QUERY_CALLBACK VmQuery;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VmPreRead"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_VM_PRE_READ_CALLBACK VmPreRead;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VmPostRead"]/*' />
        [FieldOffset(0)]
        public MINIDUMP_VM_POST_READ_CALLBACK VmPostRead;
    }
}
