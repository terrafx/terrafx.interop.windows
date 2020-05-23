// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002040F-0000-0000-C000-000000000046")]
    public unsafe partial struct ICreateTypeLib2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ICreateTypeLib2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ICreateTypeLib2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ICreateTypeLib2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTypeInfo(ICreateTypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szName, TYPEKIND tkind, [NativeTypeName("ICreateTypeInfo **")] ICreateTypeInfo** ppCTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ICreateTypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVersion(ICreateTypeLib2* pThis, [NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGuid(ICreateTypeLib2* pThis, [NativeTypeName("const GUID &")] Guid* guid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDocString(ICreateTypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szDoc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpFileName(ICreateTypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szHelpFileName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpContext(ICreateTypeLib2* pThis, [NativeTypeName("DWORD")] uint dwHelpContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLcid(ICreateTypeLib2* pThis, [NativeTypeName("LCID")] uint lcid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLibFlags(ICreateTypeLib2* pThis, [NativeTypeName("UINT")] uint uLibFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveAllChanges(ICreateTypeLib2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeleteTypeInfo(ICreateTypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCustData(ICreateTypeLib2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpStringContext(ICreateTypeLib2* pThis, [NativeTypeName("ULONG")] uint dwHelpStringContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpStringDll(ICreateTypeLib2* pThis, [NativeTypeName("LPOLESTR")] ushort* szFileName);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName, TYPEKIND tkind, [NativeTypeName("ICreateTypeInfo **")] ICreateTypeInfo** ppCTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTypeInfo>(lpVtbl->CreateTypeInfo)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName, tkind, ppCTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVersion>(lpVtbl->SetVersion)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGuid>(lpVtbl->SetGuid)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDocString>(lpVtbl->SetDocString)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpFileName>(lpVtbl->SetHelpFileName)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szHelpFileName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpContext>(lpVtbl->SetHelpContext)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLcid([NativeTypeName("LCID")] uint lcid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLcid>(lpVtbl->SetLcid)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), lcid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLibFlags([NativeTypeName("UINT")] uint uLibFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLibFlags>(lpVtbl->SetLibFlags)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), uLibFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveAllChanges()
        {
            return Marshal.GetDelegateForFunctionPointer<_SaveAllChanges>(lpVtbl->SaveAllChanges)((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeleteTypeInfo>(lpVtbl->DeleteTypeInfo)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCustData>(lpVtbl->SetCustData)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpStringContext>(lpVtbl->SetHelpStringContext)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpStringDll([NativeTypeName("LPOLESTR")] ushort* szFileName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpStringDll>(lpVtbl->SetHelpStringDll)((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szFileName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPOLESTR, TYPEKIND, ICreateTypeInfo **) __attribute__((stdcall))")]
            public IntPtr CreateTypeInfo;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetName;

            [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
            public IntPtr SetVersion;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public IntPtr SetGuid;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetDocString;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetHelpFileName;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr SetHelpContext;

            [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
            public IntPtr SetLcid;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetLibFlags;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr SaveAllChanges;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr DeleteTypeInfo;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr SetCustData;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr SetHelpStringContext;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetHelpStringDll;
        }
    }
}
