// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("FC7CFA47-DFE1-45B5-A049-8CFD82BEC271")]
[NativeTypeName("struct ISyncMgrUIOperation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrUIOperation : ISyncMgrUIOperation.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrUIOperation*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrUIOperation*, uint>)(lpVtbl[1]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrUIOperation*, uint>)(lpVtbl[2]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Run(HWND hwndOwner)
    {
        return ((delegate* unmanaged<ISyncMgrUIOperation*, HWND, int>)(lpVtbl[3]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Run(HWND hwndOwner);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrUIOperation*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrUIOperation*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrUIOperation*, uint> Release;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrUIOperation*, HWND, int> Run;
    }
}
