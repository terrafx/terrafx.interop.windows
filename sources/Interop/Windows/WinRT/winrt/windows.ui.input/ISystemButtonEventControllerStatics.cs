// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemButtonEventControllerStatics.xml' path='doc/member[@name="ISystemButtonEventControllerStatics"]/*' />
[Guid("632FB07B-20BD-5E15-AF4A-00DBF2064FFA")]
[NativeTypeName("struct ISystemButtonEventControllerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemButtonEventControllerStatics : ISystemButtonEventControllerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemButtonEventControllerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventControllerStatics*, uint>)(lpVtbl[1]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventControllerStatics*, uint>)(lpVtbl[2]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventControllerStatics*, HSTRING*, int>)(lpVtbl[4]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemButtonEventControllerStatics.xml' path='doc/member[@name="ISystemButtonEventControllerStatics.CreateForDispatcherQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForDispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue *")] IDispatcherQueue* queue, [NativeTypeName("ABI::Windows::UI::Input::ISystemButtonEventController **")] ISystemButtonEventController** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventControllerStatics*, IDispatcherQueue*, ISystemButtonEventController**, int>)(lpVtbl[6]))((ISystemButtonEventControllerStatics*)Unsafe.AsPointer(ref this), queue, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForDispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue *")] IDispatcherQueue* queue, [NativeTypeName("ABI::Windows::UI::Input::ISystemButtonEventController **")] ISystemButtonEventController** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IDispatcherQueue *, ABI::Windows::UI::Input::ISystemButtonEventController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatcherQueue*, ISystemButtonEventController**, int> CreateForDispatcherQueue;
    }
}
