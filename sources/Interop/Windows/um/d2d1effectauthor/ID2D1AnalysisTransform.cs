// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by a transform author to indicate that it should receive an analysis result callback.</summary>
    [Guid("0359DC30-95E6-4568-9055-27720D130E93")]
    public unsafe struct ID2D1AnalysisTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1AnalysisTransform* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1AnalysisTransform* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1AnalysisTransform* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessAnalysisResults(
            [In] ID2D1AnalysisTransform* This,
            [In, NativeTypeName("BYTE[]")] byte* analysisData,
            [In, NativeTypeName("UINT32")] uint analysisDataCount
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1AnalysisTransform* This = &this)
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
            fixed (ID2D1AnalysisTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1AnalysisTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessAnalysisResults(
            [In, NativeTypeName("BYTE[]")] byte* analysisData,
            [In, NativeTypeName("UINT32")] uint analysisDataCount
        )
        {
            fixed (ID2D1AnalysisTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ProcessAnalysisResults>(lpVtbl->ProcessAnalysisResults)(
                    This,
                    analysisData,
                    analysisDataCount
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr ProcessAnalysisResults;
        }
    }
}
