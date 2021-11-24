// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct AM_DVD_RENDERSTATUS
{
    public HRESULT hrVPEStatus;

    public BOOL bDvdVolInvalid;

    public BOOL bDvdVolUnknown;

    public BOOL bNoLine21In;

    public BOOL bNoLine21Out;

    public int iNumStreams;

    public int iNumStreamsFailed;

    [NativeTypeName("DWORD")]
    public uint dwFailedStreamsFlag;
}
