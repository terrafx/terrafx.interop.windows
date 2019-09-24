// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Converts Direct2D primitives stored in an ID2D1CommandList into a fixed page representation. The print sub-system then consumes the primitives.</summary>
    [Guid("2C1D867D-C290-41C8-AE7E-34A98702E9A5")]
    public unsafe struct ID2D1PrintControl
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1PrintControl* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1PrintControl* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1PrintControl* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddPage(
            [In] ID2D1PrintControl* This,
            [In] ID2D1CommandList* commandList,
            [In] D2D_SIZE_F pageSize,
            [In] IStream* pagePrintTicketStream = null,
            [Out, NativeTypeName("D2D1_TAG")] ulong* tag1 = null,
            [Out, NativeTypeName("D2D1_TAG")] ulong* tag2 = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Close(
            [In] ID2D1PrintControl* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1PrintControl* This = &this)
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
            fixed (ID2D1PrintControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1PrintControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddPage(
            [In] ID2D1CommandList* commandList,
            [In] D2D_SIZE_F pageSize,
            [In] IStream* pagePrintTicketStream = null,
            [Out, NativeTypeName("D2D1_TAG")] ulong* tag1 = null,
            [Out, NativeTypeName("D2D1_TAG")] ulong* tag2 = null
        )
        {
            fixed (ID2D1PrintControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddPage>(lpVtbl->AddPage)(
                    This,
                    commandList,
                    pageSize,
                    pagePrintTicketStream,
                    tag1,
                    tag2
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            fixed (ID2D1PrintControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AddPage;

            public IntPtr Close;
        }
    }
}
