// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64C1024E-C3CF-4462-8078-88C2B11C46D9")]
    public unsafe partial struct IWICBitmapCodecProgressNotification
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapCodecProgressNotification* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapCodecProgressNotification* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapCodecProgressNotification* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterProgressNotification(IWICBitmapCodecProgressNotification* This, [Optional] PFNProgressNotification pfnProgressNotification, [Optional, NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmapCodecProgressNotification* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapCodecProgressNotification* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapCodecProgressNotification* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterProgressNotification([Optional] PFNProgressNotification pfnProgressNotification, [Optional, NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags)
        {
            fixed (IWICBitmapCodecProgressNotification* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterProgressNotification>(lpVtbl->RegisterProgressNotification)(This, pfnProgressNotification, pvData, dwProgressFlags);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr RegisterProgressNotification;
        }
    }
}
