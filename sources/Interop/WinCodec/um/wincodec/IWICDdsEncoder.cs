// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
    public unsafe partial struct IWICDdsEncoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICDdsEncoder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICDdsEncoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICDdsEncoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParameters(IWICDdsEncoder* pThis, [NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParameters(IWICDdsEncoder* pThis, [NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateNewFrame(IWICDdsEncoder* pThis, [NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("UINT *")] uint* pArrayIndex, [NativeTypeName("UINT *")] uint* pMipLevel, [NativeTypeName("UINT *")] uint* pSliceIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICDdsEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetParameters>(lpVtbl->SetParameters)((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParameters>(lpVtbl->GetParameters)((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame([NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("UINT *")] uint* pArrayIndex, [NativeTypeName("UINT *")] uint* pMipLevel, [NativeTypeName("UINT *")] uint* pSliceIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateNewFrame>(lpVtbl->CreateNewFrame)((IWICDdsEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public IntPtr SetParameters;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public IntPtr GetParameters;

            [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr CreateNewFrame;
        }
    }
}
