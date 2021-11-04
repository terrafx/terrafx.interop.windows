// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F659-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehaviorSiteOM2 : IElementBehaviorSiteOM")]
    [NativeInheritance("IElementBehaviorSiteOM")]
    public unsafe partial struct IElementBehaviorSiteOM2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, uint>)(lpVtbl[1]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, uint>)(lpVtbl[2]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterEvent([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG *")] int* plCookie)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int, int*, int>)(lpVtbl[3]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchEvent, lFlags, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetEventCookie([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG *")] int* plCookie)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int*, int>)(lpVtbl[4]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchEvent, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FireEvent([NativeTypeName("LONG")] int lCookie, IHTMLEventObj* pEventObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, int, IHTMLEventObj*, int>)(lpVtbl[5]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), lCookie, pEventObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateEventObject(IHTMLEventObj** ppEventObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLEventObj**, int>)(lpVtbl[6]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), ppEventObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RegisterName([NativeTypeName("LPOLESTR")] ushort* pchName)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int>)(lpVtbl[7]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RegisterUrn([NativeTypeName("LPOLESTR")] ushort* pchUrn)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int>)(lpVtbl[8]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchUrn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDefaults(IHTMLElementDefaults** ppDefaults)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLElementDefaults**, int>)(lpVtbl[9]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), ppDefaults);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, uint> Release;

            [NativeTypeName("HRESULT (LPOLESTR, LONG, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int, int*, int> RegisterEvent;

            [NativeTypeName("HRESULT (LPOLESTR, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int*, int> GetEventCookie;

            [NativeTypeName("HRESULT (LONG, IHTMLEventObj *) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, int, IHTMLEventObj*, int> FireEvent;

            [NativeTypeName("HRESULT (IHTMLEventObj **) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLEventObj**, int> CreateEventObject;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int> RegisterName;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int> RegisterUrn;

            [NativeTypeName("HRESULT (IHTMLElementDefaults **) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLElementDefaults**, int> GetDefaults;
        }
    }
}
