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

/// <include file='IVisual2.xml' path='doc/member[@name="IVisual2"]/*' />
[Guid("3052B611-56C3-4C3E-8BF3-F6E1AD473F06")]
[NativeTypeName("struct IVisual2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVisual2 : IVisual2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVisual2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, Guid*, void**, int>)(lpVtbl[0]))((IVisual2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, uint>)(lpVtbl[1]))((IVisual2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, uint>)(lpVtbl[2]))((IVisual2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, uint*, Guid**, int>)(lpVtbl[3]))((IVisual2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, HSTRING*, int>)(lpVtbl[4]))((IVisual2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, TrustLevel*, int>)(lpVtbl[5]))((IVisual2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVisual2.xml' path='doc/member[@name="IVisual2.get_ParentForTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ParentForTransform([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, IVisual**, int>)(lpVtbl[6]))((IVisual2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual2.xml' path='doc/member[@name="IVisual2.put_ParentForTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ParentForTransform([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, IVisual*, int>)(lpVtbl[7]))((IVisual2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual2.xml' path='doc/member[@name="IVisual2.get_RelativeOffsetAdjustment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RelativeOffsetAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, Vector3*, int>)(lpVtbl[8]))((IVisual2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual2.xml' path='doc/member[@name="IVisual2.put_RelativeOffsetAdjustment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RelativeOffsetAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, Vector3, int>)(lpVtbl[9]))((IVisual2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual2.xml' path='doc/member[@name="IVisual2.get_RelativeSizeAdjustment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RelativeSizeAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, Vector2*, int>)(lpVtbl[10]))((IVisual2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual2.xml' path='doc/member[@name="IVisual2.put_RelativeSizeAdjustment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RelativeSizeAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual2*, Vector2, int>)(lpVtbl[11]))((IVisual2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ParentForTransform([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value);

        [VtblIndex(7)]
        HRESULT put_ParentForTransform([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value);

        [VtblIndex(8)]
        HRESULT get_RelativeOffsetAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(9)]
        HRESULT put_RelativeOffsetAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(10)]
        HRESULT get_RelativeSizeAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(11)]
        HRESULT put_RelativeSizeAdjustment([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual**, int> get_ParentForTransform;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> put_ParentForTransform;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_RelativeOffsetAdjustment;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_RelativeOffsetAdjustment;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_RelativeSizeAdjustment;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_RelativeSizeAdjustment;
    }
}
