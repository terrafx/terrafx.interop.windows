// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by the text analyzer's client to receive the output of a given text analysis. The Text analyzer disregards any current state of the analysis sink, therefore a Set method call on a range overwrites the previously set analysis result of the same range. </summary>
    [Guid("5810CD44-0CA0-4701-B3FA-BEC5182AE4F6")]
    public unsafe struct IDWriteTextAnalysisSink
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteTextAnalysisSink* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteTextAnalysisSink* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteTextAnalysisSink* This
        );

        /// <summary>Report script analysis for the text range.</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="scriptAnalysis">Script analysis of characters in range.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetScriptAnalysis(
            [In] IDWriteTextAnalysisSink* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis
        );

        /// <summary>Report line-break opportunities for each character, starting from the specified position.</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="lineBreakpoints">Breaking conditions for each character.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetLineBreakpoints(
            [In] IDWriteTextAnalysisSink* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In] DWRITE_LINE_BREAKPOINT* lineBreakpoints
        );

        /// <summary>Set bidirectional level on the range, called once per each level run change (either explicit or resolved implicit).</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="explicitLevel">Explicit level from embedded control codes RLE/RLO/LRE/LRO/PDF, determined before any additional rules.</param>
        /// <param name="resolvedLevel">Final implicit level considering the explicit level and characters' natural directionality, after all Bidi rules have been applied.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBidiLevel(
            [In] IDWriteTextAnalysisSink* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In, NativeTypeName("UINT8")] byte explicitLevel,
            [In, NativeTypeName("UINT8")] byte resolvedLevel
        );

        /// <summary>Set number substitution on the range.</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="numberSubstitution">The number substitution applicable to the returned range of text. The sink callback may hold onto it by incrementing its ref count.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        /// <remark> Unlike script and bidi analysis, where every character passed to the analyzer has a result, this will only be called for those ranges where substitution is applicable. For any other range, you will simply not be called.</remark>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetNumberSubstitution(
            [In] IDWriteTextAnalysisSink* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In] IDWriteNumberSubstitution* numberSubstitution
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteTextAnalysisSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextAnalysisSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextAnalysisSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScriptAnalysis(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis
        )
        {
            fixed (IDWriteTextAnalysisSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetScriptAnalysis>(lpVtbl->SetScriptAnalysis)(
                    This,
                    textPosition,
                    textLength,
                    scriptAnalysis
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineBreakpoints(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In] DWRITE_LINE_BREAKPOINT* lineBreakpoints
        )
        {
            fixed (IDWriteTextAnalysisSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLineBreakpoints>(lpVtbl->SetLineBreakpoints)(
                    This,
                    textPosition,
                    textLength,
                    lineBreakpoints
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBidiLevel(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In, NativeTypeName("UINT8")] byte explicitLevel,
            [In, NativeTypeName("UINT8")] byte resolvedLevel
        )
        {
            fixed (IDWriteTextAnalysisSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBidiLevel>(lpVtbl->SetBidiLevel)(
                    This,
                    textPosition,
                    textLength,
                    explicitLevel,
                    resolvedLevel
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNumberSubstitution(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In] IDWriteNumberSubstitution* numberSubstitution
        )
        {
            fixed (IDWriteTextAnalysisSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetNumberSubstitution>(lpVtbl->SetNumberSubstitution)(
                    This,
                    textPosition,
                    textLength,
                    numberSubstitution
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetScriptAnalysis;

            public IntPtr SetLineBreakpoints;

            public IntPtr SetBidiLevel;

            public IntPtr SetNumberSubstitution;
        }
    }
}
