// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000016-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMessageFilter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMessageFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMessageFilter*, Guid*, void**, int>)(lpVtbl[0]))((IMessageFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMessageFilter*, uint>)(lpVtbl[1]))((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMessageFilter*, uint>)(lpVtbl[2]))((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint HandleInComingCall([NativeTypeName("DWORD")] uint dwCallType, [NativeTypeName("HTASK")] IntPtr htaskCaller, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo)
        {
            return ((delegate* unmanaged<IMessageFilter*, uint, IntPtr, uint, INTERFACEINFO*, uint>)(lpVtbl[3]))((IMessageFilter*)Unsafe.AsPointer(ref this), dwCallType, htaskCaller, dwTickCount, lpInterfaceInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        public uint RetryRejectedCall([NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwRejectType)
        {
            return ((delegate* unmanaged<IMessageFilter*, IntPtr, uint, uint, uint>)(lpVtbl[4]))((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwRejectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        public uint MessagePending([NativeTypeName("HTASK")] IntPtr htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwPendingType)
        {
            return ((delegate* unmanaged<IMessageFilter*, IntPtr, uint, uint, uint>)(lpVtbl[5]))((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwPendingType);
        }
    }
}
