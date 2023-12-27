// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4"]/*' />
[Guid("B9EC819F-B5A5-41C6-B3B3-DD1B3178BCF2")]
[NativeTypeName("struct ILauncherStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherStatics4 : ILauncherStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherStatics4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, uint>)(lpVtbl[1]))((ILauncherStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, uint>)(lpVtbl[2]))((ILauncherStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, HSTRING*, int>)(lpVtbl[4]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.QueryAppUriSupportAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueryAppUriSupportAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUriRuntimeClass*, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[6]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.QueryAppUriSupportWithPackageFamilyNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT QueryAppUriSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUriRuntimeClass*, HSTRING, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[7]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), uri, packageFamilyName, operation);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.FindAppUriHandlersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAppUriHandlersAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUriRuntimeClass*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int>)(lpVtbl[8]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.LaunchUriForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LaunchUriForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUser*, IUriRuntimeClass*, IAsyncOperation<LaunchUriStatus>**, int>)(lpVtbl[9]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, operation);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.LaunchUriWithOptionsForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LaunchUriWithOptionsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<LaunchUriStatus>**, int>)(lpVtbl[10]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, operation);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.LaunchUriWithDataForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LaunchUriWithDataForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<LaunchUriStatus>**, int>)(lpVtbl[11]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, inputData, operation);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.LaunchUriForResultsForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT LaunchUriForResultsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int>)(lpVtbl[12]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, operation);
    }

    /// <include file='ILauncherStatics4.xml' path='doc/member[@name="ILauncherStatics4.LaunchUriForResultsWithDataForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT LaunchUriForResultsWithDataForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int>)(lpVtbl[13]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, inputData, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT QueryAppUriSupportAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation);

        [VtblIndex(7)]
        HRESULT QueryAppUriSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation);

        [VtblIndex(8)]
        HRESULT FindAppUriHandlersAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation);

        [VtblIndex(9)]
        HRESULT LaunchUriForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation);

        [VtblIndex(10)]
        HRESULT LaunchUriWithOptionsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation);

        [VtblIndex(11)]
        HRESULT LaunchUriWithDataForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation);

        [VtblIndex(12)]
        HRESULT LaunchUriForResultsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation);

        [VtblIndex(13)]
        HRESULT LaunchUriForResultsWithDataForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperation<LaunchQuerySupportStatus>**, int> QueryAppUriSupportAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, HSTRING, IAsyncOperation<LaunchQuerySupportStatus>**, int> QueryAppUriSupportWithPackageFamilyNameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int> FindAppUriHandlersAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IUriRuntimeClass*, IAsyncOperation<LaunchUriStatus>**, int> LaunchUriForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<LaunchUriStatus>**, int> LaunchUriWithOptionsForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<LaunchUriStatus>**, int> LaunchUriWithDataForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int> LaunchUriForResultsForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int> LaunchUriForResultsWithDataForUserAsync;
    }
}
