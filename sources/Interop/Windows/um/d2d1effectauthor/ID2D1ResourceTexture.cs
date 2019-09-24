// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("688D15C3-02B0-438D-B13A-D1B44C32C39A")]
    public unsafe struct ID2D1ResourceTexture
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1ResourceTexture* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1ResourceTexture* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1ResourceTexture* This
        );

        /// <summary>Update the vertex text.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Update(
            [In] ID2D1ResourceTexture* This,
            [In, Optional, NativeTypeName("UINT32[]")] uint* minimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* maximimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* strides,
            [In, NativeTypeName("UINT32")] uint dimensions,
            [In, NativeTypeName("BYTE[]")]  byte* data,
            [In, NativeTypeName("UINT32")] uint dataCount
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ResourceTexture* This = &this)
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
            fixed (ID2D1ResourceTexture* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ResourceTexture* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Update(
            [In, Optional, NativeTypeName("UINT32[]")] uint* minimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* maximimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* strides,
            [In, NativeTypeName("UINT32")] uint dimensions,
            [In, NativeTypeName("BYTE[]")]  byte* data,
            [In, NativeTypeName("UINT32")] uint dataCount
        )
        {
            fixed (ID2D1ResourceTexture* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Update>(lpVtbl->Update)(
                    This,
                    minimumExtents,
                    maximimumExtents,
                    strides,
                    dimensions,
                    data,
                    dataCount
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Update;
        }
    }
}
