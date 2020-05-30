// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2775F462-B6C1-4015-B0BE-B3E7D6A4976D")]
    public unsafe partial struct IDCompositionVisual3
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionVisual3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionVisual3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionVisual3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOffsetX(IDCompositionVisual3* pThis, float offsetX);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOffsetX1(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOffsetY(IDCompositionVisual3* pThis, float offsetY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOffsetY1(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransform(IDCompositionVisual3* pThis, [NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransform1(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionTransform *")] IDCompositionTransform* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransformParent(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEffect(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionEffect *")] IDCompositionEffect* effect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBitmapInterpolationMode(IDCompositionVisual3* pThis, DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBorderMode(IDCompositionVisual3* pThis, DCOMPOSITION_BORDER_MODE borderMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClip(IDCompositionVisual3* pThis, [NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClip1(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionClip *")] IDCompositionClip* clip);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetContent(IDCompositionVisual3* pThis, [NativeTypeName("IUnknown *")] IUnknown* content);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddVisual(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("BOOL")] int insertAbove, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* referenceVisual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveVisual(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveAllVisuals(IDCompositionVisual3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCompositeMode(IDCompositionVisual3* pThis, DCOMPOSITION_COMPOSITE_MODE compositeMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOpacityMode(IDCompositionVisual3* pThis, DCOMPOSITION_OPACITY_MODE mode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBackFaceVisibility(IDCompositionVisual3* pThis, DCOMPOSITION_BACKFACE_VISIBILITY visibility);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnableHeatMap(IDCompositionVisual3* pThis, [NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DisableHeatMap(IDCompositionVisual3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnableRedrawRegions(IDCompositionVisual3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DisableRedrawRegions(IDCompositionVisual3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDepthMode(IDCompositionVisual3* pThis, DCOMPOSITION_DEPTH_MODE mode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOffsetZ(IDCompositionVisual3* pThis, float offsetZ);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOffsetZ1(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOpacity(IDCompositionVisual3* pThis, float opacity);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOpacity1(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransform2(IDCompositionVisual3* pThis, [NativeTypeName("const D2D_MATRIX_4X4_F &")] D2D_MATRIX_4X4_F* matrix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransform3(IDCompositionVisual3* pThis, [NativeTypeName("IDCompositionTransform3D *")] IDCompositionTransform3D* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVisible(IDCompositionVisual3* pThis, [NativeTypeName("BOOL")] int visible);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOffsetX>(lpVtbl->SetOffsetX)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOffsetX1>(lpVtbl->SetOffsetX1)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOffsetY>(lpVtbl->SetOffsetY)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOffsetY1>(lpVtbl->SetOffsetY1)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform *")] IDCompositionTransform* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransform1>(lpVtbl->SetTransform1)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformParent([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransformParent>(lpVtbl->SetTransformParent)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffect([NativeTypeName("IDCompositionEffect *")] IDCompositionEffect* effect)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetEffect>(lpVtbl->SetEffect)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), effect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBitmapInterpolationMode>(lpVtbl->SetBitmapInterpolationMode)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBorderMode>(lpVtbl->SetBorderMode)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), borderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClip>(lpVtbl->SetClip)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), rect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("IDCompositionClip *")] IDCompositionClip* clip)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClip1>(lpVtbl->SetClip1)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContent([NativeTypeName("IUnknown *")] IUnknown* content)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetContent>(lpVtbl->SetContent)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), content);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("BOOL")] int insertAbove, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* referenceVisual)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddVisual>(lpVtbl->AddVisual)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveVisual>(lpVtbl->RemoveVisual)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllVisuals()
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveAllVisuals>(lpVtbl->RemoveAllVisuals)((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCompositeMode>(lpVtbl->SetCompositeMode)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), compositeMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOpacityMode>(lpVtbl->SetOpacityMode)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBackFaceVisibility>(lpVtbl->SetBackFaceVisibility)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visibility);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnableHeatMap>(lpVtbl->EnableHeatMap)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableHeatMap()
        {
            return Marshal.GetDelegateForFunctionPointer<_DisableHeatMap>(lpVtbl->DisableHeatMap)((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableRedrawRegions()
        {
            return Marshal.GetDelegateForFunctionPointer<_EnableRedrawRegions>(lpVtbl->EnableRedrawRegions)((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableRedrawRegions()
        {
            return Marshal.GetDelegateForFunctionPointer<_DisableRedrawRegions>(lpVtbl->DisableRedrawRegions)((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDepthMode(DCOMPOSITION_DEPTH_MODE mode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDepthMode>(lpVtbl->SetDepthMode)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(float offsetZ)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOffsetZ>(lpVtbl->SetOffsetZ)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOffsetZ1>(lpVtbl->SetOffsetZ1)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacity(float opacity)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), opacity);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpacity([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOpacity1>(lpVtbl->SetOpacity1)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_4X4_F &")] D2D_MATRIX_4X4_F* matrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransform2>(lpVtbl->SetTransform2)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform3D *")] IDCompositionTransform3D* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransform3>(lpVtbl->SetTransform3)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVisible([NativeTypeName("BOOL")] int visible)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVisible>(lpVtbl->SetVisible)((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visible);
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
            public IntPtr SetOffsetX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOffsetX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOffsetY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOffsetY1;

            [NativeTypeName("HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransform;

            [NativeTypeName("HRESULT (IDCompositionTransform *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransform1;

            [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransformParent;

            [NativeTypeName("HRESULT (IDCompositionEffect *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetEffect;

            [NativeTypeName("HRESULT (DCOMPOSITION_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBitmapInterpolationMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBorderMode;

            [NativeTypeName("HRESULT (const D2D_RECT_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetClip;

            [NativeTypeName("HRESULT (IDCompositionClip *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetClip1;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetContent;

            [NativeTypeName("HRESULT (IDCompositionVisual *, BOOL, IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddVisual;

            [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveVisual;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveAllVisuals;

            [NativeTypeName("HRESULT (DCOMPOSITION_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCompositeMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_OPACITY_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOpacityMode;

            [NativeTypeName("HRESULT (DCOMPOSITION_BACKFACE_VISIBILITY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBackFaceVisibility;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnableHeatMap;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DisableHeatMap;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnableRedrawRegions;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DisableRedrawRegions;

            [NativeTypeName("HRESULT (DCOMPOSITION_DEPTH_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDepthMode;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOffsetZ;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOffsetZ1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOpacity;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOpacity1;

            [NativeTypeName("HRESULT (const D2D_MATRIX_4X4_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransform2;

            [NativeTypeName("HRESULT (IDCompositionTransform3D *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransform3;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetVisible;
        }
    }
}
