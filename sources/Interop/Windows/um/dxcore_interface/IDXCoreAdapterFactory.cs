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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapterList)
        {
            return lpVtbl->CreateAdapterList((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), numAttributes, filterAttributes, riid, ppvAdapterList);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return lpVtbl->GetAdapterByLuid((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), adapterLUID, riid, ppvAdapter);
        }

        public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType)
        {
            return lpVtbl->IsNotificationTypeSupported((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), notificationType) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEventNotification([NativeTypeName("IUnknown *")] IUnknown* dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* stdcall<DXCoreNotificationType, IUnknown*, void*, void> callbackFunction, [NativeTypeName("void *")] void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie)
        {
            return lpVtbl->RegisterEventNotification((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie)
        {
            return lpVtbl->UnregisterEventNotification((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), eventCookie);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, uint> Release;

            [NativeTypeName("HRESULT (uint32_t, const GUID *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, uint, Guid*, Guid*, void**, int> CreateAdapterList;

            [NativeTypeName("HRESULT (const LUID &, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, LUID*, Guid*, void**, int> GetAdapterByLuid;

            [NativeTypeName("bool (DXCoreNotificationType) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, DXCoreNotificationType, byte> IsNotificationTypeSupported;

            [NativeTypeName("HRESULT (IUnknown *, DXCoreNotificationType, PFN_DXCORE_NOTIFICATION_CALLBACK, void *, uint32_t *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, IUnknown*, DXCoreNotificationType, delegate* stdcall<DXCoreNotificationType, IUnknown*, void*, void>, void*, uint*, int> RegisterEventNotification;

            [NativeTypeName("HRESULT (uint32_t) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterFactory*, uint, int> UnregisterEventNotification;
        }
    }
}
