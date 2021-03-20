// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("05B24B86-1000-4C90-BB9F-7235071C50FE")]
    [NativeTypeName("struct IAppDiagnosticInfoStatics2 : IInspectable")]
    public unsafe partial struct IAppDiagnosticInfoStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, uint>)(lpVtbl[1]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, uint>)(lpVtbl[2]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, IntPtr*, int>)(lpVtbl[4]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWatcher([NativeTypeName("ABI::Windows::System::IAppDiagnosticInfoWatcher **")] IAppDiagnosticInfoWatcher** watcher)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, IAppDiagnosticInfoWatcher**, int>)(lpVtbl[6]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), watcher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CDiagnosticAccessStatus_t **")] IAsyncOperation<DiagnosticAccessStatus>** operation)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, IAsyncOperation<DiagnosticAccessStatus>**, int>)(lpVtbl[7]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestInfoForPackageAsync([NativeTypeName("HSTRING")] IntPtr packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), packageFamilyName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestInfoForAppAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestInfoForAppUserModelId([NativeTypeName("HSTRING")] IntPtr appUserModelId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics2*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), appUserModelId, operation);
        }
    }
}
