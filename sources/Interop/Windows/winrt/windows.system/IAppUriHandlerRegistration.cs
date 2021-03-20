// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6F73AEB1-4569-5C3F-9BA0-99123EEA32C3")]
    [NativeTypeName("struct IAppUriHandlerRegistration : IInspectable")]
    public unsafe partial struct IAppUriHandlerRegistration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, uint>)(lpVtbl[1]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, uint>)(lpVtbl[2]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, IntPtr*, int>)(lpVtbl[4]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, IntPtr*, int>)(lpVtbl[6]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, IUser**, int>)(lpVtbl[7]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppAddedHostsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppUriHandlerHost_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppAddedHostsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CAppUriHandlerHost_t *")] IIterable<IntPtr>* hosts, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IAppUriHandlerRegistration*, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[9]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), hosts, operation);
        }
    }
}
