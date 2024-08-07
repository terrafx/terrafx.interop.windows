// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics"]/*' />
[Guid("5C6C279C-D7CA-4779-9188-4057219CE64C")]
[NativeTypeName("struct IMemoryManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMemoryManagerStatics : IMemoryManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMemoryManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, uint>)(lpVtbl[1]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, uint>)(lpVtbl[2]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.get_AppMemoryUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppMemoryUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, ulong*, int>)(lpVtbl[6]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.get_AppMemoryUsageLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppMemoryUsageLimit([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, ulong*, int>)(lpVtbl[7]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.get_AppMemoryUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppMemoryUsageLevel([NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, AppMemoryUsageLevel*, int>)(lpVtbl[8]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.add_AppMemoryUsageIncreased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_AppMemoryUsageIncreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.remove_AppMemoryUsageIncreased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_AppMemoryUsageIncreased(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, EventRegistrationToken, int>)(lpVtbl[10]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.add_AppMemoryUsageDecreased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_AppMemoryUsageDecreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.remove_AppMemoryUsageDecreased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_AppMemoryUsageDecreased(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, EventRegistrationToken, int>)(lpVtbl[12]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.add_AppMemoryUsageLimitChanging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_AppMemoryUsageLimitChanging([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CAppMemoryUsageLimitChangingEventArgs_t *")] IEventHandler<Pointer<IAppMemoryUsageLimitChangingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, IEventHandler<Pointer<IAppMemoryUsageLimitChangingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMemoryManagerStatics.xml' path='doc/member[@name="IMemoryManagerStatics.remove_AppMemoryUsageLimitChanging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_AppMemoryUsageLimitChanging(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics*, EventRegistrationToken, int>)(lpVtbl[14]))((IMemoryManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppMemoryUsage([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_AppMemoryUsageLimit([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(8)]
        HRESULT get_AppMemoryUsageLevel([NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value);

        [VtblIndex(9)]
        HRESULT add_AppMemoryUsageIncreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_AppMemoryUsageIncreased(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_AppMemoryUsageDecreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_AppMemoryUsageDecreased(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_AppMemoryUsageLimitChanging([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CAppMemoryUsageLimitChangingEventArgs_t *")] IEventHandler<Pointer<IAppMemoryUsageLimitChangingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_AppMemoryUsageLimitChanging(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_AppMemoryUsage;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_AppMemoryUsageLimit;

        [NativeTypeName("HRESULT (ABI::Windows::System::AppMemoryUsageLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppMemoryUsageLevel*, int> get_AppMemoryUsageLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_AppMemoryUsageIncreased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AppMemoryUsageIncreased;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_AppMemoryUsageDecreased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AppMemoryUsageDecreased;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CAppMemoryUsageLimitChangingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IAppMemoryUsageLimitChangingEventArgs>>*, EventRegistrationToken*, int> add_AppMemoryUsageLimitChanging;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AppMemoryUsageLimitChanging;
    }
}
