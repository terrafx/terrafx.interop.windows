// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct QACONTAINER
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        public IOleClientSite* pClientSite;

        public IAdviseSinkEx* pAdviseSink;

        public IPropertyNotifySink* pPropertyNotifySink;

        public IUnknown* pUnkEventSink;

        [NativeTypeName("DWORD")]
        public uint dwAmbientFlags;

        [NativeTypeName("OLE_COLOR")]
        public uint colorFore;

        [NativeTypeName("OLE_COLOR")]
        public uint colorBack;

        public IFont* pFont;

        public IOleUndoManager* pUndoMgr;

        [NativeTypeName("DWORD")]
        public uint dwAppearance;

        [NativeTypeName("LONG")]
        public int lcid;

        [NativeTypeName("HPALETTE")]
        public IntPtr hpal;

        public IBindHost* pBindHost;

        public IOleControlSite* pOleControlSite;

        public IServiceProvider* pServiceProvider;
    }
}
