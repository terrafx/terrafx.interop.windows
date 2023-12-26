// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint"]/*' />
[Guid("E995317D-7296-42D9-8233-C5BE73B74A4A")]
[NativeTypeName("struct IPointerPoint : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerPoint : IPointerPoint.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointerPoint));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, uint>)(lpVtbl[1]))((IPointerPoint*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, uint>)(lpVtbl[2]))((IPointerPoint*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPoint*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, HSTRING*, int>)(lpVtbl[4]))((IPointerPoint*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPoint*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_PointerDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PointerDevice([NativeTypeName("ABI::Windows::Devices::Input::IPointerDevice **")] IPointerDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, IPointerDevice**, int>)(lpVtbl[6]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, Point*, int>)(lpVtbl[7]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_RawPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RawPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, Point*, int>)(lpVtbl[8]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_PointerId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PointerId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, uint*, int>)(lpVtbl[9]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_FrameId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FrameId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, uint*, int>)(lpVtbl[10]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Timestamp([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, ulong*, int>)(lpVtbl[11]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_IsInContact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsInContact([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, byte*, int>)(lpVtbl[12]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPoint.xml' path='doc/member[@name="IPointerPoint.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::UI::Input::IPointerPointProperties **")] IPointerPointProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPoint*, IPointerPointProperties**, int>)(lpVtbl[13]))((IPointerPoint*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PointerDevice([NativeTypeName("ABI::Windows::Devices::Input::IPointerDevice **")] IPointerDevice** value);

        [VtblIndex(7)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(8)]
        HRESULT get_RawPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(9)]
        HRESULT get_PointerId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT get_FrameId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT get_Timestamp([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(12)]
        HRESULT get_IsInContact([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::UI::Input::IPointerPointProperties **")] IPointerPointProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Input::IPointerDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerDevice**, int> get_PointerDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_RawPosition;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PointerId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_FrameId;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_Timestamp;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInContact;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPointProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPointProperties**, int> get_Properties;
    }
}
