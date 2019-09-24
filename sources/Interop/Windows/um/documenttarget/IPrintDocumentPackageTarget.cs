// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\documenttarget.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("1B8EFEC4-3019-4C27-964E-367202156906")]
    public unsafe struct IPrintDocumentPackageTarget
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IPrintDocumentPackageTarget* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IPrintDocumentPackageTarget* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IPrintDocumentPackageTarget* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPackageTargetTypes(
            [In] IPrintDocumentPackageTarget* This,
            [Out, NativeTypeName("UINT32")] uint* targetCount,
            [Out, NativeTypeName("GUID[]")] Guid** targetTypes = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPackageTarget(
            [In] IPrintDocumentPackageTarget* This,
            [In, NativeTypeName("REFGUID")] Guid* guidTargetType,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvTarget = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Cancel(
            [In] IPrintDocumentPackageTarget* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IPrintDocumentPackageTarget* This = &this)
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
            fixed (IPrintDocumentPackageTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IPrintDocumentPackageTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPackageTargetTypes(
            [Out, NativeTypeName("UINT32")] uint* targetCount,
            [Out, NativeTypeName("GUID[]")] Guid** targetTypes = null
        )
        {
            fixed (IPrintDocumentPackageTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPackageTargetTypes>(lpVtbl->GetPackageTargetTypes)(
                    This,
                    targetCount,
                    targetTypes
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPackageTarget(
            [In, NativeTypeName("REFGUID")] Guid* guidTargetType,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvTarget = null
        )
        {
            fixed (IPrintDocumentPackageTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPackageTarget>(lpVtbl->GetPackageTarget)(
                    This,
                    guidTargetType,
                    riid,
                    ppvTarget
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            fixed (IPrintDocumentPackageTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Cancel>(lpVtbl->Cancel)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetPackageTargetTypes;

            public IntPtr GetPackageTarget;

            public IntPtr Cancel;
        }
    }
}
