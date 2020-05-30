// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6027496E-CB3A-49AB-934F-D798DA4F7DA6")]
    public unsafe partial struct IDCompositionBrightnessEffect
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionBrightnessEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionBrightnessEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionBrightnessEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionBrightnessEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePoint(IDCompositionBrightnessEffect* pThis, [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlackPoint(IDCompositionBrightnessEffect* pThis, [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointX(IDCompositionBrightnessEffect* pThis, float whitePointX);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointX1(IDCompositionBrightnessEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointY(IDCompositionBrightnessEffect* pThis, float whitePointY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointY1(IDCompositionBrightnessEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlackPointX(IDCompositionBrightnessEffect* pThis, float blackPointX);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlackPointX1(IDCompositionBrightnessEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlackPointY(IDCompositionBrightnessEffect* pThis, float blackPointY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlackPointY1(IDCompositionBrightnessEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWhitePoint>(lpVtbl->SetWhitePoint)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlackPoint>(lpVtbl->SetBlackPoint)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX(float whitePointX)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWhitePointX>(lpVtbl->SetWhitePointX)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWhitePointX1>(lpVtbl->SetWhitePointX1)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY(float whitePointY)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWhitePointY>(lpVtbl->SetWhitePointY)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWhitePointY1>(lpVtbl->SetWhitePointY1)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX(float blackPointX)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlackPointX>(lpVtbl->SetBlackPointX)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlackPointX1>(lpVtbl->SetBlackPointX1)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY(float blackPointY)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlackPointY>(lpVtbl->SetBlackPointY)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlackPointY1>(lpVtbl->SetBlackPointY1)((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInput;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetWhitePoint;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlackPoint;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetWhitePointX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetWhitePointX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetWhitePointY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetWhitePointY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlackPointX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlackPointX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlackPointY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlackPointY1;
        }
    }
}
