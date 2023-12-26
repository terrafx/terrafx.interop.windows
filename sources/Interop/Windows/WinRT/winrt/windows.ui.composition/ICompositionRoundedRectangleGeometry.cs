// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionRoundedRectangleGeometry.xml' path='doc/member[@name="ICompositionRoundedRectangleGeometry"]/*' />
[Guid("8770C822-1D50-4B8B-B013-7C9A0E46935F")]
[NativeTypeName("struct ICompositionRoundedRectangleGeometry : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionRoundedRectangleGeometry : ICompositionRoundedRectangleGeometry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionRoundedRectangleGeometry));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, uint>)(lpVtbl[1]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, uint>)(lpVtbl[2]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, HSTRING*, int>)(lpVtbl[4]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionRoundedRectangleGeometry.xml' path='doc/member[@name="ICompositionRoundedRectangleGeometry.get_CornerRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CornerRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, Vector2*, int>)(lpVtbl[6]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionRoundedRectangleGeometry.xml' path='doc/member[@name="ICompositionRoundedRectangleGeometry.put_CornerRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CornerRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, Vector2, int>)(lpVtbl[7]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionRoundedRectangleGeometry.xml' path='doc/member[@name="ICompositionRoundedRectangleGeometry.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, Vector2*, int>)(lpVtbl[8]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionRoundedRectangleGeometry.xml' path='doc/member[@name="ICompositionRoundedRectangleGeometry.put_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, Vector2, int>)(lpVtbl[9]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionRoundedRectangleGeometry.xml' path='doc/member[@name="ICompositionRoundedRectangleGeometry.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, Vector2*, int>)(lpVtbl[10]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionRoundedRectangleGeometry.xml' path='doc/member[@name="ICompositionRoundedRectangleGeometry.put_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionRoundedRectangleGeometry*, Vector2, int>)(lpVtbl[11]))((ICompositionRoundedRectangleGeometry*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CornerRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(7)]
        HRESULT put_CornerRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(8)]
        HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(9)]
        HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(10)]
        HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(11)]
        HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_CornerRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_CornerRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_Size;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_Size;
    }
}
