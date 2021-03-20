// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("33AB66E7-2D0E-448B-A6A0-C13C3836D09C")]
    [NativeTypeName("struct IProcessLauncherStatics : IInspectable")]
    public unsafe partial struct IProcessLauncherStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, Guid*, void**, int>)(lpVtbl[0]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, uint>)(lpVtbl[1]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, uint>)(lpVtbl[2]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, IntPtr*, int>)(lpVtbl[4]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, TrustLevel*, int>)(lpVtbl[5]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RunToCompletionAsync([NativeTypeName("HSTRING")] IntPtr fileName, [NativeTypeName("HSTRING")] IntPtr args, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **")] IAsyncOperation<IntPtr>** asyncOperationResult)
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, IntPtr, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), fileName, args, asyncOperationResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RunToCompletionAsyncWithOptions([NativeTypeName("HSTRING")] IntPtr fileName, [NativeTypeName("HSTRING")] IntPtr args, [NativeTypeName("ABI::Windows::System::IProcessLauncherOptions *")] IProcessLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **")] IAsyncOperation<IntPtr>** asyncOperationResult)
        {
            return ((delegate* unmanaged<IProcessLauncherStatics*, IntPtr, IntPtr, IProcessLauncherOptions*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), fileName, args, options, asyncOperationResult);
        }
    }
}
