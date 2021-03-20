// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7E491E14-F85A-4C07-8DA9-7FE3D0542343")]
    [NativeTypeName("struct IUserDeviceAssociationStatics : IInspectable")]
    public unsafe partial struct IUserDeviceAssociationStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, uint>)(lpVtbl[1]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, uint>)(lpVtbl[2]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, IntPtr*, int>)(lpVtbl[4]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindUserFromDeviceId([NativeTypeName("HSTRING")] IntPtr deviceId, [NativeTypeName("ABI::Windows::System::IUser **")] IUser** user)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, IntPtr, IUser**, int>)(lpVtbl[6]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), deviceId, user);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_UserDeviceAssociationChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CUserDeviceAssociationChangedEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_UserDeviceAssociationChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IUserDeviceAssociationStatics*, EventRegistrationToken, int>)(lpVtbl[8]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), token);
        }
    }
}
