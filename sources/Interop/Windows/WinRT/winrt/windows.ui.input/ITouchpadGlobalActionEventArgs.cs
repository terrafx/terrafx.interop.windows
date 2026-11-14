// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITouchpadGlobalActionEventArgs.xml' path='doc/member[@name="ITouchpadGlobalActionEventArgs"]/*' />
[Guid("6EDAD206-E4E3-5F39-9D13-8575E8E2A12B")]
[NativeTypeName("struct ITouchpadGlobalActionEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITouchpadGlobalActionEventArgs : ITouchpadGlobalActionEventArgs.Interface, INativeGuid
{
    /// <include file='ITouchpadGlobalActionEventArgs.xml' path='doc/member[@name="ITouchpadGlobalActionEventArgs.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITouchpadGlobalActionEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, uint>)(lpVtbl[1]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, uint>)(lpVtbl[2]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITouchpadGlobalActionEventArgs.xml' path='doc/member[@name="ITouchpadGlobalActionEventArgs.get_Action"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Action([NativeTypeName("ABI::Windows::UI::Input::TouchpadGlobalAction *")] TouchpadGlobalAction* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, TouchpadGlobalAction*, int>)(lpVtbl[6]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchpadGlobalActionEventArgs.xml' path='doc/member[@name="ITouchpadGlobalActionEventArgs.get_PointerDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PointerDevice([NativeTypeName("ABI::Windows::Devices::Input::IPointerDevice **")] IPointerDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGlobalActionEventArgs*, IPointerDevice**, int>)(lpVtbl[7]))((ITouchpadGlobalActionEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Action([NativeTypeName("ABI::Windows::UI::Input::TouchpadGlobalAction *")] TouchpadGlobalAction* value);

        [VtblIndex(7)]
        HRESULT get_PointerDevice([NativeTypeName("ABI::Windows::Devices::Input::IPointerDevice **")] IPointerDevice** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::TouchpadGlobalAction *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TouchpadGlobalAction*, int> get_Action;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Input::IPointerDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerDevice**, int> get_PointerDevice;
    }
}
