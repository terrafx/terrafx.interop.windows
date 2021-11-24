// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct DVD_KaraokeAttributes
{
    public byte bVersion;

    public BOOL fMasterOfCeremoniesInGuideVocal1;

    public BOOL fDuet;

    public DVD_KARAOKE_ASSIGNMENT ChannelAssignment;

    [NativeTypeName("WORD [8]")]
    public fixed ushort wChannelContents[8];
}
