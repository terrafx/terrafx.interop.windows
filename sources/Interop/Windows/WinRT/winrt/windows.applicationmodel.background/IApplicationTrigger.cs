// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationTrigger.xml' path='doc/member[@name="IApplicationTrigger"]/*' />
[Guid("0B468630-9574-492C-9E93-1A3AE6335FE9")]
[NativeTypeName("struct IApplicationTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationTrigger : IApplicationTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, uint>)(lpVtbl[1]))((IApplicationTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, uint>)(lpVtbl[2]))((IApplicationTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, HSTRING*, int>)(lpVtbl[4]))((IApplicationTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationTrigger.xml' path='doc/member[@name="IApplicationTrigger.RequestAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CApplicationTriggerResult_t **")] IAsyncOperation<ApplicationTriggerResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, IAsyncOperation<ApplicationTriggerResult>**, int>)(lpVtbl[6]))((IApplicationTrigger*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IApplicationTrigger.xml' path='doc/member[@name="IApplicationTrigger.RequestAsyncWithArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAsyncWithArguments([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CApplicationTriggerResult_t **")] IAsyncOperation<ApplicationTriggerResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationTrigger*, IPropertySet*, IAsyncOperation<ApplicationTriggerResult>**, int>)(lpVtbl[7]))((IApplicationTrigger*)Unsafe.AsPointer(ref this), arguments, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CApplicationTriggerResult_t **")] IAsyncOperation<ApplicationTriggerResult>** result);

        [VtblIndex(7)]
        HRESULT RequestAsyncWithArguments([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CApplicationTriggerResult_t **")] IAsyncOperation<ApplicationTriggerResult>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CApplicationTriggerResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<ApplicationTriggerResult>**, int> RequestAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CApplicationTriggerResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IAsyncOperation<ApplicationTriggerResult>**, int> RequestAsyncWithArguments;
    }
}
