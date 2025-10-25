// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICD3DTextureSource.xml' path='doc/member[@name="IWICD3DTextureSource"]/*' />
[Guid("CAF65CC4-8EBE-4718-A21F-8DBF40BB7E25")]
[NativeTypeName("struct IWICD3DTextureSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICD3DTextureSource : IWICD3DTextureSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWICD3DTextureSource);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICD3DTextureSource*, Guid*, void**, int>)(lpVtbl[0]))((IWICD3DTextureSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICD3DTextureSource*, uint>)(lpVtbl[1]))((IWICD3DTextureSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICD3DTextureSource*, uint>)(lpVtbl[2]))((IWICD3DTextureSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICD3DTextureSource.xml' path='doc/member[@name="IWICD3DTextureSource.GetTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTexture(IUnknown* pD3DDevice, IPropertyBag2* pID3DTextureOptions, [NativeTypeName("const IID &")] Guid* riid, void** ppTexture)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICD3DTextureSource*, IUnknown*, IPropertyBag2*, Guid*, void**, int>)(lpVtbl[3]))((IWICD3DTextureSource*)Unsafe.AsPointer(ref this), pD3DDevice, pID3DTextureOptions, riid, ppTexture);
    }

    /// <include file='IWICD3DTextureSource.xml' path='doc/member[@name="IWICD3DTextureSource.GetTransformedTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTransformedTexture([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, IUnknown* pD3DDevice, IPropertyBag2* pID3DTextureOptions, [NativeTypeName("const IID &")] Guid* riid, void** ppTexture)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICD3DTextureSource*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, IUnknown*, IPropertyBag2*, Guid*, void**, int>)(lpVtbl[4]))((IWICD3DTextureSource*)Unsafe.AsPointer(ref this), prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, pD3DDevice, pID3DTextureOptions, riid, ppTexture);
    }

    /// <include file='IWICD3DTextureSource.xml' path='doc/member[@name="IWICD3DTextureSource.DoesSupportD3DDeviceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DoesSupportD3DDeviceType([NativeTypeName("const IID &")] Guid* riid, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICD3DTextureSource*, Guid*, BOOL*, int>)(lpVtbl[5]))((IWICD3DTextureSource*)Unsafe.AsPointer(ref this), riid, pfIsSupported);
    }

    /// <include file='IWICD3DTextureSource.xml' path='doc/member[@name="IWICD3DTextureSource.GetD3DTextureOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetD3DTextureOptions(IPropertyBag2** ppID3DTextureOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICD3DTextureSource*, IPropertyBag2**, int>)(lpVtbl[6]))((IWICD3DTextureSource*)Unsafe.AsPointer(ref this), ppID3DTextureOptions);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTexture(IUnknown* pD3DDevice, IPropertyBag2* pID3DTextureOptions, [NativeTypeName("const IID &")] Guid* riid, void** ppTexture);

        [VtblIndex(4)]
        HRESULT GetTransformedTexture([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, IUnknown* pD3DDevice, IPropertyBag2* pID3DTextureOptions, [NativeTypeName("const IID &")] Guid* riid, void** ppTexture);

        [VtblIndex(5)]
        HRESULT DoesSupportD3DDeviceType([NativeTypeName("const IID &")] Guid* riid, BOOL* pfIsSupported);

        [VtblIndex(6)]
        HRESULT GetD3DTextureOptions(IPropertyBag2** ppID3DTextureOptions);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown *, IPropertyBag2 *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, IPropertyBag2*, Guid*, void**, int> GetTexture;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, const WICPixelFormatGUID *, WICBitmapTransformOptions, IUnknown *, IPropertyBag2 *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, IUnknown*, IPropertyBag2*, Guid*, void**, int> GetTransformedTexture;

        [NativeTypeName("HRESULT (const IID &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, BOOL*, int> DoesSupportD3DDeviceType;

        [NativeTypeName("HRESULT (IPropertyBag2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertyBag2**, int> GetD3DTextureOptions;
    }
}
