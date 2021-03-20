// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("155EB23B-242A-45E0-A2E9-3171FC6A7FDD")]
    [NativeTypeName("struct IUserStatics : IInspectable")]
    public unsafe partial struct IUserStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserStatics*, uint>)(lpVtbl[1]))((IUserStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserStatics*, uint>)(lpVtbl[2]))((IUserStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserStatics*, IntPtr*, int>)(lpVtbl[4]))((IUserStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWatcher([NativeTypeName("ABI::Windows::System::IUserWatcher **")] IUserWatcher** result)
        {
            return ((delegate* unmanaged<IUserStatics*, IUserWatcher**, int>)(lpVtbl[6]))((IUserStatics*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IUserStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IUserStatics*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindAllAsyncByType([NativeTypeName("ABI::Windows::System::UserType")] UserType type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IUserStatics*, UserType, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IUserStatics*)Unsafe.AsPointer(ref this), type, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindAllAsyncByTypeAndStatus([NativeTypeName("ABI::Windows::System::UserType")] UserType type, [NativeTypeName("ABI::Windows::System::UserAuthenticationStatus")] UserAuthenticationStatus status, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IUserStatics*, UserType, UserAuthenticationStatus, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IUserStatics*)Unsafe.AsPointer(ref this), type, status, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFromId([NativeTypeName("HSTRING")] IntPtr nonRoamableId, [NativeTypeName("ABI::Windows::System::IUser **")] IUser** result)
        {
            return ((delegate* unmanaged<IUserStatics*, IntPtr, IUser**, int>)(lpVtbl[10]))((IUserStatics*)Unsafe.AsPointer(ref this), nonRoamableId, result);
        }
    }
}
