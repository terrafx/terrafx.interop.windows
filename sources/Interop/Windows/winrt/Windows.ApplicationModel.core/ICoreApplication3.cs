// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEEC0D39-598B-4507-8A67-772632580A57")]
    [NativeTypeName("struct ICoreApplication3 : IInspectable")]
    public unsafe partial struct ICoreApplication3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreApplication3*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplication3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreApplication3*, uint>)(lpVtbl[1]))((ICoreApplication3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreApplication3*, uint>)(lpVtbl[2]))((ICoreApplication3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreApplication3*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplication3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreApplication3*, IntPtr*, int>)(lpVtbl[4]))((ICoreApplication3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreApplication3*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplication3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestRestartAsync([NativeTypeName("HSTRING")] IntPtr launchArguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **")] IAsyncOperation<AppRestartFailureReason>** operation)
        {
            return ((delegate* unmanaged<ICoreApplication3*, IntPtr, IAsyncOperation<AppRestartFailureReason>**, int>)(lpVtbl[6]))((ICoreApplication3*)Unsafe.AsPointer(ref this), launchArguments, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestRestartForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr launchArguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **")] IAsyncOperation<AppRestartFailureReason>** operation)
        {
            return ((delegate* unmanaged<ICoreApplication3*, IUser*, IntPtr, IAsyncOperation<AppRestartFailureReason>**, int>)(lpVtbl[7]))((ICoreApplication3*)Unsafe.AsPointer(ref this), user, launchArguments, operation);
        }
    }
}
