// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneLine3.xml' path='doc/member[@name="IPhoneLine3"]/*' />
[Guid("E2E33CF7-2406-57F3-826A-E5A5F40D6FB5")]
[NativeTypeName("struct IPhoneLine3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLine3 : IPhoneLine3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLine3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneLine3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, uint>)(lpVtbl[1]))((IPhoneLine3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, uint>)(lpVtbl[2]))((IPhoneLine3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneLine3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, HSTRING*, int>)(lpVtbl[4]))((IPhoneLine3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneLine3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneLine3.xml' path='doc/member[@name="IPhoneLine3.DialWithResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DialWithResult(HSTRING number, HSTRING displayName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineDialResult **")] IPhoneLineDialResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, HSTRING, HSTRING, IPhoneLineDialResult**, int>)(lpVtbl[6]))((IPhoneLine3*)Unsafe.AsPointer(ref this), number, displayName, result);
    }

    /// <include file='IPhoneLine3.xml' path='doc/member[@name="IPhoneLine3.DialWithResultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DialWithResultAsync(HSTRING number, HSTRING displayName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneLineDialResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IPhoneLine3*)Unsafe.AsPointer(ref this), number, displayName, operation);
    }

    /// <include file='IPhoneLine3.xml' path='doc/member[@name="IPhoneLine3.GetAllActivePhoneCalls"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAllActivePhoneCalls([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallsResult **")] IPhoneCallsResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, IPhoneCallsResult**, int>)(lpVtbl[8]))((IPhoneLine3*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneLine3.xml' path='doc/member[@name="IPhoneLine3.GetAllActivePhoneCallsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAllActivePhoneCallsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallsResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine3*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IPhoneLine3*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT DialWithResult(HSTRING number, HSTRING displayName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineDialResult **")] IPhoneLineDialResult** result);

        [VtblIndex(7)]
        HRESULT DialWithResultAsync(HSTRING number, HSTRING displayName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneLineDialResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT GetAllActivePhoneCalls([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallsResult **")] IPhoneCallsResult** result);

        [VtblIndex(9)]
        HRESULT GetAllActivePhoneCallsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallsResult_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::IPhoneLineDialResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPhoneLineDialResult**, int> DialWithResult;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneLineDialResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int> DialWithResultAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallsResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallsResult**, int> GetAllActivePhoneCalls;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetAllActivePhoneCallsAsync;
    }
}
