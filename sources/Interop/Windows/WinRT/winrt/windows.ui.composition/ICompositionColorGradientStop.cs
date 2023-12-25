// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionColorGradientStop.xml' path='doc/member[@name="ICompositionColorGradientStop"]/*' />
[Guid("6F00CA92-C801-4E41-9A8F-A53E20F57778")]
[NativeTypeName("struct ICompositionColorGradientStop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionColorGradientStop : ICompositionColorGradientStop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionColorGradientStop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, uint>)(lpVtbl[1]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, uint>)(lpVtbl[2]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, HSTRING*, int>)(lpVtbl[4]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionColorGradientStop.xml' path='doc/member[@name="ICompositionColorGradientStop.get_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, Color*, int>)(lpVtbl[6]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionColorGradientStop.xml' path='doc/member[@name="ICompositionColorGradientStop.put_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, Color, int>)(lpVtbl[7]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionColorGradientStop.xml' path='doc/member[@name="ICompositionColorGradientStop.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Offset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, float*, int>)(lpVtbl[8]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionColorGradientStop.xml' path='doc/member[@name="ICompositionColorGradientStop.put_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Offset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionColorGradientStop*, float, int>)(lpVtbl[9]))((ICompositionColorGradientStop*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(8)]
        HRESULT get_Offset(float* value);

        [VtblIndex(9)]
        HRESULT put_Offset(float value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_Color;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_Color;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Offset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Offset;
    }
}
