// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("409CD537-8532-40CB-9774-E2FEB2DF4E9C")]
    public unsafe struct IWICDdsDecoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICDdsDecoder* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICDdsDecoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICDdsDecoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParameters(IWICDdsDecoder* This, WICDdsParameters* pParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrame(IWICDdsDecoder* This, [NativeTypeName("UINT")] uint arrayIndex, [NativeTypeName("UINT")] uint mipLevel, [NativeTypeName("UINT")] uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters(WICDdsParameters* pParameters)
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParameters>(lpVtbl->GetParameters)(This, pParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrame([NativeTypeName("UINT")] uint arrayIndex, [NativeTypeName("UINT")] uint mipLevel, [NativeTypeName("UINT")] uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame = null)
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrame>(lpVtbl->GetFrame)(This, arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetParameters;

            public IntPtr GetFrame;
        }
    }
}
