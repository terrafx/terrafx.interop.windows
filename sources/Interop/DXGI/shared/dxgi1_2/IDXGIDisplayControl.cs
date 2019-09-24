// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
    public unsafe struct IDXGIDisplayControl
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIDisplayControl* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIDisplayControl* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIDisplayControl* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsStereoEnabled(IDXGIDisplayControl* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetStereoEnabled(IDXGIDisplayControl* This, [NativeTypeName("BOOL")] int enabled);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIDisplayControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIDisplayControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDisplayControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsStereoEnabled()
        {
            fixed (IDXGIDisplayControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsStereoEnabled>(lpVtbl->IsStereoEnabled)(This);
            }
        }

        public void SetStereoEnabled([NativeTypeName("BOOL")] int enabled)
        {
            fixed (IDXGIDisplayControl* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetStereoEnabled>(lpVtbl->SetStereoEnabled)(This, enabled);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr IsStereoEnabled;

            public IntPtr SetStereoEnabled;
        }
    }
}