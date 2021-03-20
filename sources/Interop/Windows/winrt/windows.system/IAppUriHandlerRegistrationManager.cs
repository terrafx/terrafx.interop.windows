// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E62C9A52-AC94-5750-AC1B-6CFB6F250263")]
    [NativeTypeName("struct IAppUriHandlerRegistrationManager : IInspectable")]
    public unsafe partial struct IAppUriHandlerRegistrationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, uint>)(lpVtbl[1]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, uint>)(lpVtbl[2]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, IntPtr*, int>)(lpVtbl[4]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, IUser**, int>)(lpVtbl[6]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryGetRegistration([NativeTypeName("HSTRING")] IntPtr name, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistration **")] IAppUriHandlerRegistration** result)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistrationManager*, IntPtr, IAppUriHandlerRegistration**, int>)(lpVtbl[7]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), name, result);
        }
    }
}
