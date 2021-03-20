// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE6925BF-10CA-40C8-A9CA-C5C96501866E")]
    [NativeTypeName("struct IAppDiagnosticInfoStatics : IInspectable")]
    public unsafe partial struct IAppDiagnosticInfoStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics*, uint>)(lpVtbl[1]))((IAppDiagnosticInfoStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics*, uint>)(lpVtbl[2]))((IAppDiagnosticInfoStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics*, IntPtr*, int>)(lpVtbl[4]))((IAppDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestInfoAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IAppDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
