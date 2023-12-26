// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPointLight.xml' path='doc/member[@name="IPointLight"]/*' />
[Guid("B18545B3-0C5A-4AB0-BEDC-4F3546948272")]
[NativeTypeName("struct IPointLight : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointLight : IPointLight.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointLight));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, Guid*, void**, int>)(lpVtbl[0]))((IPointLight*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, uint>)(lpVtbl[1]))((IPointLight*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, uint>)(lpVtbl[2]))((IPointLight*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, uint*, Guid**, int>)(lpVtbl[3]))((IPointLight*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, HSTRING*, int>)(lpVtbl[4]))((IPointLight*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, TrustLevel*, int>)(lpVtbl[5]))((IPointLight*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.get_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, Color*, int>)(lpVtbl[6]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.put_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, Color, int>)(lpVtbl[7]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.get_ConstantAttenuation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ConstantAttenuation(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, float*, int>)(lpVtbl[8]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.put_ConstantAttenuation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ConstantAttenuation(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, float, int>)(lpVtbl[9]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.get_CoordinateSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CoordinateSpace([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, IVisual**, int>)(lpVtbl[10]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.put_CoordinateSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CoordinateSpace([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, IVisual*, int>)(lpVtbl[11]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.get_LinearAttenuation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LinearAttenuation(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, float*, int>)(lpVtbl[12]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.put_LinearAttenuation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_LinearAttenuation(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, float, int>)(lpVtbl[13]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, Vector3*, int>)(lpVtbl[14]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.put_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, Vector3, int>)(lpVtbl[15]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.get_QuadraticAttenuation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_QuadraticAttenuation(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, float*, int>)(lpVtbl[16]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointLight.xml' path='doc/member[@name="IPointLight.put_QuadraticAttenuation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_QuadraticAttenuation(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointLight*, float, int>)(lpVtbl[17]))((IPointLight*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(8)]
        HRESULT get_ConstantAttenuation(float* value);

        [VtblIndex(9)]
        HRESULT put_ConstantAttenuation(float value);

        [VtblIndex(10)]
        HRESULT get_CoordinateSpace([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value);

        [VtblIndex(11)]
        HRESULT put_CoordinateSpace([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value);

        [VtblIndex(12)]
        HRESULT get_LinearAttenuation(float* value);

        [VtblIndex(13)]
        HRESULT put_LinearAttenuation(float value);

        [VtblIndex(14)]
        HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(15)]
        HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(16)]
        HRESULT get_QuadraticAttenuation(float* value);

        [VtblIndex(17)]
        HRESULT put_QuadraticAttenuation(float value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_ConstantAttenuation;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_ConstantAttenuation;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual**, int> get_CoordinateSpace;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> put_CoordinateSpace;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LinearAttenuation;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_LinearAttenuation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_Offset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_QuadraticAttenuation;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_QuadraticAttenuation;
    }
}
