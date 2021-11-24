// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("5D1ABFD6-450A-4D92-9EFC-D6B6CBC1F4DA")]
[NativeTypeName("struct IMFMediaSourceExtensionLiveSeekableRange : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaSourceExtensionLiveSeekableRange : IMFMediaSourceExtensionLiveSeekableRange.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, uint>)(lpVtbl[1]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, uint>)(lpVtbl[2]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetLiveSeekableRange(double start, double end)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, double, double, int>)(lpVtbl[3]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this), start, end);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ClearLiveSeekableRange()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, int>)(lpVtbl[4]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetLiveSeekableRange(double start, double end);

        [VtblIndex(4)]
        HRESULT ClearLiveSeekableRange();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, uint> Release;

        [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, double, double, int> SetLiveSeekableRange;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionLiveSeekableRange*, int> ClearLiveSeekableRange;
    }
}
