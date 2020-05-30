// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB8A4953-2C99-4F5A-96F5-4819027FA3AC")]
    public unsafe partial struct IDCompositionSurface
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionSurface* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginDraw(IDCompositionSurface* pThis, [NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EndDraw(IDCompositionSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SuspendDraw(IDCompositionSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResumeDraw(IDCompositionSurface* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Scroll(IDCompositionSurface* pThis, [NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset)
        {
            return Marshal.GetDelegateForFunctionPointer<_BeginDraw>(lpVtbl->BeginDraw)((IDCompositionSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_EndDraw>(lpVtbl->EndDraw)((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_SuspendDraw>(lpVtbl->SuspendDraw)((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_ResumeDraw>(lpVtbl->ResumeDraw)((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return Marshal.GetDelegateForFunctionPointer<_Scroll>(lpVtbl->Scroll)((IDCompositionSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
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
        }
    }
}
