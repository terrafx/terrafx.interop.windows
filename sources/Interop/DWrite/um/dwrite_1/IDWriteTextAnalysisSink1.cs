// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by the client to receive the output of the text analyzers.</summary>
    [Guid("B0D941A0-85E7-4D8B-9FD3-5CED9934482A")]
    public unsafe partial struct IDWriteTextAnalysisSink1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextAnalysisSink1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextAnalysisSink1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextAnalysisSink1* This);

        /// <summary>Report script analysis for the text range.</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="scriptAnalysis">Script analysis of characters in range.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetScriptAnalysis(IDWriteTextAnalysisSink1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis);

        /// <summary>Report line-break opportunities for each character, starting from the specified position.</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="lineBreakpoints">Breaking conditions for each character.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineBreakpoints(IDWriteTextAnalysisSink1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, DWRITE_LINE_BREAKPOINT* lineBreakpoints);

        /// <summary>Set bidirectional level on the range, called once per each level run change (either explicit or resolved implicit).</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="explicitLevel">Explicit level from embedded control codes RLE/RLO/LRE/LRO/PDF, determined before any additional rules.</param>
        /// <param name="resolvedLevel">Final implicit level considering the explicit level and characters' natural directionality, after all Bidi rules have been applied.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBidiLevel(IDWriteTextAnalysisSink1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT8")] byte explicitLevel, [NativeTypeName("UINT8")] byte resolvedLevel);

        /// <summary>Set number substitution on the range.</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF16 units of the reported range.</param>
        /// <param name="numberSubstitution">The number substitution applicable to the returned range of text. The sink callback may hold onto it by incrementing its ref count.</param>
        /// <returns>A successful code or error code to abort analysis.</returns>
        /// <remark> Unlike script and bidi analysis, where every character passed to the analyzer has a result, this will only be called for those ranges where substitution is applicable. For any other range, you will simply not be called.</remark>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNumberSubstitution(IDWriteTextAnalysisSink1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteNumberSubstitution* numberSubstitution);

        /// <summary>The text analyzer calls back to this to report the actual orientation of each character for shaping and drawing.</summary>
        /// <param name="textPosition">Starting position to report from.</param>
        /// <param name="textLength">Number of UTF-16 units of the reported range.</param>
        /// <param name="glyphOrientationAngle">Angle of the glyphs within the text range (pass to GetGlyphOrientationTransform to get the world relative transform).</param>
        /// <param name="adjustedBidiLevel">The adjusted bidi level to be used by the client layout for reordering runs. This will differ from the resolved bidi level retrieved from the source for cases such as Arabic stacked top-to-bottom, where the glyphs are still shaped as RTL, but the runs are TTB along with any CJK or Latin.</param>
        /// <param name="isSideways">Whether the glyphs are rotated on their side, which is the default case for CJK and the case stacked Latin</param>
        /// <param name="isRightToLeft">Whether the script should be shaped as right-to-left. For Arabic stacked top-to-bottom, even when the adjusted bidi level is coerced to an even level, this will still be true.</param>
        /// <returns> A successful code or error code to abort analysis.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGlyphOrientation(IDWriteTextAnalysisSink1* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("UINT8")] byte adjustedBidiLevel, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScriptAnalysis([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis)
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetScriptAnalysis>(lpVtbl->SetScriptAnalysis)(This, textPosition, textLength, scriptAnalysis);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineBreakpoints([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, DWRITE_LINE_BREAKPOINT* lineBreakpoints)
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLineBreakpoints>(lpVtbl->SetLineBreakpoints)(This, textPosition, textLength, lineBreakpoints);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBidiLevel([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT8")] byte explicitLevel, [NativeTypeName("UINT8")] byte resolvedLevel)
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBidiLevel>(lpVtbl->SetBidiLevel)(This, textPosition, textLength, explicitLevel, resolvedLevel);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteNumberSubstitution* numberSubstitution)
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetNumberSubstitution>(lpVtbl->SetNumberSubstitution)(This, textPosition, textLength, numberSubstitution);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGlyphOrientation([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("UINT8")] byte adjustedBidiLevel, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft)
        {
            fixed (IDWriteTextAnalysisSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGlyphOrientation>(lpVtbl->SetGlyphOrientation)(This, textPosition, textLength, glyphOrientationAngle, adjustedBidiLevel, isSideways, isRightToLeft);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetScriptAnalysis;

            public IntPtr SetLineBreakpoints;

            public IntPtr SetBidiLevel;

            public IntPtr SetNumberSubstitution;

            public IntPtr SetGlyphOrientation;
        }
    }
}
