// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("95C75A6E-3E8C-4EC2-85A8-AEBCC551E59B")]
    [NativeTypeName("struct IWICDevelopRawNotificationCallback : IUnknown")]
    public unsafe partial struct IWICDevelopRawNotificationCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, Guid*, void**, int>)(lpVtbl[0]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint>)(lpVtbl[1]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint>)(lpVtbl[2]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Notify([NativeTypeName("UINT")] uint NotificationMask)
        {
            return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint, int>)(lpVtbl[3]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this), NotificationMask);
        }
    }
}
