// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallStore.xml' path='doc/member[@name="IPhoneCallStore"]/*' />
[Guid("5F610748-18A6-4173-86D1-28BE9DC62DBA")]
[NativeTypeName("struct IPhoneCallStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallStore : IPhoneCallStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, uint>)(lpVtbl[1]))((IPhoneCallStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, uint>)(lpVtbl[2]))((IPhoneCallStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallStore.xml' path='doc/member[@name="IPhoneCallStore.IsEmergencyPhoneNumberAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsEmergencyPhoneNumberAsync(HSTRING number, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[6]))((IPhoneCallStore*)Unsafe.AsPointer(ref this), number, result);
    }

    /// <include file='IPhoneCallStore.xml' path='doc/member[@name="IPhoneCallStore.GetDefaultLineAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultLineAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_GUID_t **")] IAsyncOperation<Guid>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, IAsyncOperation<Guid>**, int>)(lpVtbl[7]))((IPhoneCallStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCallStore.xml' path='doc/member[@name="IPhoneCallStore.RequestLineWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestLineWatcher([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineWatcher **")] IPhoneLineWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallStore*, IPhoneLineWatcher**, int>)(lpVtbl[8]))((IPhoneCallStore*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsEmergencyPhoneNumberAsync(HSTRING number, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(7)]
        HRESULT GetDefaultLineAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_GUID_t **")] IAsyncOperation<Guid>** result);

        [VtblIndex(8)]
        HRESULT RequestLineWatcher([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineWatcher **")] IPhoneLineWatcher** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> IsEmergencyPhoneNumberAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Guid>**, int> GetDefaultLineAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneLineWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneLineWatcher**, int> RequestLineWatcher;
    }
}
