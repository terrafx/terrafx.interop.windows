// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder"]/*' />
[Guid("0351550E-3E64-4572-A93A-84075A37C917")]
[NativeTypeName("struct IBackgroundTaskBuilder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskBuilder : IBackgroundTaskBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskBuilder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, uint>)(lpVtbl[1]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, uint>)(lpVtbl[2]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder.put_TaskEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_TaskEntryPoint(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, HSTRING, int>)(lpVtbl[6]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder.get_TaskEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TaskEntryPoint(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, HSTRING*, int>)(lpVtbl[7]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder.SetTrigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTrigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger *")] IBackgroundTrigger* trigger)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, IBackgroundTrigger*, int>)(lpVtbl[8]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), trigger);
    }

    /// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder.AddCondition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddCondition([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundCondition *")] IBackgroundCondition* condition)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, IBackgroundCondition*, int>)(lpVtbl[9]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), condition);
    }

    /// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder.put_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, HSTRING, int>)(lpVtbl[10]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, HSTRING*, int>)(lpVtbl[11]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskBuilder.xml' path='doc/member[@name="IBackgroundTaskBuilder.Register"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Register([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **")] IBackgroundTaskRegistration** task)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskBuilder*, IBackgroundTaskRegistration**, int>)(lpVtbl[12]))((IBackgroundTaskBuilder*)Unsafe.AsPointer(ref this), task);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_TaskEntryPoint(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_TaskEntryPoint(HSTRING* value);

        [VtblIndex(8)]
        HRESULT SetTrigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger *")] IBackgroundTrigger* trigger);

        [VtblIndex(9)]
        HRESULT AddCondition([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundCondition *")] IBackgroundCondition* condition);

        [VtblIndex(10)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(12)]
        HRESULT Register([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **")] IBackgroundTaskRegistration** task);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_TaskEntryPoint;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TaskEntryPoint;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTrigger *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTrigger*, int> SetTrigger;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundCondition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundCondition*, int> AddCondition;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskRegistration**, int> Register;
    }
}
