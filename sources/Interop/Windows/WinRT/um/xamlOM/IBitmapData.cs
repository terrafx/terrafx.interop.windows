// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[SupportedOSPlatform("windows10.0.14393.0")]
[Guid("D1A34EF2-CAD8-4635-A3D2-FCDA8D3F3CAF")]
[NativeTypeName("struct IBitmapData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBitmapData : IBitmapData.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBitmapData*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBitmapData*, uint>)(lpVtbl[1]))((IBitmapData*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBitmapData*, uint>)(lpVtbl[2]))((IBitmapData*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CopyBytesTo([NativeTypeName("unsigned int")] uint sourceOffsetInBytes, [NativeTypeName("unsigned int")] uint maxBytesToCopy, byte* pvBytes, [NativeTypeName("unsigned int *")] uint* numberOfBytesCopied)
    {
        return ((delegate* unmanaged<IBitmapData*, uint, uint, byte*, uint*, int>)(lpVtbl[3]))((IBitmapData*)Unsafe.AsPointer(ref this), sourceOffsetInBytes, maxBytesToCopy, pvBytes, numberOfBytesCopied);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStride([NativeTypeName("unsigned int *")] uint* pStride)
    {
        return ((delegate* unmanaged<IBitmapData*, uint*, int>)(lpVtbl[4]))((IBitmapData*)Unsafe.AsPointer(ref this), pStride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBitmapDescription(BitmapDescription* pBitmapDescription)
    {
        return ((delegate* unmanaged<IBitmapData*, BitmapDescription*, int>)(lpVtbl[5]))((IBitmapData*)Unsafe.AsPointer(ref this), pBitmapDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceBitmapDescription(BitmapDescription* pBitmapDescription)
    {
        return ((delegate* unmanaged<IBitmapData*, BitmapDescription*, int>)(lpVtbl[6]))((IBitmapData*)Unsafe.AsPointer(ref this), pBitmapDescription);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CopyBytesTo([NativeTypeName("unsigned int")] uint sourceOffsetInBytes, [NativeTypeName("unsigned int")] uint maxBytesToCopy, byte* pvBytes, [NativeTypeName("unsigned int *")] uint* numberOfBytesCopied);

        [VtblIndex(4)]
        HRESULT GetStride([NativeTypeName("unsigned int *")] uint* pStride);

        [VtblIndex(5)]
        HRESULT GetBitmapDescription(BitmapDescription* pBitmapDescription);

        [VtblIndex(6)]
        HRESULT GetSourceBitmapDescription(BitmapDescription* pBitmapDescription);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBitmapData*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IBitmapData*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IBitmapData*, uint> Release;

        [NativeTypeName("HRESULT (unsigned int, unsigned int, byte *, unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBitmapData*, uint, uint, byte*, uint*, int> CopyBytesTo;

        [NativeTypeName("HRESULT (unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBitmapData*, uint*, int> GetStride;

        [NativeTypeName("HRESULT (BitmapDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBitmapData*, BitmapDescription*, int> GetBitmapDescription;

        [NativeTypeName("HRESULT (BitmapDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBitmapData*, BitmapDescription*, int> GetSourceBitmapDescription;
    }
}
