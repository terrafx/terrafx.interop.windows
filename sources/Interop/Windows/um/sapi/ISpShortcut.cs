// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3DF681E2-EA56-11D9-8BDE-F66BAD1E3F3A")]
    [NativeTypeName("struct ISpShortcut : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpShortcut
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpShortcut*, Guid*, void**, int>)(lpVtbl[0]))((ISpShortcut*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpShortcut*, uint>)(lpVtbl[1]))((ISpShortcut*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpShortcut*, uint>)(lpVtbl[2]))((ISpShortcut*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType)
        {
            return ((delegate* unmanaged<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int>)(lpVtbl[3]))((ISpShortcut*)Unsafe.AsPointer(ref this), pszDisplay, LangID, pszSpoken, shType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RemoveShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType)
        {
            return ((delegate* unmanaged<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int>)(lpVtbl[4]))((ISpShortcut*)Unsafe.AsPointer(ref this), pszDisplay, LangID, pszSpoken, shType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetShortcuts([NativeTypeName("WORD")] ushort LangID, SPSHORTCUTPAIRLIST* pShortcutpairList)
        {
            return ((delegate* unmanaged<ISpShortcut*, ushort, SPSHORTCUTPAIRLIST*, int>)(lpVtbl[5]))((ISpShortcut*)Unsafe.AsPointer(ref this), LangID, pShortcutpairList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
        {
            return ((delegate* unmanaged<ISpShortcut*, uint*, int>)(lpVtbl[6]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetWordsFromGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, SPWORDLIST* pWordList)
        {
            return ((delegate* unmanaged<ISpShortcut*, uint*, SPWORDLIST*, int>)(lpVtbl[7]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pWordList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetWords([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPWORDLIST* pWordList)
        {
            return ((delegate* unmanaged<ISpShortcut*, uint*, uint*, SPWORDLIST*, int>)(lpVtbl[8]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pdwCookie, pWordList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetShortcutsForGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPSHORTCUTPAIRLIST* pShortcutpairList)
        {
            return ((delegate* unmanaged<ISpShortcut*, uint*, uint*, SPSHORTCUTPAIRLIST*, int>)(lpVtbl[9]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pdwCookie, pShortcutpairList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, SPSHORTCUTPAIRLIST* pShortcutpairList)
        {
            return ((delegate* unmanaged<ISpShortcut*, uint*, SPSHORTCUTPAIRLIST*, int>)(lpVtbl[10]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pShortcutpairList);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, WORD, LPCWSTR, SPSHORTCUTTYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int> AddShortcut;

            [NativeTypeName("HRESULT (LPCWSTR, WORD, LPCWSTR, SPSHORTCUTTYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int> RemoveShortcut;

            [NativeTypeName("HRESULT (WORD, SPSHORTCUTPAIRLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, ushort, SPSHORTCUTPAIRLIST*, int> GetShortcuts;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, uint*, int> GetGeneration;

            [NativeTypeName("HRESULT (DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, uint*, SPWORDLIST*, int> GetWordsFromGenerationChange;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, uint*, uint*, SPWORDLIST*, int> GetWords;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, SPSHORTCUTPAIRLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, uint*, uint*, SPSHORTCUTPAIRLIST*, int> GetShortcutsForGeneration;

            [NativeTypeName("HRESULT (DWORD *, SPSHORTCUTPAIRLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpShortcut*, uint*, SPSHORTCUTPAIRLIST*, int> GetGenerationChange;
        }
    }
}
