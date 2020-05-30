// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9842AD7D-D9CF-4908-AED7-48B51DA5E7C2")]
    public unsafe partial struct IDCompositionRectangleClip
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionRectangleClip* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionRectangleClip* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionRectangleClip* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLeft(IDCompositionRectangleClip* pThis, float left);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLeft1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTop(IDCompositionRectangleClip* pThis, float top);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTop1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRight(IDCompositionRectangleClip* pThis, float right);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRight1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottom(IDCompositionRectangleClip* pThis, float bottom);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottom1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopLeftRadiusX(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopLeftRadiusX1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopLeftRadiusY(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopLeftRadiusY1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopRightRadiusX(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopRightRadiusX1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopRightRadiusY(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTopRightRadiusY1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomLeftRadiusX(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomLeftRadiusX1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomLeftRadiusY(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomLeftRadiusY1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomRightRadiusX(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomRightRadiusX1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomRightRadiusY(IDCompositionRectangleClip* pThis, float radius);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBottomRightRadiusY1(IDCompositionRectangleClip* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLeft(float left)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLeft>(lpVtbl->SetLeft)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), left);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLeft([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLeft1>(lpVtbl->SetLeft1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTop(float top)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTop>(lpVtbl->SetTop)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), top);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTop([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTop1>(lpVtbl->SetTop1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRight(float right)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRight>(lpVtbl->SetRight)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), right);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRight([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRight1>(lpVtbl->SetRight1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottom(float bottom)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottom>(lpVtbl->SetBottom)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), bottom);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottom([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottom1>(lpVtbl->SetBottom1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusX(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopLeftRadiusX>(lpVtbl->SetTopLeftRadiusX)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopLeftRadiusX1>(lpVtbl->SetTopLeftRadiusX1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusY(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopLeftRadiusY>(lpVtbl->SetTopLeftRadiusY)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopLeftRadiusY1>(lpVtbl->SetTopLeftRadiusY1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusX(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopRightRadiusX>(lpVtbl->SetTopRightRadiusX)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopRightRadiusX1>(lpVtbl->SetTopRightRadiusX1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusY(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopRightRadiusY>(lpVtbl->SetTopRightRadiusY)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTopRightRadiusY1>(lpVtbl->SetTopRightRadiusY1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusX(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomLeftRadiusX>(lpVtbl->SetBottomLeftRadiusX)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomLeftRadiusX1>(lpVtbl->SetBottomLeftRadiusX1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusY(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomLeftRadiusY>(lpVtbl->SetBottomLeftRadiusY)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomLeftRadiusY1>(lpVtbl->SetBottomLeftRadiusY1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusX(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomRightRadiusX>(lpVtbl->SetBottomRightRadiusX)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomRightRadiusX1>(lpVtbl->SetBottomRightRadiusX1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusY(float radius)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomRightRadiusY>(lpVtbl->SetBottomRightRadiusY)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBottomRightRadiusY1>(lpVtbl->SetBottomRightRadiusY1)((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLeft;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLeft1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTop;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTop1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRight;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRight1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottom;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottom1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopLeftRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopLeftRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopLeftRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopLeftRadiusY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopRightRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopRightRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopRightRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTopRightRadiusY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomLeftRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomLeftRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomLeftRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomLeftRadiusY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomRightRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomRightRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomRightRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBottomRightRadiusY1;
        }
    }
}
