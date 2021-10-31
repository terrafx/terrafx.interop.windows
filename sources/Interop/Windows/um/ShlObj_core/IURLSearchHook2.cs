// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5EE44DA4-6D32-46E3-86BC-07540DEDD0E0")]
    [NativeTypeName("struct IURLSearchHook2 : IURLSearchHook")]
    [NativeInheritance("IURLSearchHook")]
    public unsafe partial struct IURLSearchHook2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IURLSearchHook2*, Guid*, void**, int>)(lpVtbl[0]))((IURLSearchHook2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IURLSearchHook2*, uint>)(lpVtbl[1]))((IURLSearchHook2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IURLSearchHook2*, uint>)(lpVtbl[2]))((IURLSearchHook2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Translate([NativeTypeName("PWSTR")] ushort* pwszSearchURL, [NativeTypeName("DWORD")] uint cchBufferSize)
        {
            return ((delegate* unmanaged<IURLSearchHook2*, ushort*, uint, int>)(lpVtbl[3]))((IURLSearchHook2*)Unsafe.AsPointer(ref this), pwszSearchURL, cchBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT TranslateWithSearchContext([NativeTypeName("PWSTR")] ushort* pwszSearchURL, [NativeTypeName("DWORD")] uint cchBufferSize, ISearchContext* pSearchContext)
        {
            return ((delegate* unmanaged<IURLSearchHook2*, ushort*, uint, ISearchContext*, int>)(lpVtbl[4]))((IURLSearchHook2*)Unsafe.AsPointer(ref this), pwszSearchURL, cchBufferSize, pSearchContext);
        }
    }
}
