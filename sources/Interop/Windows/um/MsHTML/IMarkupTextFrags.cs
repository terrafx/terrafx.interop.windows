// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F5FA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IMarkupTextFrags : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMarkupTextFrags
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTextFragCount([NativeTypeName("long *")] int* pcFrags)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int*, int>)(lpVtbl[3]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), pcFrags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextFrag([NativeTypeName("long")] int iFrag, [NativeTypeName("BSTR *")] ushort** pbstrFrag, IMarkupPointer* pPointerFrag)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int, ushort**, IMarkupPointer*, int>)(lpVtbl[4]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), iFrag, pbstrFrag, pPointerFrag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveTextFrag([NativeTypeName("long")] int iFrag)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int, int>)(lpVtbl[5]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), iFrag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int InsertTextFrag([NativeTypeName("long")] int iFrag, [NativeTypeName("BSTR")] ushort* bstrInsert, IMarkupPointer* pPointerInsert)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, int, ushort*, IMarkupPointer*, int>)(lpVtbl[6]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), iFrag, bstrInsert, pPointerInsert);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int FindTextFragFromMarkupPointer(IMarkupPointer* pPointerFind, [NativeTypeName("long *")] int* piFrag, [NativeTypeName("BOOL *")] int* pfFragFound)
        {
            return ((delegate* unmanaged<IMarkupTextFrags*, IMarkupPointer*, int*, int*, int>)(lpVtbl[7]))((IMarkupTextFrags*)Unsafe.AsPointer(ref this), pPointerFind, piFrag, pfFragFound);
        }
    }
}
