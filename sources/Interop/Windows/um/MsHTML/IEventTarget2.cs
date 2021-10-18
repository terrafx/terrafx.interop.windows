// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510839-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IEventTarget2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEventTarget2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEventTarget2*, Guid*, void**, int>)(lpVtbl[0]))((IEventTarget2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEventTarget2*, uint>)(lpVtbl[1]))((IEventTarget2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEventTarget2*, uint>)(lpVtbl[2]))((IEventTarget2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegisteredEventTypes(SAFEARRAY** ppEventTypeArray)
        {
            return ((delegate* unmanaged<IEventTarget2*, SAFEARRAY**, int>)(lpVtbl[3]))((IEventTarget2*)Unsafe.AsPointer(ref this), ppEventTypeArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetListenersForType([NativeTypeName("LPCWSTR")] ushort* pszEventType, SAFEARRAY** ppEventHandlerArray)
        {
            return ((delegate* unmanaged<IEventTarget2*, ushort*, SAFEARRAY**, int>)(lpVtbl[4]))((IEventTarget2*)Unsafe.AsPointer(ref this), pszEventType, ppEventHandlerArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterForDOMEventListeners(IDOMEventRegistrationCallback* pCallback)
        {
            return ((delegate* unmanaged<IEventTarget2*, IDOMEventRegistrationCallback*, int>)(lpVtbl[5]))((IEventTarget2*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterForDOMEventListeners(IDOMEventRegistrationCallback* pCallback)
        {
            return ((delegate* unmanaged<IEventTarget2*, IDOMEventRegistrationCallback*, int>)(lpVtbl[6]))((IEventTarget2*)Unsafe.AsPointer(ref this), pCallback);
        }
    }
}
