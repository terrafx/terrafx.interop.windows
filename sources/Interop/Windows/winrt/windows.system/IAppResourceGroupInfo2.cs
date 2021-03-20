// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EE9B236D-D305-4D6B-92F7-6AFDAD72DEDC")]
    [NativeTypeName("struct IAppResourceGroupInfo2 : IInspectable")]
    public unsafe partial struct IAppResourceGroupInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, uint>)(lpVtbl[1]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, uint>)(lpVtbl[2]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, IntPtr*, int>)(lpVtbl[4]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartSuspendAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartResumeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartTerminateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo2*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
