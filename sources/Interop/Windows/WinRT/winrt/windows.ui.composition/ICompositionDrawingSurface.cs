// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionDrawingSurface.xml' path='doc/member[@name="ICompositionDrawingSurface"]/*' />
[Guid("A166C300-FAD0-4D11-9E67-E433162FF49E")]
[NativeTypeName("struct ICompositionDrawingSurface : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionDrawingSurface : ICompositionDrawingSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionDrawingSurface));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, uint>)(lpVtbl[1]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, uint>)(lpVtbl[2]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, HSTRING*, int>)(lpVtbl[4]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionDrawingSurface.xml' path='doc/member[@name="ICompositionDrawingSurface.get_AlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")] DirectXAlphaMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, DirectXAlphaMode*, int>)(lpVtbl[6]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionDrawingSurface.xml' path='doc/member[@name="ICompositionDrawingSurface.get_PixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PixelFormat([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat *")] DirectXPixelFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, DirectXPixelFormat*, int>)(lpVtbl[7]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionDrawingSurface.xml' path='doc/member[@name="ICompositionDrawingSurface.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface*, Size*, int>)(lpVtbl[8]))((ICompositionDrawingSurface*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")] DirectXAlphaMode* value);

        [VtblIndex(7)]
        HRESULT get_PixelFormat([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat *")] DirectXPixelFormat* value);

        [VtblIndex(8)]
        HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXAlphaMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXAlphaMode*, int> get_AlphaMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXPixelFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXPixelFormat*, int> get_PixelFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_Size;
    }
}
