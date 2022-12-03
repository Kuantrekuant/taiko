﻿using System.Collections.Immutable;

namespace TaikoLocalServer.Services.Interfaces;

public interface IGameDataService
{
    public Task InitializeAsync();

    public List<uint> GetMusicList();

    public List<uint> GetMusicWithUraList();

    public ImmutableDictionary<uint, MusicAttributeEntry> GetMusicAttributes();

    public ImmutableDictionary<uint, GetDanOdaiResponse.OdaiData> GetDanDataDictionary();

    public ImmutableDictionary<uint, GetSongIntroductionResponse.SongIntroductionData> GetSongIntroDictionary();
}