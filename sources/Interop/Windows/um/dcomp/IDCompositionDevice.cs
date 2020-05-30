// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C37EA93A-E7AA-450D-B16F-9746CB0407F3")]
    public unsafe partial struct IDCompositionDevice
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionDevice* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IDCompositionDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitForCommitCompletion(IDCompositionDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDCompositionDevice* pThis, [NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTargetForHwnd(IDCompositionDevice* pThis, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int topmost, [NativeTypeName("IDCompositionTarget **")] IDCompositionTarget** target);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVisual(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionVisual **")] IDCompositionVisual** visual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurface(IDCompositionDevice* pThis, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVirtualSurface(IDCompositionDevice* pThis, [NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurfaceFromHandle(IDCompositionDevice* pThis, [NativeTypeName("HANDLE")] IntPtr handle, [NativeTypeName("IUnknown **")] IUnknown** surface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurfaceFromHwnd(IDCompositionDevice* pThis, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("IUnknown **")] IUnknown** surface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTranslateTransform(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateScaleTransform(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRotateTransform(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSkewTransform(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMatrixTransform(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformGroup(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTranslateTransform3D(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateScaleTransform3D(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRotateTransform3D(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMatrixTransform3D(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransform3DGroup(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEffectGroup(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRectangleClip(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAnimation(IDCompositionDevice* pThis, [NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckDeviceState(IDCompositionDevice* pThis, [NativeTypeName("BOOL *")] int* pfValid);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IDCompositionDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return Marshal.GetDelegateForFunctionPointer<_WaitForCommitCompletion>(lpVtbl->WaitForCommitCompletion)((IDCompositionDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)((IDCompositionDevice*)Unsafe.AsPointer(ref this), statistics);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTargetForHwnd([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int topmost, [NativeTypeName("IDCompositionTarget **")] IDCompositionTarget** target)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTargetForHwnd>(lpVtbl->CreateTargetForHwnd)((IDCompositionDevice*)Unsafe.AsPointer(ref this), hwnd, topmost, target);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVisual([NativeTypeName("IDCompositionVisual **")] IDCompositionVisual** visual)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVisual>(lpVtbl->CreateVisual)((IDCompositionDevice*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurface>(lpVtbl->CreateSurface)((IDCompositionDevice*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVirtualSurface>(lpVtbl->CreateVirtualSurface)((IDCompositionDevice*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHandle([NativeTypeName("HANDLE")] IntPtr handle, [NativeTypeName("IUnknown **")] IUnknown** surface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurfaceFromHandle>(lpVtbl->CreateSurfaceFromHandle)((IDCompositionDevice*)Unsafe.AsPointer(ref this), handle, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHwnd([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("IUnknown **")] IUnknown** surface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurfaceFromHwnd>(lpVtbl->CreateSurfaceFromHwnd)((IDCompositionDevice*)Unsafe.AsPointer(ref this), hwnd, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform([NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTranslateTransform>(lpVtbl->CreateTranslateTransform)((IDCompositionDevice*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform([NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateScaleTransform>(lpVtbl->CreateScaleTransform)((IDCompositionDevice*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform([NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRotateTransform>(lpVtbl->CreateRotateTransform)((IDCompositionDevice*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform([NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSkewTransform>(lpVtbl->CreateSkewTransform)((IDCompositionDevice*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform([NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMatrixTransform>(lpVtbl->CreateMatrixTransform)((IDCompositionDevice*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup([NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransformGroup>(lpVtbl->CreateTransformGroup)((IDCompositionDevice*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D([NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTranslateTransform3D>(lpVtbl->CreateTranslateTransform3D)((IDCompositionDevice*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D([NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateScaleTransform3D>(lpVtbl->CreateScaleTransform3D)((IDCompositionDevice*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D([NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRotateTransform3D>(lpVtbl->CreateRotateTransform3D)((IDCompositionDevice*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D([NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMatrixTransform3D>(lpVtbl->CreateMatrixTransform3D)((IDCompositionDevice*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup([NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransform3DGroup>(lpVtbl->CreateTransform3DGroup)((IDCompositionDevice*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup([NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEffectGroup>(lpVtbl->CreateEffectGroup)((IDCompositionDevice*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip([NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRectangleClip>(lpVtbl->CreateRectangleClip)((IDCompositionDevice*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateAnimation>(lpVtbl->CreateAnimation)((IDCompositionDevice*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceState([NativeTypeName("BOOL *")] int* pfValid)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckDeviceState>(lpVtbl->CheckDeviceState)((IDCompositionDevice*)Unsafe.AsPointer(ref this), pfValid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr WaitForCommitCompletion;

            [NativeTypeName("HRESULT (DCOMPOSITION_FRAME_STATISTICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFrameStatistics;

            [NativeTypeName("HRESULT (HWND, BOOL, IDCompositionTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTargetForHwnd;

            [NativeTypeName("HRESULT (IDCompositionVisual **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateVisual;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurface;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateVirtualSurface;

            [NativeTypeName("HRESULT (HANDLE, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurfaceFromHandle;

            [NativeTypeName("HRESULT (HWND, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurfaceFromHwnd;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTranslateTransform;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateScaleTransform;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRotateTransform;

            [NativeTypeName("HRESULT (IDCompositionSkewTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSkewTransform;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMatrixTransform;

            [NativeTypeName("HRESULT (IDCompositionTransform **, UINT, IDCompositionTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransformGroup;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTranslateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateScaleTransform3D;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRotateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMatrixTransform3D;

            [NativeTypeName("HRESULT (IDCompositionTransform3D **, UINT, IDCompositionTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransform3DGroup;

            [NativeTypeName("HRESULT (IDCompositionEffectGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateEffectGroup;

            [NativeTypeName("HRESULT (IDCompositionRectangleClip **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRectangleClip;

            [NativeTypeName("HRESULT (IDCompositionAnimation **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateAnimation;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CheckDeviceState;
        }
    }
}
