// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStartupTask.xml' path='doc/member[@name="IStartupTask"]/*' />
[Guid("F75C23C8-B5F2-4F6C-88DD-36CB1D599D17")]
[NativeTypeName("struct IStartupTask : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStartupTask : IStartupTask.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStartupTask));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, Guid*, void**, int>)(lpVtbl[0]))((IStartupTask*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, uint>)(lpVtbl[1]))((IStartupTask*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, uint>)(lpVtbl[2]))((IStartupTask*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, uint*, Guid**, int>)(lpVtbl[3]))((IStartupTask*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, HSTRING*, int>)(lpVtbl[4]))((IStartupTask*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, TrustLevel*, int>)(lpVtbl[5]))((IStartupTask*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStartupTask.xml' path='doc/member[@name="IStartupTask.RequestEnableAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestEnableAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CStartupTaskState_t **")] IAsyncOperation<StartupTaskState>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, IAsyncOperation<StartupTaskState>**, int>)(lpVtbl[6]))((IStartupTask*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStartupTask.xml' path='doc/member[@name="IStartupTask.Disable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Disable()
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, int>)(lpVtbl[7]))((IStartupTask*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStartupTask.xml' path='doc/member[@name="IStartupTask.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::ApplicationModel::StartupTaskState *")] StartupTaskState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, StartupTaskState*, int>)(lpVtbl[8]))((IStartupTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStartupTask.xml' path='doc/member[@name="IStartupTask.get_TaskId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TaskId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStartupTask*, HSTRING*, int>)(lpVtbl[9]))((IStartupTask*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestEnableAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CStartupTaskState_t **")] IAsyncOperation<StartupTaskState>** operation);

        [VtblIndex(7)]
        HRESULT Disable();

        [VtblIndex(8)]
        HRESULT get_State([NativeTypeName("ABI::Windows::ApplicationModel::StartupTaskState *")] StartupTaskState* value);

        [VtblIndex(9)]
        HRESULT get_TaskId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CStartupTaskState_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<StartupTaskState>**, int> RequestEnableAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Disable;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::StartupTaskState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StartupTaskState*, int> get_State;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TaskId;
    }
}
