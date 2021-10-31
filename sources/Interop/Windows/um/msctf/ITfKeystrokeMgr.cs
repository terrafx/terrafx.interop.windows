// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E7F0-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfKeystrokeMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfKeystrokeMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, uint>)(lpVtbl[1]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, uint>)(lpVtbl[2]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseKeyEventSink([NativeTypeName("TfClientId")] uint tid, ITfKeyEventSink* pSink, BOOL fForeground)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, uint, ITfKeyEventSink*, BOOL, int>)(lpVtbl[3]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), tid, pSink, fForeground);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseKeyEventSink([NativeTypeName("TfClientId")] uint tid)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, uint, int>)(lpVtbl[4]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), tid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetForeground([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, Guid*, int>)(lpVtbl[5]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT TestKeyDown([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, nuint, nint, BOOL*, int>)(lpVtbl[6]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT TestKeyUp([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, nuint, nint, BOOL*, int>)(lpVtbl[7]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT KeyDown([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, nuint, nint, BOOL*, int>)(lpVtbl[8]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT KeyUp([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, nuint, nint, BOOL*, int>)(lpVtbl[9]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetPreservedKey(ITfContext* pic, [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey, [NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, ITfContext*, TF_PRESERVEDKEY*, Guid*, int>)(lpVtbl[10]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), pic, pprekey, pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT IsPreservedKey([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey, BOOL* pfRegistered)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, Guid*, TF_PRESERVEDKEY*, BOOL*, int>)(lpVtbl[11]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), rguid, pprekey, pfRegistered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT PreserveKey([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* prekey, [NativeTypeName("const WCHAR *")] ushort* pchDesc, [NativeTypeName("ULONG")] uint cchDesc)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, uint, Guid*, TF_PRESERVEDKEY*, ushort*, uint, int>)(lpVtbl[12]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), tid, rguid, prekey, pchDesc, cchDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT UnpreserveKey([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, Guid*, TF_PRESERVEDKEY*, int>)(lpVtbl[13]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), rguid, pprekey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetPreservedKeyDescription([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const WCHAR *")] ushort* pchDesc, [NativeTypeName("ULONG")] uint cchDesc)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, Guid*, ushort*, uint, int>)(lpVtbl[14]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), rguid, pchDesc, cchDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetPreservedKeyDescription([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("BSTR *")] ushort** pbstrDesc)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, Guid*, ushort**, int>)(lpVtbl[15]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), rguid, pbstrDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SimulatePreservedKey(ITfContext* pic, [NativeTypeName("const GUID &")] Guid* rguid, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeystrokeMgr*, ITfContext*, Guid*, BOOL*, int>)(lpVtbl[16]))((ITfKeystrokeMgr*)Unsafe.AsPointer(ref this), pic, rguid, pfEaten);
        }
    }
}
