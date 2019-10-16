// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5810CD44-0CA0-4701-B3FA-BEC5182AE4F6")]
    public unsafe partial struct IDWriteTextAnalysisSink
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextAnalysisSink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextAnalysisSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextAnalysisSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetScriptAnalysis(IDWriteTextAnalysisSink* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineBreakpoints(IDWriteTextAnalysisSink* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_LINE_BREAKPOINT *")] DWRITE_LINE_BREAKPOINT* lineBreakpoints);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBidiLevel(IDWriteTextAnalysisSink* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT8")] byte explicitLevel, [NativeTypeName("UINT8")] byte resolvedLevel);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNumberSubstitution(IDWriteTextAnalysisSink* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScriptAnalysis([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetScriptAnalysis>(lpVtbl->SetScriptAnalysis)((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, scriptAnalysis);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineBreakpoints([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_LINE_BREAKPOINT *")] DWRITE_LINE_BREAKPOINT* lineBreakpoints)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLineBreakpoints>(lpVtbl->SetLineBreakpoints)((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, lineBreakpoints);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBidiLevel([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT8")] byte explicitLevel, [NativeTypeName("UINT8")] byte resolvedLevel)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBidiLevel>(lpVtbl->SetBidiLevel)((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, explicitLevel, resolvedLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetNumberSubstitution>(lpVtbl->SetNumberSubstitution)((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT32, UINT32, const DWRITE_SCRIPT_ANALYSIS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetScriptAnalysis;

            [NativeTypeName("HRESULT (UINT32, UINT32, const DWRITE_LINE_BREAKPOINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLineBreakpoints;

            [NativeTypeName("HRESULT (UINT32, UINT32, UINT8, UINT8) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBidiLevel;

            [NativeTypeName("HRESULT (UINT32, UINT32, IDWriteNumberSubstitution *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetNumberSubstitution;
        }
    }
}
