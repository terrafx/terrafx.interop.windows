// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64C1024E-C3CF-4462-8078-88C2B11C46D9")]
    public unsafe partial struct IWICBitmapCodecProgressNotification
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapCodecProgressNotification* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapCodecProgressNotification* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapCodecProgressNotification* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterProgressNotification(IWICBitmapCodecProgressNotification* pThis, [NativeTypeName("PFNProgressNotification")] IntPtr pfnProgressNotification, [NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterProgressNotification([NativeTypeName("PFNProgressNotification")] IntPtr pfnProgressNotification, [NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterProgressNotification>(lpVtbl->RegisterProgressNotification)((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this), pfnProgressNotification, pvData, dwProgressFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (PFNProgressNotification, LPVOID, DWORD) __attribute__((stdcall))")]
            public IntPtr RegisterProgressNotification;
        }
    }
}
