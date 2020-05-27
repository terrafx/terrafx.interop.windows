// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020401-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeAttr(ITypeInfo* pThis, [NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeComp(ITypeInfo* pThis, [NativeTypeName("ITypeComp **")] ITypeComp** ppTComp);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFuncDesc(ITypeInfo* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVarDesc(ITypeInfo* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNames(ITypeInfo* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeOfImplType(ITypeInfo* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImplTypeFlags(ITypeInfo* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(ITypeInfo* pThis, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(ITypeInfo* pThis, [NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation(ITypeInfo* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDllEntry(ITypeInfo* pThis, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeInfo(ITypeInfo* pThis, [NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddressOfMember(ITypeInfo* pThis, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(ITypeInfo* pThis, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMops(ITypeInfo* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingTypeLib(ITypeInfo* pThis, [NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseTypeAttr(ITypeInfo* pThis, [NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseFuncDesc(ITypeInfo* pThis, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseVarDesc(ITypeInfo* pThis, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ITypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ITypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ITypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeAttr([NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeAttr>(lpVtbl->GetTypeAttr)((ITypeInfo*)Unsafe.AsPointer(ref this), ppTypeAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeComp>(lpVtbl->GetTypeComp)((ITypeInfo*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFuncDesc>(lpVtbl->GetFuncDesc)((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVarDesc>(lpVtbl->GetVarDesc)((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNames>(lpVtbl->GetNames)((ITypeInfo*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeOfImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRefTypeOfImplType>(lpVtbl->GetRefTypeOfImplType)((ITypeInfo*)Unsafe.AsPointer(ref this), index, pRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetImplTypeFlags>(lpVtbl->GetImplTypeFlags)((ITypeInfo*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((ITypeInfo*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((ITypeInfo*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDocumentation>(lpVtbl->GetDocumentation)((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDllEntry>(lpVtbl->GetDllEntry)((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRefTypeInfo>(lpVtbl->GetRefTypeInfo)((ITypeInfo*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddressOfMember>(lpVtbl->AddressOfMember)((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)((ITypeInfo*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMops>(lpVtbl->GetMops)((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingTypeLib([NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainingTypeLib>(lpVtbl->GetContainingTypeLib)((ITypeInfo*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
        }

        public void ReleaseTypeAttr([NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseTypeAttr>(lpVtbl->ReleaseTypeAttr)((ITypeInfo*)Unsafe.AsPointer(ref this), pTypeAttr);
        }

        public void ReleaseFuncDesc([NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseFuncDesc>(lpVtbl->ReleaseFuncDesc)((ITypeInfo*)Unsafe.AsPointer(ref this), pFuncDesc);
        }

        public void ReleaseVarDesc([NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseVarDesc>(lpVtbl->ReleaseVarDesc)((ITypeInfo*)Unsafe.AsPointer(ref this), pVarDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (TYPEATTR **) __attribute__((stdcall))")]
            public IntPtr GetTypeAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public IntPtr GetTypeComp;

            [NativeTypeName("HRESULT (UINT, FUNCDESC **) __attribute__((stdcall))")]
            public IntPtr GetFuncDesc;

            [NativeTypeName("HRESULT (UINT, VARDESC **) __attribute__((stdcall))")]
            public IntPtr GetVarDesc;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, UINT, UINT *) __attribute__((stdcall))")]
            public IntPtr GetNames;

            [NativeTypeName("HRESULT (UINT, HREFTYPE *) __attribute__((stdcall))")]
            public IntPtr GetRefTypeOfImplType;

            [NativeTypeName("HRESULT (UINT, INT *) __attribute__((stdcall))")]
            public IntPtr GetImplTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR *, UINT, MEMBERID *) __attribute__((stdcall))")]
            public IntPtr GetIDsOfNames;

            [NativeTypeName("HRESULT (PVOID, MEMBERID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public IntPtr Invoke;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDocumentation;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, BSTR *, BSTR *, WORD *) __attribute__((stdcall))")]
            public IntPtr GetDllEntry;

            [NativeTypeName("HRESULT (HREFTYPE, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetRefTypeInfo;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, PVOID *) __attribute__((stdcall))")]
            public IntPtr AddressOfMember;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, PVOID *) __attribute__((stdcall))")]
            public IntPtr CreateInstance;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetMops;

            [NativeTypeName("HRESULT (ITypeLib **, UINT *) __attribute__((stdcall))")]
            public IntPtr GetContainingTypeLib;

            [NativeTypeName("void (TYPEATTR *) __attribute__((stdcall))")]
            public IntPtr ReleaseTypeAttr;

            [NativeTypeName("void (FUNCDESC *) __attribute__((stdcall))")]
            public IntPtr ReleaseFuncDesc;

            [NativeTypeName("void (VARDESC *) __attribute__((stdcall))")]
            public IntPtr ReleaseVarDesc;
        }
    }
}
