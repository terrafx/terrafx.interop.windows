// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositor7.xml' path='doc/member[@name="ICompositor7"]/*' />
[Guid("D3483FAD-9A12-53BA-BFC8-88B7FF7977C6")]
[NativeTypeName("struct ICompositor7 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor7 : ICompositor7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor7));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, Guid*, void**, int>)(lpVtbl[0]))((ICompositor7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, uint>)(lpVtbl[1]))((ICompositor7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, uint>)(lpVtbl[2]))((ICompositor7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositor7*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, HSTRING*, int>)(lpVtbl[4]))((ICompositor7*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, TrustLevel*, int>)(lpVtbl[5]))((ICompositor7*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositor7.xml' path='doc/member[@name="ICompositor7.get_DispatcherQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, IDispatcherQueue**, int>)(lpVtbl[6]))((ICompositor7*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositor7.xml' path='doc/member[@name="ICompositor7.CreateAnimationPropertyInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAnimationPropertyInfo([NativeTypeName("ABI::Windows::UI::Composition::IAnimationPropertyInfo **")] IAnimationPropertyInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, IAnimationPropertyInfo**, int>)(lpVtbl[7]))((ICompositor7*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor7.xml' path='doc/member[@name="ICompositor7.CreateRectangleClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateRectangleClip([NativeTypeName("ABI::Windows::UI::Composition::IRectangleClip **")] IRectangleClip** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, IRectangleClip**, int>)(lpVtbl[8]))((ICompositor7*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor7.xml' path='doc/member[@name="ICompositor7.CreateRectangleClipWithSides"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateRectangleClipWithSides(float left, float top, float right, float bottom, [NativeTypeName("ABI::Windows::UI::Composition::IRectangleClip **")] IRectangleClip** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, float, float, float, float, IRectangleClip**, int>)(lpVtbl[9]))((ICompositor7*)Unsafe.AsPointer(ref this), left, top, right, bottom, result);
    }

    /// <include file='ICompositor7.xml' path='doc/member[@name="ICompositor7.CreateRectangleClipWithSidesAndRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateRectangleClipWithSidesAndRadius(float left, float top, float right, float bottom, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 topLeftRadius, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 topRightRadius, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 bottomRightRadius, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 bottomLeftRadius, [NativeTypeName("ABI::Windows::UI::Composition::IRectangleClip **")] IRectangleClip** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor7*, float, float, float, float, Vector2, Vector2, Vector2, Vector2, IRectangleClip**, int>)(lpVtbl[10]))((ICompositor7*)Unsafe.AsPointer(ref this), left, top, right, bottom, topLeftRadius, topRightRadius, bottomRightRadius, bottomLeftRadius, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value);

        [VtblIndex(7)]
        HRESULT CreateAnimationPropertyInfo([NativeTypeName("ABI::Windows::UI::Composition::IAnimationPropertyInfo **")] IAnimationPropertyInfo** result);

        [VtblIndex(8)]
        HRESULT CreateRectangleClip([NativeTypeName("ABI::Windows::UI::Composition::IRectangleClip **")] IRectangleClip** result);

        [VtblIndex(9)]
        HRESULT CreateRectangleClipWithSides(float left, float top, float right, float bottom, [NativeTypeName("ABI::Windows::UI::Composition::IRectangleClip **")] IRectangleClip** result);

        [VtblIndex(10)]
        HRESULT CreateRectangleClipWithSidesAndRadius(float left, float top, float right, float bottom, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 topLeftRadius, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 topRightRadius, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 bottomRightRadius, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 bottomLeftRadius, [NativeTypeName("ABI::Windows::UI::Composition::IRectangleClip **")] IRectangleClip** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IDispatcherQueue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatcherQueue**, int> get_DispatcherQueue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IAnimationPropertyInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAnimationPropertyInfo**, int> CreateAnimationPropertyInfo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IRectangleClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRectangleClip**, int> CreateRectangleClip;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, ABI::Windows::UI::Composition::IRectangleClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, float, IRectangleClip**, int> CreateRectangleClipWithSides;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::UI::Composition::IRectangleClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, float, Vector2, Vector2, Vector2, Vector2, IRectangleClip**, int> CreateRectangleClipWithSidesAndRadius;
    }
}
