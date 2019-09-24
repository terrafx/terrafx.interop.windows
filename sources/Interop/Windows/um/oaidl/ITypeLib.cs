// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("00020402-0000-0000-C000-000000000046")]
    public unsafe struct ITypeLib
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ITypeLib* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ITypeLib* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ITypeLib* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate uint _GetTypeInfoCount(
            [In] ITypeLib* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypeInfo(
            [In] ITypeLib* This,
            [In, NativeTypeName("UINT")] uint index,
            [Out] ITypeInfo** ppTInfo = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypeInfoType(
            [In] ITypeLib* This,
            [In, NativeTypeName("UINT")] uint index,
            [Out] TYPEKIND* pTKind
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypeInfoOfGuid(
            [In] ITypeLib* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [Out] ITypeInfo** ppTinfo = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLibAttr(
            [In] ITypeLib* This,
            [Out] TLIBATTR** ppTLibAttr
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypeComp(
            [In] ITypeLib* This,
            [Out] ITypeComp** ppTComp = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDocumentation(
            [In] ITypeLib* This,
            [In, NativeTypeName("INT")] int index,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrName,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrDocString,
            [Out, NativeTypeName("DWORD")] uint* pdwHelpContext,
            [Out, NativeTypeName("BSTR")] char** pBstrHelpFile = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _IsName(
            [In] ITypeLib* This,
            [In, Out, NativeTypeName("LPOLESTR")] char* szNameBuf,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [Out, NativeTypeName("BOOL")] int* pfName
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FindName(
            [In] ITypeLib* This,
            [In, Out, NativeTypeName("LPOLESTR")] char* szNameBuf,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [Out] ITypeInfo** ppTInfo,
            [Out, NativeTypeName("MEMBERID")] int* rgMemId,
            [In, Out, NativeTypeName("USHORT")] ushort* pcFound
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ReleaseTLibAttr(
            [In] ITypeLib* This,
            [In] TLIBATTR* pTLibAttr
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ITypeLib* This = &this)
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
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public uint GetTypeInfoCount()
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(
            [In, NativeTypeName("UINT")] uint index,
            [Out] ITypeInfo** ppTInfo = null
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)(
                    This,
                    index,
                    ppTInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType(
            [In, NativeTypeName("UINT")] uint index,
            [Out] TYPEKIND* pTKind
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoType>(lpVtbl->GetTypeInfoType)(
                    This,
                    index,
                    pTKind
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [Out] ITypeInfo** ppTinfo = null
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoOfGuid>(lpVtbl->GetTypeInfoOfGuid)(
                    This,
                    guid,
                    ppTinfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr(
            [Out] TLIBATTR** ppTLibAttr
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLibAttr>(lpVtbl->GetLibAttr)(
                    This,
                    ppTLibAttr
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp(
            [Out] ITypeComp** ppTComp = null
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeComp>(lpVtbl->GetTypeComp)(
                    This,
                    ppTComp
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation(
            [In, NativeTypeName("INT")] int index,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrName,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrDocString,
            [Out, NativeTypeName("DWORD")] uint* pdwHelpContext,
            [Out, NativeTypeName("BSTR")] char** pBstrHelpFile = null
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDocumentation>(lpVtbl->GetDocumentation)(
                    This,
                    index,
                    pBstrName,
                    pBstrDocString,
                    pdwHelpContext,
                    pBstrHelpFile
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsName(
            [In, Out, NativeTypeName("LPOLESTR")] char* szNameBuf,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [Out, NativeTypeName("BOOL")] int* pfName
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsName>(lpVtbl->IsName)(
                    This,
                    szNameBuf,
                    lHashVal,
                    pfName
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindName(
            [In, Out, NativeTypeName("LPOLESTR")] char* szNameBuf,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [Out] ITypeInfo** ppTInfo,
            [Out, NativeTypeName("MEMBERID")] int* rgMemId,
            [In, Out, NativeTypeName("USHORT")] ushort* pcFound
        )
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindName>(lpVtbl->FindName)(
                    This,
                    szNameBuf,
                    lHashVal,
                    ppTInfo,
                    rgMemId,
                    pcFound
                );
            }
        }

        public void ReleaseTLibAttr(
            [In] TLIBATTR* pTLibAttr
        )
        {
            fixed (ITypeLib* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseTLibAttr>(lpVtbl->ReleaseTLibAttr)(
                    This,
                    pTLibAttr
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetTypeInfoCount;

            public IntPtr GetTypeInfo;

            public IntPtr GetTypeInfoType;

            public IntPtr GetTypeInfoOfGuid;

            public IntPtr GetLibAttr;

            public IntPtr GetTypeComp;

            public IntPtr GetDocumentation;

            public IntPtr IsName;

            public IntPtr FindName;

            public IntPtr ReleaseTLibAttr;
        }
    }
}
