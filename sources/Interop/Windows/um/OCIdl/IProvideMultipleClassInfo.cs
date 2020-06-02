// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7ABA9C1-8983-11CF-8F20-00805F2CD064")]
    public unsafe partial struct IProvideMultipleClassInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassInfoA([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTI)
        {
            return lpVtbl->GetClassInfoA((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), ppTI);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, [NativeTypeName("GUID *")] Guid* pGUID)
        {
            return lpVtbl->GetGUID((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti)
        {
            return lpVtbl->GetMultiTypeInfoCount((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), pcti);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfoOfIndex([NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ITypeInfo **")] ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource)
        {
            return lpVtbl->GetInfoOfIndex((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideMultipleClassInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IProvideMultipleClassInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IProvideMultipleClassInfo*, uint> Release;

            [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideMultipleClassInfo*, ITypeInfo**, int> GetClassInfoA;

            [NativeTypeName("HRESULT (DWORD, GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideMultipleClassInfo*, uint, Guid*, int> GetGUID;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideMultipleClassInfo*, uint*, int> GetMultiTypeInfoCount;

            [NativeTypeName("HRESULT (ULONG, DWORD, ITypeInfo **, DWORD *, ULONG *, IID *, IID *) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int> GetInfoOfIndex;
        }
    }
}
