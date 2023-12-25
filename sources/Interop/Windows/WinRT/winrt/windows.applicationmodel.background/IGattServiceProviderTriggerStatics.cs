// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProviderTriggerStatics.xml' path='doc/member[@name="IGattServiceProviderTriggerStatics"]/*' />
[Guid("B413A36A-E294-4591-A5A6-64891A828153")]
[NativeTypeName("struct IGattServiceProviderTriggerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderTriggerStatics : IGattServiceProviderTriggerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderTriggerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProviderTriggerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerStatics*, uint>)(lpVtbl[1]))((IGattServiceProviderTriggerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerStatics*, uint>)(lpVtbl[2]))((IGattServiceProviderTriggerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProviderTriggerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProviderTriggerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProviderTriggerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProviderTriggerStatics.xml' path='doc/member[@name="IGattServiceProviderTriggerStatics.CreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAsync(HSTRING triggerId, Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CGattServiceProviderTriggerResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerStatics*, HSTRING, Guid, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IGattServiceProviderTriggerStatics*)Unsafe.AsPointer(ref this), triggerId, serviceUuid, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAsync(HSTRING triggerId, Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CGattServiceProviderTriggerResult_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CGattServiceProviderTriggerResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, IAsyncOperation<IntPtr>**, int> CreateAsync;
    }
}
