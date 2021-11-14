// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F5FA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IMarkupTextFrags : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMarkupTextFrags : IMarkupTextFrags.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, Guid*, void**, int>)(lpVtbl[0]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, uint>)(lpVtbl[1]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, uint>)(lpVtbl[2]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTextFragCount([NativeTypeName("long *")] int* pcFrags)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int*, int>)(lpVtbl[3]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), pcFrags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTextFrag([NativeTypeName("long")] int iFrag, [NativeTypeName("BSTR *")] ushort** pbstrFrag, IMarkupPointer* pPointerFrag)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int, ushort**, IMarkupPointer*, int>)(lpVtbl[4]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), iFrag, pbstrFrag, pPointerFrag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RemoveTextFrag([NativeTypeName("long")] int iFrag)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int, int>)(lpVtbl[5]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), iFrag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT InsertTextFrag([NativeTypeName("long")] int iFrag, [NativeTypeName("BSTR")] ushort* bstrInsert, IMarkupPointer* pPointerInsert)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int, ushort*, IMarkupPointer*, int>)(lpVtbl[6]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), iFrag, bstrInsert, pPointerInsert);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT FindTextFragFromMarkupPointer(IMarkupPointer* pPointerFind, [NativeTypeName("long *")] int* piFrag, BOOL* pfFragFound)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, IMarkupPointer*, int*, BOOL*, int>)(lpVtbl[7]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), pPointerFind, piFrag, pfFragFound);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetTextFragCount([NativeTypeName("long *")] int* pcFrags);

            [VtblIndex(4)]
            HRESULT GetTextFrag([NativeTypeName("long")] int iFrag, [NativeTypeName("BSTR *")] ushort** pbstrFrag, IMarkupPointer* pPointerFrag);

            [VtblIndex(5)]
            HRESULT RemoveTextFrag([NativeTypeName("long")] int iFrag);

            [VtblIndex(6)]
            HRESULT InsertTextFrag([NativeTypeName("long")] int iFrag, [NativeTypeName("BSTR")] ushort* bstrInsert, IMarkupPointer* pPointerInsert);

            [VtblIndex(7)]
            HRESULT FindTextFragFromMarkupPointer(IMarkupPointer* pPointerFind, [NativeTypeName("long *")] int* piFrag, BOOL* pfFragFound);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, uint> Release;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, int*, int> GetTextFragCount;

            [NativeTypeName("HRESULT (long, BSTR *, IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, int, ushort**, IMarkupPointer*, int> GetTextFrag;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, int, int> RemoveTextFrag;

            [NativeTypeName("HRESULT (long, BSTR, IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, int, ushort*, IMarkupPointer*, int> InsertTextFrag;

            [NativeTypeName("HRESULT (IMarkupPointer *, long *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupTextFrags*, IMarkupPointer*, int*, BOOL*, int> FindTextFragFromMarkupPointer;
        }
    }
}
