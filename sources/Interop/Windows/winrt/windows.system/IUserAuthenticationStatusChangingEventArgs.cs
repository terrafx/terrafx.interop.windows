// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8C030F28-A711-4C1E-AB48-04179C15938F")]
    [NativeTypeName("struct IUserAuthenticationStatusChangingEventArgs : IInspectable")]
    public unsafe partial struct IUserAuthenticationStatusChangingEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, uint>)(lpVtbl[1]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, uint>)(lpVtbl[2]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeferral([NativeTypeName("ABI::Windows::System::IUserAuthenticationStatusChangeDeferral **")] IUserAuthenticationStatusChangeDeferral** result)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, IUserAuthenticationStatusChangeDeferral**, int>)(lpVtbl[6]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, IUser**, int>)(lpVtbl[7]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NewStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, UserAuthenticationStatus*, int>)(lpVtbl[8]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangingEventArgs*, UserAuthenticationStatus*, int>)(lpVtbl[9]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
