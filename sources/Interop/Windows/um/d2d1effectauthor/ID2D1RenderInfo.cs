// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>A transform uses this interface to specify how to render a particular pass in D2D.</summary>
    [Guid("519AE1BD-D19A-420D-B849-364F594776B7")]
    public unsafe struct ID2D1RenderInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1RenderInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1RenderInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1RenderInfo* This
        );

        /// <summary>Sets options for sampling the specified image input</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInputDescription(
            [In] ID2D1RenderInfo* This,
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In] D2D1_INPUT_DESCRIPTION inputDescription
        );

        /// <summary>Controls the output precision and channel-depth for the associated transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputBuffer(
            [In] ID2D1RenderInfo* This,
            [In] D2D1_BUFFER_PRECISION bufferPrecision,
            [In] D2D1_CHANNEL_DEPTH channelDepth
        );

        /// <summary>Controls whether the output of the associated transform is cached.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetCached(
            [In] ID2D1RenderInfo* This,
            [In, NativeTypeName("BOOL")] int isCached
        );

        /// <summary>Provides a hint of the approximate shader instruction count per pixel.  If provided, it may improve performance when processing large images.  Instructions should be counted multiple times if occurring within loops.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInstructionCountHint(
            [In] ID2D1RenderInfo* This,
            [In, NativeTypeName("UINT32")] uint instructionCount
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1RenderInfo* This = &this)
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
            fixed (ID2D1RenderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1RenderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription(
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In] D2D1_INPUT_DESCRIPTION inputDescription
        )
        {
            fixed (ID2D1RenderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetInputDescription>(lpVtbl->SetInputDescription)(
                    This,
                    inputIndex,
                    inputDescription
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(
            [In] D2D1_BUFFER_PRECISION bufferPrecision,
            [In] D2D1_CHANNEL_DEPTH channelDepth
        )
        {
            fixed (ID2D1RenderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)(
                    This,
                    bufferPrecision,
                    channelDepth
                );
            }
        }

        public void SetCached(
            [In, NativeTypeName("BOOL")] int isCached
        )
        {
            fixed (ID2D1RenderInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetCached>(lpVtbl->SetCached)(
                    This,
                    isCached
                );
            }
        }

        public void SetInstructionCountHint(
            [In, NativeTypeName("UINT32")] uint instructionCount
        )
        {
            fixed (ID2D1RenderInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInstructionCountHint>(lpVtbl->SetInstructionCountHint)(
                    This,
                    instructionCount
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetInputDescription;

            public IntPtr SetOutputBuffer;

            public IntPtr SetCached;

            public IntPtr SetInstructionCountHint;
        }
    }
}
