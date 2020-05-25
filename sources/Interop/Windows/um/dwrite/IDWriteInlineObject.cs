// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8339FDE3-106F-47AB-8373-1C6295EB10B3")]
    public unsafe partial struct IDWriteInlineObject
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteInlineObject* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteInlineObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteInlineObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Draw(IDWriteInlineObject* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("IDWriteTextRenderer *")] IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetrics(IDWriteInlineObject* pThis, [NativeTypeName("DWRITE_INLINE_OBJECT_METRICS *")] DWRITE_INLINE_OBJECT_METRICS* metrics);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOverhangMetrics(IDWriteInlineObject* pThis, [NativeTypeName("DWRITE_OVERHANG_METRICS *")] DWRITE_OVERHANG_METRICS* overhangs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBreakConditions(IDWriteInlineObject* pThis, [NativeTypeName("DWRITE_BREAK_CONDITION *")] DWRITE_BREAK_CONDITION* breakConditionBefore, [NativeTypeName("DWRITE_BREAK_CONDITION *")] DWRITE_BREAK_CONDITION* breakConditionAfter);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteInlineObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("IDWriteTextRenderer *")] IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IUnknown *")] IUnknown* clientDrawingEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_Draw>(lpVtbl->Draw)((IDWriteInlineObject*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetrics([NativeTypeName("DWRITE_INLINE_OBJECT_METRICS *")] DWRITE_INLINE_OBJECT_METRICS* metrics)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)((IDWriteInlineObject*)Unsafe.AsPointer(ref this), metrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics([NativeTypeName("DWRITE_OVERHANG_METRICS *")] DWRITE_OVERHANG_METRICS* overhangs)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOverhangMetrics>(lpVtbl->GetOverhangMetrics)((IDWriteInlineObject*)Unsafe.AsPointer(ref this), overhangs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBreakConditions([NativeTypeName("DWRITE_BREAK_CONDITION *")] DWRITE_BREAK_CONDITION* breakConditionBefore, [NativeTypeName("DWRITE_BREAK_CONDITION *")] DWRITE_BREAK_CONDITION* breakConditionAfter)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBreakConditions>(lpVtbl->GetBreakConditions)((IDWriteInlineObject*)Unsafe.AsPointer(ref this), breakConditionBefore, breakConditionAfter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (void *, IDWriteTextRenderer *, FLOAT, FLOAT, BOOL, BOOL, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Draw;

            [NativeTypeName("HRESULT (DWRITE_INLINE_OBJECT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMetrics;

            [NativeTypeName("HRESULT (DWRITE_OVERHANG_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOverhangMetrics;

            [NativeTypeName("HRESULT (DWRITE_BREAK_CONDITION *, DWRITE_BREAK_CONDITION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBreakConditions;
        }
    }
}
