// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICrossSlidingEventArgs.xml' path='doc/member[@name="ICrossSlidingEventArgs"]/*' />
[Guid("E9374738-6F88-41D9-8720-78E08E398349")]
[NativeTypeName("struct ICrossSlidingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICrossSlidingEventArgs : ICrossSlidingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICrossSlidingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, uint>)(lpVtbl[1]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, uint>)(lpVtbl[2]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICrossSlidingEventArgs.xml' path='doc/member[@name="ICrossSlidingEventArgs.get_PointerDeviceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, PointerDeviceType*, int>)(lpVtbl[6]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICrossSlidingEventArgs.xml' path='doc/member[@name="ICrossSlidingEventArgs.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, Point*, int>)(lpVtbl[7]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICrossSlidingEventArgs.xml' path='doc/member[@name="ICrossSlidingEventArgs.get_CrossSlidingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CrossSlidingState([NativeTypeName("ABI::Windows::UI::Input::CrossSlidingState *")] CrossSlidingState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICrossSlidingEventArgs*, CrossSlidingState*, int>)(lpVtbl[8]))((ICrossSlidingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value);

        [VtblIndex(7)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(8)]
        HRESULT get_CrossSlidingState([NativeTypeName("ABI::Windows::UI::Input::CrossSlidingState *")] CrossSlidingState* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::CrossSlidingState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CrossSlidingState*, int> get_CrossSlidingState;
    }
}
