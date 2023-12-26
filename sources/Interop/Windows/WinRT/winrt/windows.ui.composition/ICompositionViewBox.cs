// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox"]/*' />
[Guid("B440BF07-068F-4537-84C6-4ECBE019E1F4")]
[NativeTypeName("struct ICompositionViewBox : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionViewBox : ICompositionViewBox.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionViewBox));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, uint>)(lpVtbl[1]))((ICompositionViewBox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, uint>)(lpVtbl[2]))((ICompositionViewBox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, HSTRING*, int>)(lpVtbl[4]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.get_HorizontalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HorizontalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, float*, int>)(lpVtbl[6]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.put_HorizontalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_HorizontalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, float, int>)(lpVtbl[7]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, Vector2*, int>)(lpVtbl[8]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.put_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, Vector2, int>)(lpVtbl[9]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, Vector2*, int>)(lpVtbl[10]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.put_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, Vector2, int>)(lpVtbl[11]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.get_Stretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")] CompositionStretch* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, CompositionStretch*, int>)(lpVtbl[12]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.put_Stretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")] CompositionStretch value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, CompositionStretch, int>)(lpVtbl[13]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.get_VerticalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VerticalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, float*, int>)(lpVtbl[14]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionViewBox.xml' path='doc/member[@name="ICompositionViewBox.put_VerticalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_VerticalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionViewBox*, float, int>)(lpVtbl[15]))((ICompositionViewBox*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HorizontalAlignmentRatio(float* value);

        [VtblIndex(7)]
        HRESULT put_HorizontalAlignmentRatio(float value);

        [VtblIndex(8)]
        HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(9)]
        HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(10)]
        HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(11)]
        HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(12)]
        HRESULT get_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")] CompositionStretch* value);

        [VtblIndex(13)]
        HRESULT put_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")] CompositionStretch value);

        [VtblIndex(14)]
        HRESULT get_VerticalAlignmentRatio(float* value);

        [VtblIndex(15)]
        HRESULT put_VerticalAlignmentRatio(float value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_HorizontalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_HorizontalAlignmentRatio;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_Size;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_Size;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionStretch *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionStretch*, int> get_Stretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionStretch) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionStretch, int> put_Stretch;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_VerticalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_VerticalAlignmentRatio;
    }
}
