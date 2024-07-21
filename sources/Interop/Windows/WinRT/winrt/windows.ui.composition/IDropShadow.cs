// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow"]/*' />
[Guid("CB977C07-A154-4851-85E7-A8924C84FAD8")]
[NativeTypeName("struct IDropShadow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDropShadow : IDropShadow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDropShadow));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, Guid*, void**, int>)(lpVtbl[0]))((IDropShadow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, uint>)(lpVtbl[1]))((IDropShadow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, uint>)(lpVtbl[2]))((IDropShadow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, uint*, Guid**, int>)(lpVtbl[3]))((IDropShadow*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, HSTRING*, int>)(lpVtbl[4]))((IDropShadow*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, TrustLevel*, int>)(lpVtbl[5]))((IDropShadow*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.get_BlurRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BlurRadius(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, float*, int>)(lpVtbl[6]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.put_BlurRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BlurRadius(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, float, int>)(lpVtbl[7]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.get_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, Color*, int>)(lpVtbl[8]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.put_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, Color, int>)(lpVtbl[9]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.get_Mask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Mask([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, ICompositionBrush**, int>)(lpVtbl[10]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.put_Mask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Mask([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, ICompositionBrush*, int>)(lpVtbl[11]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, Vector3*, int>)(lpVtbl[12]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.put_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, Vector3, int>)(lpVtbl[13]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.get_Opacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Opacity(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, float*, int>)(lpVtbl[14]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow.xml' path='doc/member[@name="IDropShadow.put_Opacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Opacity(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow*, float, int>)(lpVtbl[15]))((IDropShadow*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BlurRadius(float* value);

        [VtblIndex(7)]
        HRESULT put_BlurRadius(float value);

        [VtblIndex(8)]
        HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(10)]
        HRESULT get_Mask([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** value);

        [VtblIndex(11)]
        HRESULT put_Mask([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* value);

        [VtblIndex(12)]
        HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(13)]
        HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(14)]
        HRESULT get_Opacity(float* value);

        [VtblIndex(15)]
        HRESULT put_Opacity(float value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_BlurRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_BlurRadius;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_Color;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_Color;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionBrush**, int> get_Mask;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionBrush*, int> put_Mask;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_Offset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Opacity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Opacity;
    }
}
