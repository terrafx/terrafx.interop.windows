// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D548008-F1E3-4A6C-8DDC-A9BB0F488AED")]
    [NativeTypeName("struct IUserPicker : IInspectable")]
    public unsafe partial struct IUserPicker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserPicker*, Guid*, void**, int>)(lpVtbl[0]))((IUserPicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserPicker*, uint>)(lpVtbl[1]))((IUserPicker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserPicker*, uint>)(lpVtbl[2]))((IUserPicker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserPicker*, uint*, Guid**, int>)(lpVtbl[3]))((IUserPicker*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserPicker*, IntPtr*, int>)(lpVtbl[4]))((IUserPicker*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserPicker*, TrustLevel*, int>)(lpVtbl[5]))((IUserPicker*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AllowGuestAccounts([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IUserPicker*, byte*, int>)(lpVtbl[6]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AllowGuestAccounts([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IUserPicker*, byte, int>)(lpVtbl[7]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SuggestedSelectedUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
        {
            return ((delegate* unmanaged<IUserPicker*, IUser**, int>)(lpVtbl[8]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SuggestedSelectedUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* value)
        {
            return ((delegate* unmanaged<IUserPicker*, IUser*, int>)(lpVtbl[9]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PickSingleUserAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IUserPicker*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IUserPicker*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
