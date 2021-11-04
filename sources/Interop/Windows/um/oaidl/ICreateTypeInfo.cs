// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020405-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICreateTypeInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICreateTypeInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint>)(lpVtbl[1]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint>)(lpVtbl[2]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, Guid*, int>)(lpVtbl[3]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetTypeFlags(uint uTypeFlags)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, int>)(lpVtbl[4]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort*, int>)(lpVtbl[5]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, int>)(lpVtbl[6]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort, ushort, int>)(lpVtbl[7]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AddRefTypeInfo(ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ITypeInfo*, uint*, int>)(lpVtbl[8]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AddFuncDesc(uint index, FUNCDESC* pFuncDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, FUNCDESC*, int>)(lpVtbl[9]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT AddImplType(uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[10]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetImplTypeFlags(uint index, int implTypeFlags)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, int, int>)(lpVtbl[11]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort, int>)(lpVtbl[12]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort*, int>)(lpVtbl[13]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT AddVarDesc(uint index, VARDESC* pVarDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, VARDESC*, int>)(lpVtbl[14]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetFuncAndParamNames(uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort**, uint, int>)(lpVtbl[15]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetVarName(uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[16]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTypeDescAlias(TYPEDESC* pTDescAlias)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, TYPEDESC*, int>)(lpVtbl[17]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT DefineFuncAsDllEntry(uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, ushort*, int>)(lpVtbl[18]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetFuncDocString(uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[19]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetVarDocString(uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[20]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetFuncHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[21]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetVarHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[22]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetMops(uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[23]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetTypeIdldesc(IDLDESC* pIdlDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, IDLDESC*, int>)(lpVtbl[24]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT LayOut()
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, int>)(lpVtbl[25]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, Guid*, int> SetGuid;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, int> SetTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, ushort*, int> SetDocString;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, int> SetHelpContext;

            [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, ushort, ushort, int> SetVersion;

            [NativeTypeName("HRESULT (ITypeInfo *, HREFTYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, ITypeInfo*, uint*, int> AddRefTypeInfo;

            [NativeTypeName("HRESULT (UINT, FUNCDESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, FUNCDESC*, int> AddFuncDesc;

            [NativeTypeName("HRESULT (UINT, HREFTYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, uint, int> AddImplType;

            [NativeTypeName("HRESULT (UINT, INT) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, int, int> SetImplTypeFlags;

            [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, ushort, int> SetAlignment;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, ushort*, int> SetSchema;

            [NativeTypeName("HRESULT (UINT, VARDESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, VARDESC*, int> AddVarDesc;

            [NativeTypeName("HRESULT (UINT, LPOLESTR *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, ushort**, uint, int> SetFuncAndParamNames;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int> SetVarName;

            [NativeTypeName("HRESULT (TYPEDESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, TYPEDESC*, int> SetTypeDescAlias;

            [NativeTypeName("HRESULT (UINT, LPOLESTR, LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, ushort*, int> DefineFuncAsDllEntry;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int> SetFuncDocString;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int> SetVarDocString;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, uint, int> SetFuncHelpContext;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, uint, int> SetVarHelpContext;

            [NativeTypeName("HRESULT (UINT, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int> SetMops;

            [NativeTypeName("HRESULT (IDLDESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, IDLDESC*, int> SetTypeIdldesc;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeInfo*, int> LayOut;
        }
    }
}
