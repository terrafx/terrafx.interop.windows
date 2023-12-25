// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICubicBezierEasingFunction.xml' path='doc/member[@name="ICubicBezierEasingFunction"]/*' />
[Guid("32350666-C1E8-44F9-96B8-C98ACF0AE698")]
[NativeTypeName("struct ICubicBezierEasingFunction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICubicBezierEasingFunction : ICubicBezierEasingFunction.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICubicBezierEasingFunction));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, Guid*, void**, int>)(lpVtbl[0]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, uint>)(lpVtbl[1]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, uint>)(lpVtbl[2]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, uint*, Guid**, int>)(lpVtbl[3]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, HSTRING*, int>)(lpVtbl[4]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, TrustLevel*, int>)(lpVtbl[5]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICubicBezierEasingFunction.xml' path='doc/member[@name="ICubicBezierEasingFunction.get_ControlPoint1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ControlPoint1([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, Vector2*, int>)(lpVtbl[6]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICubicBezierEasingFunction.xml' path='doc/member[@name="ICubicBezierEasingFunction.get_ControlPoint2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ControlPoint2([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICubicBezierEasingFunction*, Vector2*, int>)(lpVtbl[7]))((ICubicBezierEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ControlPoint1([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(7)]
        HRESULT get_ControlPoint2([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_ControlPoint1;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_ControlPoint2;
    }
}
