// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("4995F511-9DDB-4F12-BD3B-F04611807B79")]
[NativeTypeName("struct IAMGraphBuilderCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMGraphBuilderCallback : IAMGraphBuilderCallback.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMGraphBuilderCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMGraphBuilderCallback*, uint>)(lpVtbl[1]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMGraphBuilderCallback*, uint>)(lpVtbl[2]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SelectedFilter(IMoniker* pMon)
    {
        return ((delegate* unmanaged<IAMGraphBuilderCallback*, IMoniker*, int>)(lpVtbl[3]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), pMon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreatedFilter(IBaseFilter* pFil)
    {
        return ((delegate* unmanaged<IAMGraphBuilderCallback*, IBaseFilter*, int>)(lpVtbl[4]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), pFil);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SelectedFilter(IMoniker* pMon);

        [VtblIndex(4)]
        HRESULT CreatedFilter(IBaseFilter* pFil);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, int> SelectedFilter;

        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, int> CreatedFilter;
    }
}
