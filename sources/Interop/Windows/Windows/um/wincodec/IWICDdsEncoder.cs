// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
[Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
[NativeTypeName("struct IWICDdsEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICDdsEncoder : IWICDdsEncoder.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICDdsEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICDdsEncoder*, uint>)(lpVtbl[1]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDdsEncoder*, uint>)(lpVtbl[2]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetParameters(WICDdsParameters* pParameters)
    {
        return ((delegate* unmanaged<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[3]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetParameters(WICDdsParameters* pParameters)
    {
        return ((delegate* unmanaged<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[4]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
    {
        return ((delegate* unmanaged<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)(lpVtbl[5]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetParameters(WICDdsParameters* pParameters);

        [VtblIndex(4)]
        HRESULT GetParameters(WICDdsParameters* pParameters);

        [VtblIndex(5)]
        HRESULT CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDdsEncoder*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDdsEncoder*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDdsEncoder*, uint> Release;

        [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDdsEncoder*, WICDdsParameters*, int> SetParameters;

        [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDdsEncoder*, WICDdsParameters*, int> GetParameters;

        [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, UINT *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int> CreateNewFrame;
    }
}
