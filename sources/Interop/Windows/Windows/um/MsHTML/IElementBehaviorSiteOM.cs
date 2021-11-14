// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F489-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehaviorSiteOM : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementBehaviorSiteOM : IElementBehaviorSiteOM.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, uint>)(lpVtbl[1]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, uint>)(lpVtbl[2]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterEvent([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG *")] int* plCookie)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int, int*, int>)(lpVtbl[3]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this), pchEvent, lFlags, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetEventCookie([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG *")] int* plCookie)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int*, int>)(lpVtbl[4]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this), pchEvent, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FireEvent([NativeTypeName("LONG")] int lCookie, IHTMLEventObj* pEventObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, int, IHTMLEventObj*, int>)(lpVtbl[5]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this), lCookie, pEventObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateEventObject(IHTMLEventObj** ppEventObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, IHTMLEventObj**, int>)(lpVtbl[6]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this), ppEventObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RegisterName([NativeTypeName("LPOLESTR")] ushort* pchName)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int>)(lpVtbl[7]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this), pchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RegisterUrn([NativeTypeName("LPOLESTR")] ushort* pchUrn)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int>)(lpVtbl[8]))((IElementBehaviorSiteOM*)Unsafe.AsPointer(ref this), pchUrn);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT RegisterEvent([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG *")] int* plCookie);

            [VtblIndex(4)]
            HRESULT GetEventCookie([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG *")] int* plCookie);

            [VtblIndex(5)]
            HRESULT FireEvent([NativeTypeName("LONG")] int lCookie, IHTMLEventObj* pEventObject);

            [VtblIndex(6)]
            HRESULT CreateEventObject(IHTMLEventObj** ppEventObject);

            [VtblIndex(7)]
            HRESULT RegisterName([NativeTypeName("LPOLESTR")] ushort* pchName);

            [VtblIndex(8)]
            HRESULT RegisterUrn([NativeTypeName("LPOLESTR")] ushort* pchUrn);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, uint> Release;

            [NativeTypeName("HRESULT (LPOLESTR, LONG, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int, int*, int> RegisterEvent;

            [NativeTypeName("HRESULT (LPOLESTR, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int*, int> GetEventCookie;

            [NativeTypeName("HRESULT (LONG, IHTMLEventObj *) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, int, IHTMLEventObj*, int> FireEvent;

            [NativeTypeName("HRESULT (IHTMLEventObj **) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, IHTMLEventObj**, int> CreateEventObject;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int> RegisterName;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IElementBehaviorSiteOM*, ushort*, int> RegisterUrn;
        }
    }
}
