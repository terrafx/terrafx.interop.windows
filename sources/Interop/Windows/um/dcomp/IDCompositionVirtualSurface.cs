// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE471C51-5F53-4A24-8D3E-D0C39C30B3F0")]
    public unsafe partial struct IDCompositionVirtualSurface
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionVirtualSurface* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionVirtualSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionVirtualSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginDraw(IDCompositionVirtualSurface* pThis, [NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EndDraw(IDCompositionVirtualSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SuspendDraw(IDCompositionVirtualSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResumeDraw(IDCompositionVirtualSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Scroll(IDCompositionVirtualSurface* pThis, [NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Resize(IDCompositionVirtualSurface* pThis, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Trim(IDCompositionVirtualSurface* pThis, [NativeTypeName("const RECT *")] RECT* rectangles, [NativeTypeName("UINT")] uint count);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset)
        {
            return Marshal.GetDelegateForFunctionPointer<_BeginDraw>(lpVtbl->BeginDraw)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_EndDraw>(lpVtbl->EndDraw)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_SuspendDraw>(lpVtbl->SuspendDraw)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_ResumeDraw>(lpVtbl->ResumeDraw)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return Marshal.GetDelegateForFunctionPointer<_Scroll>(lpVtbl->Scroll)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height)
        {
            return Marshal.GetDelegateForFunctionPointer<_Resize>(lpVtbl->Resize)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), width, height);
        }

        [return: NativeTypeName("HRESULT")]
        public int Trim([NativeTypeName("const RECT *")] RECT* rectangles, [NativeTypeName("UINT")] uint count)
        {
            return Marshal.GetDelegateForFunctionPointer<_Trim>(lpVtbl->Trim)((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), rectangles, count);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const RECT *, const IID &, void **, POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BeginDraw;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EndDraw;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SuspendDraw;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ResumeDraw;

            [NativeTypeName("HRESULT (const RECT *, const RECT *, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Scroll;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Resize;

            [NativeTypeName("HRESULT (const RECT *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Trim;
        }
    }
}
