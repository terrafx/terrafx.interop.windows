// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2"]/*' />
[Guid("59BA2FBB-24CB-4C02-A4C4-8294569D54F1")]
[NativeTypeName("struct ILauncherStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherStatics2 : ILauncherStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILauncherStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, uint>)(lpVtbl[1]))((ILauncherStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, uint>)(lpVtbl[2]))((ILauncherStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, HSTRING*, int>)(lpVtbl[4]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.LaunchUriForResultsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchUriForResultsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int>)(lpVtbl[6]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, options, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.LaunchUriForResultsWithDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchUriForResultsWithDataAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int>)(lpVtbl[7]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, options, inputData, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.LaunchUriWithDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchUriWithDataAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, options, inputData, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.QueryUriSupportAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryUriSupportAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, IUriRuntimeClass*, LaunchQuerySupportType, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[9]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, launchQuerySupportType, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.QueryUriSupportWithPackageFamilyNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT QueryUriSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, IUriRuntimeClass*, LaunchQuerySupportType, HSTRING, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[10]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, launchQuerySupportType, packageFamilyName, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.QueryFileSupportAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT QueryFileSupportAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, IStorageFile*, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[11]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), file, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.QueryFileSupportWithPackageFamilyNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT QueryFileSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, IStorageFile*, HSTRING, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[12]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), file, packageFamilyName, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.FindUriSchemeHandlersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT FindUriSchemeHandlersAsync(HSTRING scheme, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int>)(lpVtbl[13]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), scheme, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.FindUriSchemeHandlersWithLaunchUriTypeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT FindUriSchemeHandlersWithLaunchUriTypeAsync(HSTRING scheme, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, HSTRING, LaunchQuerySupportType, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int>)(lpVtbl[14]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), scheme, launchQuerySupportType, operation);
    }

    /// <include file='ILauncherStatics2.xml' path='doc/member[@name="ILauncherStatics2.FindFileHandlersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT FindFileHandlersAsync(HSTRING extension, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics2*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int>)(lpVtbl[15]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), extension, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchUriForResultsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation);

        [VtblIndex(7)]
        HRESULT LaunchUriForResultsWithDataAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<Pointer<ILaunchUriResult>>** operation);

        [VtblIndex(8)]
        HRESULT LaunchUriWithDataAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT QueryUriSupportAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation);

        [VtblIndex(10)]
        HRESULT QueryUriSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation);

        [VtblIndex(11)]
        HRESULT QueryFileSupportAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation);

        [VtblIndex(12)]
        HRESULT QueryFileSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation);

        [VtblIndex(13)]
        HRESULT FindUriSchemeHandlersAsync(HSTRING scheme, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation);

        [VtblIndex(14)]
        HRESULT FindUriSchemeHandlersWithLaunchUriTypeAsync(HSTRING scheme, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation);

        [VtblIndex(15)]
        HRESULT FindFileHandlersAsync(HSTRING extension, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int> LaunchUriForResultsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<Pointer<ILaunchUriResult>>**, int> LaunchUriForResultsWithDataAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<bool>**, int> LaunchUriWithDataAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::LaunchQuerySupportType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, LaunchQuerySupportType, IAsyncOperation<LaunchQuerySupportStatus>**, int> QueryUriSupportAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::LaunchQuerySupportType, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, LaunchQuerySupportType, HSTRING, IAsyncOperation<LaunchQuerySupportStatus>**, int> QueryUriSupportWithPackageFamilyNameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<LaunchQuerySupportStatus>**, int> QueryFileSupportAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING, IAsyncOperation<LaunchQuerySupportStatus>**, int> QueryFileSupportWithPackageFamilyNameAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int> FindUriSchemeHandlersAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::LaunchQuerySupportType, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, LaunchQuerySupportType, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int> FindUriSchemeHandlersWithLaunchUriTypeAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IAppInfo>>>>**, int> FindFileHandlersAsync;
    }
}
