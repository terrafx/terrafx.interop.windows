// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B9EC819F-B5A5-41C6-B3B3-DD1B3178BCF2")]
    [NativeTypeName("struct ILauncherStatics4 : IInspectable")]
    public unsafe partial struct ILauncherStatics4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherStatics4*, uint>)(lpVtbl[1]))((ILauncherStatics4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherStatics4*, uint>)(lpVtbl[2]))((ILauncherStatics4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IntPtr*, int>)(lpVtbl[4]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryAppUriSupportAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUriRuntimeClass*, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[6]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), uri, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryAppUriSupportWithPackageFamilyNameAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("HSTRING")] IntPtr packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **")] IAsyncOperation<LaunchQuerySupportStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUriRuntimeClass*, IntPtr, IAsyncOperation<LaunchQuerySupportStatus>**, int>)(lpVtbl[7]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), uri, packageFamilyName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindAppUriHandlersAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUriRuntimeClass*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), uri, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUser*, IUriRuntimeClass*, IAsyncOperation<LaunchUriStatus>**, int>)(lpVtbl[9]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriWithOptionsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<LaunchUriStatus>**, int>)(lpVtbl[10]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriWithDataForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **")] IAsyncOperation<LaunchUriStatus>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<LaunchUriStatus>**, int>)(lpVtbl[11]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, inputData, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriForResultsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriForResultsWithDataForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics4*, IUser*, IUriRuntimeClass*, ILauncherOptions*, IPropertySet*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((ILauncherStatics4*)Unsafe.AsPointer(ref this), user, uri, options, inputData, operation);
        }
    }
}
