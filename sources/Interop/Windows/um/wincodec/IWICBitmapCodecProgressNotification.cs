// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64C1024E-C3CF-4462-8078-88C2B11C46D9")]
    [NativeTypeName("struct IWICBitmapCodecProgressNotification : IUnknown")]
    public unsafe partial struct IWICBitmapCodecProgressNotification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecProgressNotification*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecProgressNotification*, uint>)(lpVtbl[1]))((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecProgressNotification*, uint>)(lpVtbl[2]))((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public int RegisterProgressNotification([NativeTypeName("PFNProgressNotification")] delegate* unmanaged<void*, uint, WICProgressOperation, double, int> pfnProgressNotification, [NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags)
#else
        public int RegisterProgressNotification([NativeTypeName("PFNProgressNotification")] delegate* unmanaged[Stdcall]<void*, uint, WICProgressOperation, double, int> pfnProgressNotification, [NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags)
#endif
        {
#if !NETSTANDARD2_0
            return ((delegate* unmanaged<IWICBitmapCodecProgressNotification*, delegate* unmanaged<void*, uint, WICProgressOperation, double, int>, void*, uint, int>)(lpVtbl[3]))((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this), pfnProgressNotification, pvData, dwProgressFlags);
#else
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecProgressNotification*, delegate* unmanaged[Stdcall]<void*, uint, WICProgressOperation, double, int>, void*, uint, int>)(lpVtbl[3]))((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this), pfnProgressNotification, pvData, dwProgressFlags);
#endif
        }
    }
}
