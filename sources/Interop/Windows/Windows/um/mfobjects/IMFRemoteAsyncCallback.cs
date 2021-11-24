// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("A27003D0-2354-4F2A-8D6A-AB7CFF15437E")]
[NativeTypeName("struct IMFRemoteAsyncCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRemoteAsyncCallback : IMFRemoteAsyncCallback.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRemoteAsyncCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFRemoteAsyncCallback*, uint>)(lpVtbl[1]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRemoteAsyncCallback*, uint>)(lpVtbl[2]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(HRESULT hr, IUnknown* pRemoteResult)
    {
        return ((delegate* unmanaged<IMFRemoteAsyncCallback*, HRESULT, IUnknown*, int>)(lpVtbl[3]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this), hr, pRemoteResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(HRESULT hr, IUnknown* pRemoteResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFRemoteAsyncCallback*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFRemoteAsyncCallback*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFRemoteAsyncCallback*, uint> Release;

        [NativeTypeName("HRESULT (HRESULT, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFRemoteAsyncCallback*, HRESULT, IUnknown*, int> Invoke;
    }
}
