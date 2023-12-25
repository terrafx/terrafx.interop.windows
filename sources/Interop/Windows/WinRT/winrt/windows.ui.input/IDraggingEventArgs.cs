// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDraggingEventArgs.xml' path='doc/member[@name="IDraggingEventArgs"]/*' />
[Guid("1C905384-083C-4BD3-B559-179CDDEB33EC")]
[NativeTypeName("struct IDraggingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDraggingEventArgs : IDraggingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDraggingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, uint>)(lpVtbl[1]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, uint>)(lpVtbl[2]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDraggingEventArgs.xml' path='doc/member[@name="IDraggingEventArgs.get_PointerDeviceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, PointerDeviceType*, int>)(lpVtbl[6]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDraggingEventArgs.xml' path='doc/member[@name="IDraggingEventArgs.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, Point*, int>)(lpVtbl[7]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDraggingEventArgs.xml' path='doc/member[@name="IDraggingEventArgs.get_DraggingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DraggingState([NativeTypeName("ABI::Windows::UI::Input::DraggingState *")] DraggingState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDraggingEventArgs*, DraggingState*, int>)(lpVtbl[8]))((IDraggingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value);

        [VtblIndex(7)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(8)]
        HRESULT get_DraggingState([NativeTypeName("ABI::Windows::UI::Input::DraggingState *")] DraggingState* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Input::PointerDeviceType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointerDeviceType*, int> get_PointerDeviceType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::DraggingState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DraggingState*, int> get_DraggingState;
    }
}
