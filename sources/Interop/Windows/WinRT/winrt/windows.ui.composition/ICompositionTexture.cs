// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionTexture.xml' path='doc/member[@name="ICompositionTexture"]/*' />
[Guid("347D03A0-1C0A-4C0B-B232-8570B2B1A4EA")]
[NativeTypeName("struct ICompositionTexture : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionTexture : ICompositionTexture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionTexture));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionTexture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, uint>)(lpVtbl[1]))((ICompositionTexture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, uint>)(lpVtbl[2]))((ICompositionTexture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionTexture*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, HSTRING*, int>)(lpVtbl[4]))((ICompositionTexture*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionTexture*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionTexture.xml' path='doc/member[@name="ICompositionTexture.get_SourceRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceRect([NativeTypeName("ABI::Windows::Graphics::RectInt32 *")] RectInt32* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, RectInt32*, int>)(lpVtbl[6]))((ICompositionTexture*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionTexture.xml' path='doc/member[@name="ICompositionTexture.put_SourceRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SourceRect([NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, RectInt32, int>)(lpVtbl[7]))((ICompositionTexture*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionTexture.xml' path='doc/member[@name="ICompositionTexture.get_AlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")] DirectXAlphaMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, DirectXAlphaMode*, int>)(lpVtbl[8]))((ICompositionTexture*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionTexture.xml' path='doc/member[@name="ICompositionTexture.put_AlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, DirectXAlphaMode, int>)(lpVtbl[9]))((ICompositionTexture*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionTexture.xml' path='doc/member[@name="ICompositionTexture.get_ColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ColorSpace([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace *")] DirectXColorSpace* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, DirectXColorSpace*, int>)(lpVtbl[10]))((ICompositionTexture*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionTexture.xml' path='doc/member[@name="ICompositionTexture.put_ColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ColorSpace([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace")] DirectXColorSpace value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTexture*, DirectXColorSpace, int>)(lpVtbl[11]))((ICompositionTexture*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceRect([NativeTypeName("ABI::Windows::Graphics::RectInt32 *")] RectInt32* value);

        [VtblIndex(7)]
        HRESULT put_SourceRect([NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 value);

        [VtblIndex(8)]
        HRESULT get_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")] DirectXAlphaMode* value);

        [VtblIndex(9)]
        HRESULT put_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode value);

        [VtblIndex(10)]
        HRESULT get_ColorSpace([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace *")] DirectXColorSpace* value);

        [VtblIndex(11)]
        HRESULT put_ColorSpace([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace")] DirectXColorSpace value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::RectInt32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RectInt32*, int> get_SourceRect;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RectInt32, int> put_SourceRect;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXAlphaMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXAlphaMode*, int> get_AlphaMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXAlphaMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXAlphaMode, int> put_AlphaMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXColorSpace *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXColorSpace*, int> get_ColorSpace;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXColorSpace) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXColorSpace, int> put_ColorSpace;
    }
}
