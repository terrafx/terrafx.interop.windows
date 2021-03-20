// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C895C63D-DD61-4C65-BABD-81A10B4F9815")]
    [NativeTypeName("struct IAppDiagnosticInfo3 : IInspectable")]
    public unsafe partial struct IAppDiagnosticInfo3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo3*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo3*, uint>)(lpVtbl[1]))((IAppDiagnosticInfo3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo3*, uint>)(lpVtbl[2]))((IAppDiagnosticInfo3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo3*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfo3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo3*, IntPtr*, int>)(lpVtbl[4]))((IAppDiagnosticInfo3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo3*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfo3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppActivationResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo3*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IAppDiagnosticInfo3*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
