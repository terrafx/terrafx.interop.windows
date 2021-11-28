// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("2E5EA3E0-E924-11D2-B6DA-00A0C995E8DF")]
[NativeTypeName("struct IDecimateVideoImage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDecimateVideoImage : IDecimateVideoImage.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDecimateVideoImage*, Guid*, void**, int>)(lpVtbl[0]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDecimateVideoImage*, uint>)(lpVtbl[1]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDecimateVideoImage*, uint>)(lpVtbl[2]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDecimationImageSize([NativeTypeName("long")] int lWidth, [NativeTypeName("long")] int lHeight)
    {
        return ((delegate* unmanaged<IDecimateVideoImage*, int, int, int>)(lpVtbl[3]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this), lWidth, lHeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ResetDecimationImageSize()
    {
        return ((delegate* unmanaged<IDecimateVideoImage*, int>)(lpVtbl[4]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDecimationImageSize([NativeTypeName("long")] int lWidth, [NativeTypeName("long")] int lHeight);

        [VtblIndex(4)]
        HRESULT ResetDecimationImageSize();
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

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetDecimationImageSize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetDecimationImageSize;
    }
}
