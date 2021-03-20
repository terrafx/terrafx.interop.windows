// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59BA2FBB-24CB-4C02-A4C4-8294569D54F1")]
    [NativeTypeName("struct ILauncherStatics2 : IInspectable")]
    public unsafe partial struct ILauncherStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherStatics2*, uint>)(lpVtbl[1]))((ILauncherStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherStatics2*, uint>)(lpVtbl[2]))((ILauncherStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IntPtr*, int>)(lpVtbl[4]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriForResultsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriForResultsWithDataAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, options, inputData, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriWithDataAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<byte>**, int>)(lpVtbl[8]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, options, inputData, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryUriSupportAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IUriRuntimeClass*, LaunchQuerySupportType, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[9]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, launchQuerySupportType, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryUriSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, [NativeTypeName("HSTRING")] IntPtr packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IUriRuntimeClass*, LaunchQuerySupportType, IntPtr, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[10]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), uri, launchQuerySupportType, packageFamilyName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryFileSupportAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IInspectable* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IInspectable*, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[11]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), file, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryFileSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IInspectable* file, [NativeTypeName("HSTRING")] IntPtr packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IInspectable*, IntPtr, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[12]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), file, packageFamilyName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindUriSchemeHandlersAsync([NativeTypeName("HSTRING")] IntPtr scheme, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), scheme, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindUriSchemeHandlersWithLaunchUriTypeAsync([NativeTypeName("HSTRING")] IntPtr scheme, [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")] LaunchQuerySupportType launchQuerySupportType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IntPtr, LaunchQuerySupportType, IAsyncOperation<IntPtr>**, int>)(lpVtbl[14]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), scheme, launchQuerySupportType, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFileHandlersAsync([NativeTypeName("HSTRING")] IntPtr extension, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics2*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[15]))((ILauncherStatics2*)Unsafe.AsPointer(ref this), extension, operation);
        }
    }
}
