// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProjectionManagerStatics.xml' path='doc/member[@name="IProjectionManagerStatics"]/*' />
[Guid("B65F913D-E2F0-4FFD-BA95-34241647E45C")]
[NativeTypeName("struct IProjectionManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProjectionManagerStatics : IProjectionManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProjectionManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, uint>)(lpVtbl[1]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, uint>)(lpVtbl[2]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProjectionManagerStatics.xml' path='doc/member[@name="IProjectionManagerStatics.StartProjectingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartProjectingAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, int, int, IAsyncAction**, int>)(lpVtbl[6]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), projectionViewId, anchorViewId, operation);
    }

    /// <include file='IProjectionManagerStatics.xml' path='doc/member[@name="IProjectionManagerStatics.SwapDisplaysForViewsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SwapDisplaysForViewsAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, int, int, IAsyncAction**, int>)(lpVtbl[7]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), projectionViewId, anchorViewId, operation);
    }

    /// <include file='IProjectionManagerStatics.xml' path='doc/member[@name="IProjectionManagerStatics.StopProjectingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StopProjectingAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, int, int, IAsyncAction**, int>)(lpVtbl[8]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), projectionViewId, anchorViewId, operation);
    }

    /// <include file='IProjectionManagerStatics.xml' path='doc/member[@name="IProjectionManagerStatics.get_ProjectionDisplayAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProjectionDisplayAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, byte*, int>)(lpVtbl[9]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProjectionManagerStatics.xml' path='doc/member[@name="IProjectionManagerStatics.add_ProjectionDisplayAvailableChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ProjectionDisplayAvailableChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IProjectionManagerStatics.xml' path='doc/member[@name="IProjectionManagerStatics.remove_ProjectionDisplayAvailableChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ProjectionDisplayAvailableChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics*, EventRegistrationToken, int>)(lpVtbl[11]))((IProjectionManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartProjectingAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT SwapDisplaysForViewsAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT StopProjectingAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT get_ProjectionDisplayAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT add_ProjectionDisplayAvailableChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ProjectionDisplayAvailableChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IAsyncAction**, int> StartProjectingAsync;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IAsyncAction**, int> SwapDisplaysForViewsAsync;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IAsyncAction**, int> StopProjectingAsync;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ProjectionDisplayAvailable;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ProjectionDisplayAvailableChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ProjectionDisplayAvailableChanged;
    }
}
