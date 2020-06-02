// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000016-0000-0000-C000-000000000046")]
    public unsafe partial struct IMessageFilter
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IMessageFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint HandleInComingCall([NativeTypeName("DWORD")] uint dwCallType, [NativeTypeName("HTASK")] IntPtr htaskCaller, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo)
        {
            return lpVtbl->HandleInComingCall((IMessageFilter*)Unsafe.AsPointer(ref this), dwCallType, htaskCaller, dwTickCount, lpInterfaceInfo);
        }

        [return: NativeTypeName("DWORD")]
        public uint RetryRejectedCall([NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwRejectType)
        {
            return lpVtbl->RetryRejectedCall((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwRejectType);
        }

        [return: NativeTypeName("DWORD")]
        public uint MessagePending([NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwPendingType)
        {
            return lpVtbl->MessagePending((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwPendingType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMessageFilter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMessageFilter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMessageFilter*, uint> Release;

            [NativeTypeName("DWORD (DWORD, HTASK, DWORD, LPINTERFACEINFO) __attribute__((stdcall))")]
            public delegate* stdcall<IMessageFilter*, uint, IntPtr, uint, INTERFACEINFO*, uint> HandleInComingCall;

            [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IMessageFilter*, IntPtr, uint, uint, uint> RetryRejectedCall;

            [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IMessageFilter*, IntPtr, uint, uint, uint> MessagePending;
        }
    }
}
