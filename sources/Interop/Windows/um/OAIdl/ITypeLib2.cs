// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020411-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeLib2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeLib2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeLib2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeLib2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetTypeInfoCount(ITypeLib2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(ITypeLib2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoType(ITypeLib2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTKind);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoOfGuid(ITypeLib2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLibAttr(ITypeLib2* pThis, [NativeTypeName("TLIBATTR **")] TLIBATTR** ppTLibAttr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeComp(ITypeLib2* pThis, [NativeTypeName("ITypeComp **")] ITypeComp** ppTComp);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation(ITypeLib2* pThis, [NativeTypeName("INT")] int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsName(ITypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL *")] int* pfName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindName(ITypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, [NativeTypeName("USHORT *")] ushort* pcFound);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseTLibAttr(ITypeLib2* pThis, [NativeTypeName("TLIBATTR *")] TLIBATTR* pTLibAttr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCustData(ITypeLib2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLibStatistics(ITypeLib2* pThis, [NativeTypeName("ULONG *")] uint* pcUniqueNames, [NativeTypeName("ULONG *")] uint* pcchUniqueNames);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation2(ITypeLib2* pThis, [NativeTypeName("INT")] int index, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAllCustData(ITypeLib2* pThis, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ITypeLib2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetTypeInfoCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint index, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((ITypeLib2*)Unsafe.AsPointer(ref this), index, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType([NativeTypeName("UINT")] uint index, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTKind)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoType>(lpVtbl->GetTypeInfoType)((ITypeLib2*)Unsafe.AsPointer(ref this), index, pTKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoOfGuid>(lpVtbl->GetTypeInfoOfGuid)((ITypeLib2*)Unsafe.AsPointer(ref this), guid, ppTinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr([NativeTypeName("TLIBATTR **")] TLIBATTR** ppTLibAttr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLibAttr>(lpVtbl->GetLibAttr)((ITypeLib2*)Unsafe.AsPointer(ref this), ppTLibAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeComp>(lpVtbl->GetTypeComp)((ITypeLib2*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("INT")] int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDocumentation>(lpVtbl->GetDocumentation)((ITypeLib2*)Unsafe.AsPointer(ref this), index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL *")] int* pfName)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsName>(lpVtbl->IsName)((ITypeLib2*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, pfName);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, [NativeTypeName("USHORT *")] ushort* pcFound)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindName>(lpVtbl->FindName)((ITypeLib2*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
        }

        public void ReleaseTLibAttr([NativeTypeName("TLIBATTR *")] TLIBATTR* pTLibAttr)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseTLibAttr>(lpVtbl->ReleaseTLibAttr)((ITypeLib2*)Unsafe.AsPointer(ref this), pTLibAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCustData>(lpVtbl->GetCustData)((ITypeLib2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibStatistics([NativeTypeName("ULONG *")] uint* pcUniqueNames, [NativeTypeName("ULONG *")] uint* pcchUniqueNames)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLibStatistics>(lpVtbl->GetLibStatistics)((ITypeLib2*)Unsafe.AsPointer(ref this), pcUniqueNames, pcchUniqueNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation2([NativeTypeName("INT")] int index, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDocumentation2>(lpVtbl->GetDocumentation2)((ITypeLib2*)Unsafe.AsPointer(ref this), index, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllCustData([NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAllCustData>(lpVtbl->GetAllCustData)((ITypeLib2*)Unsafe.AsPointer(ref this), pCustData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetTypeInfo;

            [NativeTypeName("HRESULT (UINT, TYPEKIND *) __attribute__((stdcall))")]
            public IntPtr GetTypeInfoType;

            [NativeTypeName("HRESULT (const GUID &, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetTypeInfoOfGuid;

            [NativeTypeName("HRESULT (TLIBATTR **) __attribute__((stdcall))")]
            public IntPtr GetLibAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public IntPtr GetTypeComp;

            [NativeTypeName("HRESULT (INT, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDocumentation;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, BOOL *) __attribute__((stdcall))")]
            public IntPtr IsName;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, ITypeInfo **, MEMBERID *, USHORT *) __attribute__((stdcall))")]
            public IntPtr FindName;

            [NativeTypeName("void (TLIBATTR *) __attribute__((stdcall))")]
            public IntPtr ReleaseTLibAttr;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetCustData;

            [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
            public IntPtr GetLibStatistics;

            [NativeTypeName("HRESULT (INT, LCID, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDocumentation2;

            [NativeTypeName("HRESULT (CUSTDATA *) __attribute__((stdcall))")]
            public IntPtr GetAllCustData;
        }
    }
}
