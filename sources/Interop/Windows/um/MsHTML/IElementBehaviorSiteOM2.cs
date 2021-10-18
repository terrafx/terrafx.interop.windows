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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int RegisterEvent([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG *")] int* plCookie)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int, int*, int>)(lpVtbl[3]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchEvent, lFlags, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetEventCookie([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG *")] int* plCookie)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int*, int>)(lpVtbl[4]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchEvent, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int FireEvent([NativeTypeName("LONG")] int lCookie, IHTMLEventObj* pEventObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, int, IHTMLEventObj*, int>)(lpVtbl[5]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), lCookie, pEventObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEventObject(IHTMLEventObj** ppEventObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLEventObj**, int>)(lpVtbl[6]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), ppEventObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterName([NativeTypeName("LPOLESTR")] ushort* pchName)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int>)(lpVtbl[7]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterUrn([NativeTypeName("LPOLESTR")] ushort* pchUrn)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int>)(lpVtbl[8]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchUrn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaults(IHTMLElementDefaults** ppDefaults)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLElementDefaults**, int>)(lpVtbl[9]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), ppDefaults);
        }
    }
}
