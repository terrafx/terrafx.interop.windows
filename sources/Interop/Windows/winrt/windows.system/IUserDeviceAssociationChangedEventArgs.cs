// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BD1F6F6C-BB5D-4D7B-A5F0-C8CD11A38D42")]
    [NativeTypeName("struct IUserDeviceAssociationChangedEventArgs : IInspectable")]
    public unsafe partial struct IUserDeviceAssociationChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, uint>)(lpVtbl[1]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, uint>)(lpVtbl[2]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DeviceId([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, IntPtr*, int>)(lpVtbl[6]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NewUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, IUser**, int>)(lpVtbl[7]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OldUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationChangedEventArgs*, IUser**, int>)(lpVtbl[8]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
