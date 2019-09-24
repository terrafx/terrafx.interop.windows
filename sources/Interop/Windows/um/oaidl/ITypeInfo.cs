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
        public delegate int _QueryInterface(ITypeInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeAttr(ITypeInfo* This, TYPEATTR** ppTypeAttr);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeComp(ITypeInfo* This, ITypeComp** ppTComp = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFuncDesc(ITypeInfo* This, [NativeTypeName("UINT")] uint index, FUNCDESC** ppFuncDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVarDesc(ITypeInfo* This, [NativeTypeName("UINT")] uint index, VARDESC** ppVarDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNames(ITypeInfo* This, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR[]")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT")] uint* pcNames);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeOfImplType(ITypeInfo* This, [NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint* pRefType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImplTypeFlags(ITypeInfo* This, [NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int* pImplTypeFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(ITypeInfo* This, [NativeTypeName("LPOLESTR[]")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID")] int* pMemId);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(ITypeInfo* This, [NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation(ITypeInfo* This, [NativeTypeName("MEMBERID")] int memid, [Optional, NativeTypeName("BSTR")] ushort** pBstrName, [Optional, NativeTypeName("BSTR")] ushort** pBstrDocString, [NativeTypeName("DWORD")] uint* pdwHelpContext, [NativeTypeName("BSTR")] ushort** pBstrHelpFile = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDllEntry(ITypeInfo* This, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [Optional, NativeTypeName("BSTR")] ushort** pBstrDllName, [Optional, NativeTypeName("BSTR")] ushort** pBstrName, [NativeTypeName("WORD")] ushort* pwOrdinal);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeInfo(ITypeInfo* This, [NativeTypeName("HREFTYPE")] uint hRefType, ITypeInfo** ppTInfo = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddressOfMember(ITypeInfo* This, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(ITypeInfo* This, IUnknown* pUnkOuter, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("PVOID")] void** ppvObj);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMops(ITypeInfo* This, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR")] ushort** pBstrMops = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingTypeLib(ITypeInfo* This, ITypeLib** ppTLib, [NativeTypeName("UINT")] uint* pIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseTypeAttr(ITypeInfo* This, TYPEATTR* pTypeAttr);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseFuncDesc(ITypeInfo* This, FUNCDESC* pFuncDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseVarDesc(ITypeInfo* This, VARDESC* pVarDesc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeAttr(TYPEATTR** ppTypeAttr)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeAttr>(lpVtbl->GetTypeAttr)(This, ppTypeAttr);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp(ITypeComp** ppTComp = null)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeComp>(lpVtbl->GetTypeComp)(This, ppTComp);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncDesc([NativeTypeName("UINT")] uint index, FUNCDESC** ppFuncDesc)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFuncDesc>(lpVtbl->GetFuncDesc)(This, index, ppFuncDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarDesc([NativeTypeName("UINT")] uint index, VARDESC** ppVarDesc)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVarDesc>(lpVtbl->GetVarDesc)(This, index, ppVarDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR[]")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT")] uint* pcNames)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNames>(lpVtbl->GetNames)(This, memid, rgBstrNames, cMaxNames, pcNames);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeOfImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint* pRefType)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRefTypeOfImplType>(lpVtbl->GetRefTypeOfImplType)(This, index, pRefType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int* pImplTypeFlags)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetImplTypeFlags>(lpVtbl->GetImplTypeFlags)(This, index, pImplTypeFlags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("LPOLESTR[]")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID")] int* pMemId)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)(This, rgszNames, cNames, pMemId);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT")] uint* puArgErr)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)(This, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("MEMBERID")] int memid, [Optional, NativeTypeName("BSTR")] ushort** pBstrName, [Optional, NativeTypeName("BSTR")] ushort** pBstrDocString, [NativeTypeName("DWORD")] uint* pdwHelpContext, [NativeTypeName("BSTR")] ushort** pBstrHelpFile = null)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDocumentation>(lpVtbl->GetDocumentation)(This, memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [Optional, NativeTypeName("BSTR")] ushort** pBstrDllName, [Optional, NativeTypeName("BSTR")] ushort** pBstrName, [NativeTypeName("WORD")] ushort* pwOrdinal)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDllEntry>(lpVtbl->GetDllEntry)(This, memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, ITypeInfo** ppTInfo = null)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRefTypeInfo>(lpVtbl->GetRefTypeInfo)(This, hRefType, ppTInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID")] void** ppv)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddressOfMember>(lpVtbl->AddressOfMember)(This, memid, invKind, ppv);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("PVOID")] void** ppvObj)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)(This, pUnkOuter, riid, ppvObj);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR")] ushort** pBstrMops = null)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMops>(lpVtbl->GetMops)(This, memid, pBstrMops);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingTypeLib(ITypeLib** ppTLib, [NativeTypeName("UINT")] uint* pIndex)
        {
            fixed (ITypeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainingTypeLib>(lpVtbl->GetContainingTypeLib)(This, ppTLib, pIndex);
            }
        }

        public void ReleaseTypeAttr(TYPEATTR* pTypeAttr)
        {
            fixed (ITypeInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseTypeAttr>(lpVtbl->ReleaseTypeAttr)(This, pTypeAttr);
            }
        }

        public void ReleaseFuncDesc(FUNCDESC* pFuncDesc)
        {
            fixed (ITypeInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseFuncDesc>(lpVtbl->ReleaseFuncDesc)(This, pFuncDesc);
            }
        }

        public void ReleaseVarDesc(VARDESC* pVarDesc)
        {
            fixed (ITypeInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseVarDesc>(lpVtbl->ReleaseVarDesc)(This, pVarDesc);
            }
        }

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
