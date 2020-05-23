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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IMessageFilter* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IMessageFilter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IMessageFilter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("DWORD")]
        public delegate uint _HandleInComingCall(IMessageFilter* pThis, [NativeTypeName("DWORD")] uint dwCallType, [NativeTypeName("HTASK")] IntPtr htaskCaller, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("DWORD")]
        public delegate uint _RetryRejectedCall(IMessageFilter* pThis, [NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwRejectType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("DWORD")]
        public delegate uint _MessagePending(IMessageFilter* pThis, [NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwPendingType);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IMessageFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint HandleInComingCall([NativeTypeName("DWORD")] uint dwCallType, [NativeTypeName("HTASK")] IntPtr htaskCaller, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_HandleInComingCall>(lpVtbl->HandleInComingCall)((IMessageFilter*)Unsafe.AsPointer(ref this), dwCallType, htaskCaller, dwTickCount, lpInterfaceInfo);
        }

        [return: NativeTypeName("DWORD")]
        public uint RetryRejectedCall([NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwRejectType)
        {
            return Marshal.GetDelegateForFunctionPointer<_RetryRejectedCall>(lpVtbl->RetryRejectedCall)((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwRejectType);
        }

        [return: NativeTypeName("DWORD")]
        public uint MessagePending([NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwPendingType)
        {
            return Marshal.GetDelegateForFunctionPointer<_MessagePending>(lpVtbl->MessagePending)((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwPendingType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("DWORD (DWORD, HTASK, DWORD, LPINTERFACEINFO) __attribute__((stdcall))")]
            public IntPtr HandleInComingCall;

            [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr RetryRejectedCall;

            [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr MessagePending;
        }
    }
}
