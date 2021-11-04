// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("88A05C00-F000-11CE-8350-444553540000")]
    [NativeTypeName("struct IShellLinkDual : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IShellLinkDual
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellLinkDual*, Guid*, void**, int>)(lpVtbl[0]))((IShellLinkDual*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellLinkDual*, uint>)(lpVtbl[1]))((IShellLinkDual*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellLinkDual*, uint>)(lpVtbl[2]))((IShellLinkDual*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellLinkDual*, uint*, int>)(lpVtbl[3]))((IShellLinkDual*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellLinkDual*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellLinkDual*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellLinkDual*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellLinkDual*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellLinkDual*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellLinkDual*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort**, int>)(lpVtbl[7]))((IShellLinkDual*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_Path([NativeTypeName("BSTR")] ushort* bs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort*, int>)(lpVtbl[8]))((IShellLinkDual*)Unsafe.AsPointer(ref this), bs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Description([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort**, int>)(lpVtbl[9]))((IShellLinkDual*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_Description([NativeTypeName("BSTR")] ushort* bs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort*, int>)(lpVtbl[10]))((IShellLinkDual*)Unsafe.AsPointer(ref this), bs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort**, int>)(lpVtbl[11]))((IShellLinkDual*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_WorkingDirectory([NativeTypeName("BSTR")] ushort* bs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort*, int>)(lpVtbl[12]))((IShellLinkDual*)Unsafe.AsPointer(ref this), bs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_Arguments([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort**, int>)(lpVtbl[13]))((IShellLinkDual*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_Arguments([NativeTypeName("BSTR")] ushort* bs)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort*, int>)(lpVtbl[14]))((IShellLinkDual*)Unsafe.AsPointer(ref this), bs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_Hotkey(int* piHK)
        {
            return ((delegate* unmanaged<IShellLinkDual*, int*, int>)(lpVtbl[15]))((IShellLinkDual*)Unsafe.AsPointer(ref this), piHK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_Hotkey(int iHK)
        {
            return ((delegate* unmanaged<IShellLinkDual*, int, int>)(lpVtbl[16]))((IShellLinkDual*)Unsafe.AsPointer(ref this), iHK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_ShowCommand(int* piShowCommand)
        {
            return ((delegate* unmanaged<IShellLinkDual*, int*, int>)(lpVtbl[17]))((IShellLinkDual*)Unsafe.AsPointer(ref this), piShowCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_ShowCommand(int iShowCommand)
        {
            return ((delegate* unmanaged<IShellLinkDual*, int, int>)(lpVtbl[18]))((IShellLinkDual*)Unsafe.AsPointer(ref this), iShowCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT Resolve(int fFlags)
        {
            return ((delegate* unmanaged<IShellLinkDual*, int, int>)(lpVtbl[19]))((IShellLinkDual*)Unsafe.AsPointer(ref this), fFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetIconLocation([NativeTypeName("BSTR *")] ushort** pbs, int* piIcon)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort**, int*, int>)(lpVtbl[20]))((IShellLinkDual*)Unsafe.AsPointer(ref this), pbs, piIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetIconLocation([NativeTypeName("BSTR")] ushort* bs, int iIcon)
        {
            return ((delegate* unmanaged<IShellLinkDual*, ushort*, int, int>)(lpVtbl[21]))((IShellLinkDual*)Unsafe.AsPointer(ref this), bs, iIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT Save(VARIANT vWhere)
        {
            return ((delegate* unmanaged<IShellLinkDual*, VARIANT, int>)(lpVtbl[22]))((IShellLinkDual*)Unsafe.AsPointer(ref this), vWhere);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort**, int> get_Path;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort*, int> put_Path;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort**, int> get_Description;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort*, int> put_Description;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort**, int> get_WorkingDirectory;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort*, int> put_WorkingDirectory;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort**, int> get_Arguments;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort*, int> put_Arguments;

            [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, int*, int> get_Hotkey;

            [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, int, int> put_Hotkey;

            [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, int*, int> get_ShowCommand;

            [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, int, int> put_ShowCommand;

            [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, int, int> Resolve;

            [NativeTypeName("HRESULT (BSTR *, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort**, int*, int> GetIconLocation;

            [NativeTypeName("HRESULT (BSTR, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, ushort*, int, int> SetIconLocation;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellLinkDual*, VARIANT, int> Save;
        }
    }
}
