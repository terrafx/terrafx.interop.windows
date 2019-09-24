// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020401-0000-0000-C000-000000000046")]
    public unsafe struct ITypeInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ITypeInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ITypeInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ITypeInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeAttr(
            [In] ITypeInfo* This,
            [Out] TYPEATTR** ppTypeAttr
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeComp(
            [In] ITypeInfo* This,
            [Out] ITypeComp** ppTComp = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFuncDesc(
            [In] ITypeInfo* This,
            [In, NativeTypeName("UINT")] uint index,
            [Out] FUNCDESC** ppFuncDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVarDesc(
            [In] ITypeInfo* This,
            [In, NativeTypeName("UINT")] uint index,
            [Out] VARDESC** ppVarDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNames(
            [In] ITypeInfo* This,
            [In, NativeTypeName("MEMBERID")] int memid,
            [Out, NativeTypeName("BSTR[]")] char** rgBstrNames,
            [In, NativeTypeName("UINT")] uint cMaxNames,
            [Out, NativeTypeName("UINT")] uint* pcNames
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeOfImplType(
            [In] ITypeInfo* This,
            [In, NativeTypeName("UINT")] uint index,
            [Out, NativeTypeName("HREFTYPE")] uint* pRefType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImplTypeFlags(
            [In] ITypeInfo* This,
            [In, NativeTypeName("UINT")] uint index,
            [Out, NativeTypeName("INT")] int* pImplTypeFlags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(
            [In] ITypeInfo* This,
            [In, NativeTypeName("LPOLESTR[]")] char** rgszNames,
            [In, NativeTypeName("UINT")] uint cNames,
            [Out, NativeTypeName("MEMBERID")] int* pMemId
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(
            [In] ITypeInfo* This,
            [In, NativeTypeName("PVOID")] void* pvInstance,
            [In, NativeTypeName("MEMBERID")] int memid,
            [In, NativeTypeName("WORD")] ushort wFlags,
            [In, Out] DISPPARAMS* pDispParams,
            [Out] VARIANT* pVarResult,
            [Out] EXCEPINFO* pExcepInfo,
            [Out, NativeTypeName("UINT")] uint* puArgErr
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation(
            [In] ITypeInfo* This,
            [In, NativeTypeName("MEMBERID")] int memid,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrName,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrDocString,
            [Out, NativeTypeName("DWORD")] uint* pdwHelpContext,
            [Out, NativeTypeName("BSTR")] char** pBstrHelpFile = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDllEntry(
            [In] ITypeInfo* This,
            [In, NativeTypeName("MEMBERID")] int memid,
            [In] INVOKEKIND invKind,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrDllName,
            [Out, Optional, NativeTypeName("BSTR")] char** pBstrName,
            [Out, NativeTypeName("WORD")] ushort* pwOrdinal
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeInfo(
            [In] ITypeInfo* This,
            [In, NativeTypeName("HREFTYPE")] uint hRefType,
            [Out] ITypeInfo** ppTInfo = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddressOfMember(
            [In] ITypeInfo* This,
            [In, NativeTypeName("MEMBERID")] int memid,
            [In] INVOKEKIND invKind,
            [Out, NativeTypeName("PVOID")] void** ppv
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(
            [In] ITypeInfo* This,
            [In] IUnknown* pUnkOuter,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out, NativeTypeName("PVOID")] void** ppvObj
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMops(
            [In] ITypeInfo* This,
            [In, NativeTypeName("MEMBERID")] int memid,
            [Out, NativeTypeName("BSTR")] char** pBstrMops = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingTypeLib(
            [In] ITypeInfo* This,
            [Out] ITypeLib** ppTLib,
            [Out, NativeTypeName("UINT")] uint* pIndex
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseTypeAttr(
            [In] ITypeInfo* This,
            [In] TYPEATTR* pTypeAttr
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseFuncDesc(
            [In] ITypeInfo* This,
            [In] FUNCDESC* pFuncDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseVarDesc(
            [In] ITypeInfo* This,
            [In] VARDESC* pVarDesc
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ITypeInfo* This = &this)
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
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        // [return: NativeTypeName("HRESULT")]
        // public int GetTypeAttr(
        //     [Out] TYPEATTR** ppTypeAttr
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetTypeAttr>(lpVtbl->GetTypeAttr)(
        //             This,
        //             ppTypeAttr
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetTypeComp(
        //     [Out] ITypeComp** ppTComp = null
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetTypeComp>(lpVtbl->GetTypeComp)(
        //             This,
        //             ppTComp
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetFuncDesc(
        //     [In, NativeTypeName("UINT")] uint index,
        //     [Out] FUNCDESC** ppFuncDesc
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetFuncDesc>(lpVtbl->GetFuncDesc)(
        //             This,
        //             index,
        //             ppFuncDesc
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetVarDesc(
        //     [In, NativeTypeName("UINT")] uint index,
        //     [Out] VARDESC** ppVarDesc
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetVarDesc>(lpVtbl->GetVarDesc)(
        //             This,
        //             index,
        //             ppVarDesc
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetNames(
        //     [In, NativeTypeName("MEMBERID")] int memid,
        //     [Out, NativeTypeName("BSTR[]")] char** rgBstrNames,
        //     [In, NativeTypeName("UINT")] uint cMaxNames,
        //     [Out, NativeTypeName("UINT")] uint* pcNames
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetNames>(lpVtbl->GetNames)(
        //             This,
        //             memid,
        //             rgBstrNames,
        //             cMaxNames,
        //             pcNames
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetRefTypeOfImplType(
        //     [In, NativeTypeName("UINT")] uint index,
        //     [Out, NativeTypeName("HREFTYPE")] uint* pRefType
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetRefTypeOfImplType>(lpVtbl->GetRefTypeOfImplType)(
        //             This,
        //             index,
        //             pRefType
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetImplTypeFlags(
        //     [In, NativeTypeName("UINT")] uint index,
        //     [Out, NativeTypeName("INT")] int* pImplTypeFlags
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetImplTypeFlags>(lpVtbl->GetImplTypeFlags)(
        //             This,
        //             index,
        //             pImplTypeFlags
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetIDsOfNames(
        //     [In, NativeTypeName("LPOLESTR[]")] char** rgszNames,
        //     [In, NativeTypeName("UINT")] uint cNames,
        //     [Out, NativeTypeName("MEMBERID")] int* pMemId
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)(
        //             This,
        //             rgszNames,
        //             cNames,
        //             pMemId
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int Invoke(
        //     [In, NativeTypeName("PVOID")] void* pvInstance,
        //     [In, NativeTypeName("MEMBERID")] int memid,
        //     [In, NativeTypeName("WORD")] ushort wFlags,
        //     [In, Out] DISPPARAMS* pDispParams,
        //     [Out] VARIANT* pVarResult,
        //     [Out] EXCEPINFO* pExcepInfo,
        //     [Out, NativeTypeName("UINT")] uint* puArgErr
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)(
        //             This,
        //             pvInstance,
        //             memid,
        //             wFlags,
        //             pDispParams,
        //             pVarResult,
        //             pExcepInfo,
        //             puArgErr
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetDocumentation(
        //     [In, NativeTypeName("MEMBERID")] int memid,
        //     [Out, Optional, NativeTypeName("BSTR")] char** pBstrName,
        //     [Out, Optional, NativeTypeName("BSTR")] char** pBstrDocString,
        //     [Out, NativeTypeName("DWORD")] uint* pdwHelpContext,
        //     [Out, NativeTypeName("BSTR")] char** pBstrHelpFile = null
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetDocumentation>(lpVtbl->GetDocumentation)(
        //             This,
        //             memid,
        //             pBstrName,
        //             pBstrDocString,
        //             pdwHelpContext,
        //             pBstrHelpFile
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetDllEntry(
        //     [In, NativeTypeName("MEMBERID")] int memid,
        //     [In] INVOKEKIND invKind,
        //     [Out, Optional, NativeTypeName("BSTR")] char** pBstrDllName,
        //     [Out, Optional, NativeTypeName("BSTR")] char** pBstrName,
        //     [Out, NativeTypeName("WORD")] ushort* pwOrdinal
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetDllEntry>(lpVtbl->GetDllEntry)(
        //             This,
        //             memid,
        //             invKind,
        //             pBstrDllName,
        //             pBstrName,
        //             pwOrdinal
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetRefTypeInfo(
        //     [In, NativeTypeName("HREFTYPE")] uint hRefType,
        //     [Out] ITypeInfo** ppTInfo = null
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetRefTypeInfo>(lpVtbl->GetRefTypeInfo)(
        //             This,
        //             hRefType,
        //             ppTInfo
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int AddressOfMember(
        //     [In, NativeTypeName("MEMBERID")] int memid,
        //     [In] INVOKEKIND invKind,
        //     [Out, NativeTypeName("PVOID")] void** ppv
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_AddressOfMember>(lpVtbl->AddressOfMember)(
        //             This,
        //             memid,
        //             invKind,
        //             ppv
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int CreateInstance(
        //     [In] IUnknown* pUnkOuter,
        //     [In, NativeTypeName("REFIID")] Guid* riid,
        //     [Out, NativeTypeName("PVOID")] void** ppvObj
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)(
        //             This,
        //             pUnkOuter,
        //             riid,
        //             ppvObj
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetMops(
        //     [In, NativeTypeName("MEMBERID")] int memid,
        //     [Out, NativeTypeName("BSTR")] char** pBstrMops = null
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetMops>(lpVtbl->GetMops)(
        //             This,
        //             memid,
        //             pBstrMops
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int GetContainingTypeLib(
        //     [Out] ITypeLib** ppTLib,
        //     [Out, NativeTypeName("UINT")] uint* pIndex
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_GetContainingTypeLib>(lpVtbl->GetContainingTypeLib)(
        //             This,
        //             ppTLib,
        //             pIndex
        //         );
        //     }
        // }

        // public void ReleaseTypeAttr(
        //     [In] TYPEATTR* pTypeAttr
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         Marshal.GetDelegateForFunctionPointer<_ReleaseTypeAttr>(lpVtbl->ReleaseTypeAttr)(
        //             This,
        //             pTypeAttr
        //         );
        //     }
        // }

        // public void ReleaseFuncDesc(
        //     [In] FUNCDESC* pFuncDesc
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         Marshal.GetDelegateForFunctionPointer<_ReleaseFuncDesc>(lpVtbl->ReleaseFuncDesc)(
        //             This,
        //             pFuncDesc
        //         );
        //     }
        // }

        // public void ReleaseVarDesc(
        //     [In] VARDESC* pVarDesc
        // )
        // {
        //     fixed (ITypeInfo* This = &this)
        //     {
        //         Marshal.GetDelegateForFunctionPointer<_ReleaseVarDesc>(lpVtbl->ReleaseVarDesc)(
        //             This,
        //             pVarDesc
        //         );
        //     }
        // }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetTypeAttr;

            public IntPtr GetTypeComp;

            public IntPtr GetFuncDesc;

            public IntPtr GetVarDesc;

            public IntPtr GetNames;

            public IntPtr GetRefTypeOfImplType;

            public IntPtr GetImplTypeFlags;

            public IntPtr GetIDsOfNames;

            public IntPtr Invoke;

            public IntPtr GetDocumentation;

            public IntPtr GetDllEntry;

            public IntPtr GetRefTypeInfo;

            public IntPtr AddressOfMember;

            public IntPtr CreateInstance;

            public IntPtr GetMops;

            public IntPtr GetContainingTypeLib;

            public IntPtr ReleaseTypeAttr;

            public IntPtr ReleaseFuncDesc;

            public IntPtr ReleaseVarDesc;
        }
    }
}
