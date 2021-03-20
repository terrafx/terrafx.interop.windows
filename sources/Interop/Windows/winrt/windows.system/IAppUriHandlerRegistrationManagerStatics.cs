// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5CEDD9F-5729-5B76-A1D4-0285F295C124")]
    [NativeTypeName("struct IAppUriHandlerRegistrationManagerStatics : IInspectable")]
    public unsafe partial struct IAppUriHandlerRegistrationManagerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, uint>)(lpVtbl[1]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, uint>)(lpVtbl[2]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, IntPtr*, int>)(lpVtbl[4]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefault([NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistrationManager **")] IAppUriHandlerRegistrationManager** result)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, IAppUriHandlerRegistrationManager**, int>)(lpVtbl[6]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistrationManager **")] IAppUriHandlerRegistrationManager** result)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManagerStatics*, IUser*, IAppUriHandlerRegistrationManager**, int>)(lpVtbl[7]))((IAppUriHandlerRegistrationManagerStatics*)Unsafe.AsPointer(ref this), user, result);
        }
    }
}
