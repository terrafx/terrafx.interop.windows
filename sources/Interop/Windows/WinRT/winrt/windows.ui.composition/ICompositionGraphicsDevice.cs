// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionGraphicsDevice.xml' path='doc/member[@name="ICompositionGraphicsDevice"]/*' />
[Guid("FB22C6E1-80A2-4667-9936-DBEAF6EEFE95")]
[NativeTypeName("struct ICompositionGraphicsDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGraphicsDevice : ICompositionGraphicsDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGraphicsDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, uint>)(lpVtbl[1]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, uint>)(lpVtbl[2]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, HSTRING*, int>)(lpVtbl[4]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionGraphicsDevice.xml' path='doc/member[@name="ICompositionGraphicsDevice.CreateDrawingSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateDrawingSurface([NativeTypeName("ABI::Windows::Foundation::Size")] Size sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")] ICompositionDrawingSurface** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, Size, DirectXPixelFormat, DirectXAlphaMode, ICompositionDrawingSurface**, int>)(lpVtbl[6]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this), sizePixels, pixelFormat, alphaMode, result);
    }

    /// <include file='ICompositionGraphicsDevice.xml' path='doc/member[@name="ICompositionGraphicsDevice.add_RenderingDeviceReplaced"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_RenderingDeviceReplaced([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCompositionGraphicsDevice_Windows__CUI__CComposition__CRenderingDeviceReplacedEventArgs_t *")] ITypedEventHandler<Pointer<ICompositionGraphicsDevice>, Pointer<IRenderingDeviceReplacedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, ITypedEventHandler<Pointer<ICompositionGraphicsDevice>, Pointer<IRenderingDeviceReplacedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICompositionGraphicsDevice.xml' path='doc/member[@name="ICompositionGraphicsDevice.remove_RenderingDeviceReplaced"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_RenderingDeviceReplaced(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice*, EventRegistrationToken, int>)(lpVtbl[8]))((ICompositionGraphicsDevice*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateDrawingSurface([NativeTypeName("ABI::Windows::Foundation::Size")] Size sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")] ICompositionDrawingSurface** result);

        [VtblIndex(7)]
        HRESULT add_RenderingDeviceReplaced([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCompositionGraphicsDevice_Windows__CUI__CComposition__CRenderingDeviceReplacedEventArgs_t *")] ITypedEventHandler<Pointer<ICompositionGraphicsDevice>, Pointer<IRenderingDeviceReplacedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_RenderingDeviceReplaced(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size, ABI::Windows::Graphics::DirectX::DirectXPixelFormat, ABI::Windows::Graphics::DirectX::DirectXAlphaMode, ABI::Windows::UI::Composition::ICompositionDrawingSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, DirectXPixelFormat, DirectXAlphaMode, ICompositionDrawingSurface**, int> CreateDrawingSurface;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCompositionGraphicsDevice_Windows__CUI__CComposition__CRenderingDeviceReplacedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICompositionGraphicsDevice>, Pointer<IRenderingDeviceReplacedEventArgs>>*, EventRegistrationToken*, int> add_RenderingDeviceReplaced;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RenderingDeviceReplaced;
    }
}
