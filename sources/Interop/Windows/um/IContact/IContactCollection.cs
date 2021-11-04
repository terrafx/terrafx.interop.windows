// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B6AFA338-D779-11D9-8BDE-F66BAD1E3F3A")]
    [NativeTypeName("struct IContactCollection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IContactCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContactCollection*, Guid*, void**, int>)(lpVtbl[0]))((IContactCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContactCollection*, uint>)(lpVtbl[1]))((IContactCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContactCollection*, uint>)(lpVtbl[2]))((IContactCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IContactCollection*, int>)(lpVtbl[3]))((IContactCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Next()
        {
            return ((delegate* unmanaged<IContactCollection*, int>)(lpVtbl[4]))((IContactCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCurrent(IContact** ppContact)
        {
            return ((delegate* unmanaged<IContactCollection*, IContact**, int>)(lpVtbl[5]))((IContactCollection*)Unsafe.AsPointer(ref this), ppContact);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactCollection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactCollection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactCollection*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactCollection*, int> Reset;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactCollection*, int> Next;

            [NativeTypeName("HRESULT (IContact **) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactCollection*, IContact**, int> GetCurrent;
        }
    }
}
