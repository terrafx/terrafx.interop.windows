// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020402-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeLib
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeLib* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeLib* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeLib* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate uint _GetTypeInfoCount(ITypeLib* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(ITypeLib* This, [NativeTypeName("UINT")] uint index, ITypeInfo** ppTInfo = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoType(ITypeLib* This, [NativeTypeName("UINT")] uint index, TYPEKIND* pTKind);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoOfGuid(ITypeLib* This, [NativeTypeName("REFGUID")] Guid* guid, ITypeInfo** ppTinfo = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLibAttr(ITypeLib* This, TLIBATTR** ppTLibAttr);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeComp(ITypeLib* This, ITypeComp** ppTComp = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation(ITypeLib* This, [NativeTypeName("INT")] int index, [Optional, NativeTypeName("BSTR")] ushort** pBstrName, [Optional, NativeTypeName("BSTR")] ushort** pBstrDocString, [NativeTypeName("DWORD")] uint* pdwHelpContext, [NativeTypeName("BSTR")] ushort** pBstrHelpFile = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsName(ITypeLib* This, [NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL")] int* pfName);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindName(ITypeLib* This, [NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID")] int* rgMemId, [NativeTypeName("USHORT")] ushort* pcFound);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseTLibAttr(ITypeLib* This, TLIBATTR* pTLibAttr);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public uint GetTypeInfoCount()
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint index, ITypeInfo** ppTInfo = null)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)(This, index, ppTInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType([NativeTypeName("UINT")] uint index, TYPEKIND* pTKind)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoType>(lpVtbl->GetTypeInfoType)(This, index, pTKind);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid([NativeTypeName("REFGUID")] Guid* guid, ITypeInfo** ppTinfo = null)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoOfGuid>(lpVtbl->GetTypeInfoOfGuid)(This, guid, ppTinfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr(TLIBATTR** ppTLibAttr)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLibAttr>(lpVtbl->GetLibAttr)(This, ppTLibAttr);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp(ITypeComp** ppTComp = null)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeComp>(lpVtbl->GetTypeComp)(This, ppTComp);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("INT")] int index, [Optional, NativeTypeName("BSTR")] ushort** pBstrName, [Optional, NativeTypeName("BSTR")] ushort** pBstrDocString, [NativeTypeName("DWORD")] uint* pdwHelpContext, [NativeTypeName("BSTR")] ushort** pBstrHelpFile = null)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDocumentation>(lpVtbl->GetDocumentation)(This, index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL")] int* pfName)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsName>(lpVtbl->IsName)(This, szNameBuf, lHashVal, pfName);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID")] int* rgMemId, [NativeTypeName("USHORT")] ushort* pcFound)
        {
            fixed (ITypeLib* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindName>(lpVtbl->FindName)(This, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
            }
        }

        public void ReleaseTLibAttr(TLIBATTR* pTLibAttr)
        {
            fixed (ITypeLib* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseTLibAttr>(lpVtbl->ReleaseTLibAttr)(This, pTLibAttr);
            }
        }

        public partial struct Vtbl
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
