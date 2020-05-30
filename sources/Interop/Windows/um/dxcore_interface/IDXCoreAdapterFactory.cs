// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("78EE5945-C36E-4B13-A669-005DD11C0F06")]
    public unsafe partial struct IDXCoreAdapterFactory
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXCoreAdapterFactory* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXCoreAdapterFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXCoreAdapterFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAdapterList(IDXCoreAdapterFactory* pThis, [NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapterList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAdapterByLuid(IDXCoreAdapterFactory* pThis, [NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsNotificationTypeSupported(IDXCoreAdapterFactory* pThis, DXCoreNotificationType notificationType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterEventNotification(IDXCoreAdapterFactory* pThis, [NativeTypeName("IUnknown *")] IUnknown* dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] IntPtr callbackFunction, [NativeTypeName("void *")] void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterEventNotification(IDXCoreAdapterFactory* pThis, [NativeTypeName("uint32_t")] uint eventCookie);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapterList)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateAdapterList>(lpVtbl->CreateAdapterList)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), numAttributes, filterAttributes, riid, ppvAdapterList);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAdapterByLuid>(lpVtbl->GetAdapterByLuid)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), adapterLUID, riid, ppvAdapter);
        }

        public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsNotificationTypeSupported>(lpVtbl->IsNotificationTypeSupported)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), notificationType) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEventNotification([NativeTypeName("IUnknown *")] IUnknown* dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] IntPtr callbackFunction, [NativeTypeName("void *")] void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterEventNotification>(lpVtbl->RegisterEventNotification)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterEventNotification>(lpVtbl->UnregisterEventNotification)((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), eventCookie);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (uint32_t, const GUID *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateAdapterList;

            [NativeTypeName("HRESULT (const LUID &, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetAdapterByLuid;

            [NativeTypeName("bool (DXCoreNotificationType) __attribute__((stdcall))")]
            public IntPtr IsNotificationTypeSupported;

            [NativeTypeName("HRESULT (IUnknown *, DXCoreNotificationType, PFN_DXCORE_NOTIFICATION_CALLBACK, void *, uint32_t *) __attribute__((stdcall))")]
            public IntPtr RegisterEventNotification;

            [NativeTypeName("HRESULT (uint32_t) __attribute__((stdcall))")]
            public IntPtr UnregisterEventNotification;
        }
    }
}
