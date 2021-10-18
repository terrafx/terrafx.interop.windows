// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051083B-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDOMEventRegistrationCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDOMEventRegistrationCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDOMEventRegistrationCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDOMEventRegistrationCallback*, uint>)(lpVtbl[1]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDOMEventRegistrationCallback*, uint>)(lpVtbl[2]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnDOMEventListenerAdded([NativeTypeName("LPCWSTR")] ushort* pszEventType, IScriptEventHandler* pHandler)
        {
            return ((delegate* unmanaged<IDOMEventRegistrationCallback*, ushort*, IScriptEventHandler*, int>)(lpVtbl[3]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), pszEventType, pHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnDOMEventListenerRemoved([NativeTypeName("ULONGLONG")] ulong ullCookie)
        {
            return ((delegate* unmanaged<IDOMEventRegistrationCallback*, ulong, int>)(lpVtbl[4]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), ullCookie);
        }
    }
}
