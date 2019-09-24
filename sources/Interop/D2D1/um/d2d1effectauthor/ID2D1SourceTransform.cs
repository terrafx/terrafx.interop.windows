// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by a transform author to provide a CPU based source effect.</summary>
    [Guid("DB1800DD-0C34-4CF9-BE90-31CC0A5653E1")]
    public unsafe struct ID2D1SourceTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SourceTransform* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SourceTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SourceTransform* This);

        /// <summary>Return the number of input this node has.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1SourceTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapOutputRectToInputRects(ID2D1SourceTransform* This, [NativeTypeName("D2D1_RECT_L")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapInputRectsToOutputRect(ID2D1SourceTransform* This, [NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects, [NativeTypeName("D2D1_RECT_L[]")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L")] RECT* outputOpaqueSubRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapInvalidRect(ID2D1SourceTransform* This, [NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L")] RECT* invalidOutputRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRenderInfo(ID2D1SourceTransform* This, ID2D1RenderInfo* renderInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Draw(ID2D1SourceTransform* This, ID2D1Bitmap1* target, [NativeTypeName("D2D1_RECT_L")] RECT* drawRect, [NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U targetOrigin);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MapOutputRectToInputRects([NativeTypeName("D2D1_RECT_L")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MapOutputRectToInputRects>(lpVtbl->MapOutputRectToInputRects)(This, outputRect, inputRects, inputRectsCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInputRectsToOutputRect([NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects, [NativeTypeName("D2D1_RECT_L[]")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L")] RECT* outputOpaqueSubRect)
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MapInputRectsToOutputRect>(lpVtbl->MapInputRectsToOutputRect)(This, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L")] RECT* invalidOutputRect)
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MapInvalidRect>(lpVtbl->MapInvalidRect)(This, inputIndex, invalidInputRect, invalidOutputRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderInfo(ID2D1RenderInfo* renderInfo)
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetRenderInfo>(lpVtbl->SetRenderInfo)(This, renderInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw(ID2D1Bitmap1* target, [NativeTypeName("D2D1_RECT_L")] RECT* drawRect, [NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U targetOrigin)
        {
            fixed (ID2D1SourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Draw>(lpVtbl->Draw)(This, target, drawRect, targetOrigin);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetInputCount;

            public IntPtr MapOutputRectToInputRects;

            public IntPtr MapInputRectsToOutputRect;

            public IntPtr MapInvalidRect;

            public IntPtr SetRenderInfo;

            public IntPtr Draw;
        }
    }
}
