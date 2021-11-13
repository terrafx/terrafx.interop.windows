// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("A7ABA9C1-8983-11CF-8F20-00805F2CD064")]
    [NativeTypeName("struct IProvideMultipleClassInfo : IProvideClassInfo2")]
    [NativeInheritance("IProvideClassInfo2")]
    public unsafe partial struct IProvideMultipleClassInfo : IProvideMultipleClassInfo.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProvideMultipleClassInfo*, Guid*, void**, int>)(lpVtbl[0]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint>)(lpVtbl[1]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint>)(lpVtbl[2]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassInfo(ITypeInfo** ppTI)
        {
            return ((delegate* unmanaged<IProvideMultipleClassInfo*, ITypeInfo**, int>)(lpVtbl[3]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), ppTI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, Guid* pGUID)
        {
            return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint, Guid*, int>)(lpVtbl[4]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti)
        {
            return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint*, int>)(lpVtbl[5]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), pcti);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetInfoOfIndex([NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource)
        {
            return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)(lpVtbl[6]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        }

        public interface Interface : IProvideClassInfo2.Interface
        {
            [VtblIndex(5)]
            HRESULT GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti);

            [VtblIndex(6)]
            HRESULT GetInfoOfIndex([NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProvideMultipleClassInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProvideMultipleClassInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProvideMultipleClassInfo*, uint> Release;

            [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProvideMultipleClassInfo*, ITypeInfo**, int> GetClassInfo;

            [NativeTypeName("HRESULT (DWORD, GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IProvideMultipleClassInfo*, uint, Guid*, int> GetGUID;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IProvideMultipleClassInfo*, uint*, int> GetMultiTypeInfoCount;

            [NativeTypeName("HRESULT (ULONG, DWORD, ITypeInfo **, DWORD *, ULONG *, IID *, IID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int> GetInfoOfIndex;
        }
    }
}
