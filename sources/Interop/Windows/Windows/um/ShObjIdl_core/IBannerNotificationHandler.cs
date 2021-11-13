// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("8D7B2BA7-DB05-46A8-823C-D2B6DE08EE91")]
    [NativeTypeName("struct IBannerNotificationHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBannerNotificationHandler : IBannerNotificationHandler.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBannerNotificationHandler*, Guid*, void**, int>)(lpVtbl[0]))((IBannerNotificationHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBannerNotificationHandler*, uint>)(lpVtbl[1]))((IBannerNotificationHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBannerNotificationHandler*, uint>)(lpVtbl[2]))((IBannerNotificationHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnBannerEvent([NativeTypeName("const BANNER_NOTIFICATION *")] BANNER_NOTIFICATION* notification)
        {
            return ((delegate* unmanaged<IBannerNotificationHandler*, BANNER_NOTIFICATION*, int>)(lpVtbl[3]))((IBannerNotificationHandler*)Unsafe.AsPointer(ref this), notification);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnBannerEvent([NativeTypeName("const BANNER_NOTIFICATION *")] BANNER_NOTIFICATION* notification);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBannerNotificationHandler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBannerNotificationHandler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBannerNotificationHandler*, uint> Release;

            [NativeTypeName("HRESULT (const BANNER_NOTIFICATION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBannerNotificationHandler*, BANNER_NOTIFICATION*, int> OnBannerEvent;
        }
    }
}
