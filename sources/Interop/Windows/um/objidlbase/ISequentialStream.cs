// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
    public unsafe struct ISequentialStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ISequentialStream* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ISequentialStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ISequentialStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(
            [In] ISequentialStream* This,
            [Out] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbRead = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(
            [In] ISequentialStream* This,
            [In] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbWritten = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ISequentialStream* This = &this)
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
            fixed (ISequentialStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ISequentialStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Read(
            [Out] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbRead = null
        )
        {
            fixed (ISequentialStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)(
                    This,
                    pv,
                    cb,
                    pcbRead
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Write(
            [In] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbWritten = null
        )
        {
            fixed (ISequentialStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)(
                    This,
                    pv,
                    cb,
                    pcbWritten
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Read;

            public IntPtr Write;
        }
    }
}
